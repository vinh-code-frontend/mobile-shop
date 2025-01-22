using App.Application.Interfaces;
using App.Application.IRepositories;
using App.Application.IServices;
using App.Core.DTO;
using App.Core.Entities;
using Microsoft.Extensions.Configuration;

namespace App.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;
        private readonly IConfiguration configuration;
        private readonly ITokenService tokenService;
        public AdminService(IAdminRepository adminRepository, IConfiguration configuration, ITokenService tokenService)
        {
            this.adminRepository = adminRepository;
            this.configuration = configuration;
            this.tokenService = tokenService;
        }

        public async Task<bool> ValidateRegisterRequest(AdminRegisterRequestDTO? request)
        {
            if (request == null)
            {
                return false;
            }
            if (string.IsNullOrEmpty(request.Email)
                || string.IsNullOrEmpty(request.Username)
                || string.IsNullOrEmpty(request.Password)
                || string.IsNullOrEmpty(request.DisplayName)
            )
            {
                return false;
            }
            Admin? admin = await adminRepository.GetAdminByEmail(request.Email);
            if (admin != null)
            {
                return false;
            }
            return true;
        }
        public async Task<Admin> Register(AdminRegisterRequestDTO adminRequest)
        {
            Admin admin = adminRequest.ToAdmin();
            admin.Id = Guid.NewGuid();
            Admin newAdmin = await adminRepository.CreateAdmin(admin);

            int accessTokenExpiredIn = configuration.GetValue<int>("Jwt:AccessTokenExpiredIn");
            int refreshTokenExpiredIn = configuration.GetValue<int>("Jwt:RefreshTokenExpiredIn");

            string accessToken = tokenService.GenerateAdminToken(admin, accessTokenExpiredIn);
            string refreshToken = tokenService.GenerateAdminToken(admin, refreshTokenExpiredIn);

            newAdmin.RefreshToken = refreshToken;
            newAdmin.RefreshTokenExpired = refreshTokenExpiredIn;

            await adminRepository.UpdateAdmin(newAdmin);

            AdminAuthResponseDTO adminAuthResponseDTO = new AdminAuthResponseDTO()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                AccessTokenExpiredIn = accessTokenExpiredIn,
                RefreshTokenExpiredIn = refreshTokenExpiredIn
            };
            return newAdmin;
        }


    }
}
