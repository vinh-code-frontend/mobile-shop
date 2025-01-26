using App.Application.Interfaces;
using App.Application.IRepositories;
using App.Application.IServices;
using App.Application.Utilities;
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
            Admin? admin = await adminRepository.GetAdminByEmailAsync(request.Email);
            if (admin != null)
            {
                return false;
            }
            return true;
        }
        public AdminToken GenerateAdminResponse(Admin admin)
        {
            int accessTokenExpiredIn = configuration.GetValue<int>("Jwt:AccessTokenExpiredIn");
            int refreshTokenExpiredIn = configuration.GetValue<int>("Jwt:RefreshTokenExpiredIn");

            string accessToken = tokenService.GenerateAdminToken(admin, accessTokenExpiredIn);
            string refreshToken = tokenService.GenerateAdminToken(admin, refreshTokenExpiredIn);

            admin.RefreshToken = refreshToken;
            DateTime currentTime = DateTime.Now;
            DateTime expiredTime = currentTime.AddSeconds(refreshTokenExpiredIn);

            admin.RefreshTokenExpired = expiredTime;

            AdminToken adminToken = new AdminToken()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                AccessTokenExpiredIn = accessTokenExpiredIn - 1,
                RefreshTokenExpiredIn = refreshTokenExpiredIn - 1,
                RefreshTokenExpiredTime = expiredTime
            };
            return adminToken;
        }
        public async Task<AdminAuthResponseDTO> Register(AdminRegisterRequestDTO adminRequest)
        {
            Admin admin = adminRequest.ToAdmin();
            admin.Id = Guid.NewGuid();
            admin.PasswordHashed = PasswordHelper.HashPassword(adminRequest.Password);

            AdminToken adminToken = GenerateAdminResponse(admin);

            admin.RefreshToken = adminToken.RefreshToken;
            admin.RefreshTokenExpired = adminToken.RefreshTokenExpiredTime;

            Admin newAdmin = await adminRepository.CreateAdminAsync(admin);

            if (newAdmin == null)
            {
                throw new InvalidOperationException("Failed to create new admin");
            }

            return adminToken.ToResponse();
        }
        public async Task<Admin?> GetUserByUsernameAsync(string username)
        {
            Admin? admin = await adminRepository.GetAdminByUsernameAsync(username);
            return admin;
        }
        public async Task<AdminAuthResponseDTO?> Login(AdminLoginRequestDTO adminLoginRequestDTO)
        {
            Admin? admin = await adminRepository.GetAdminByUsernameAsync(adminLoginRequestDTO.Username);
            if (admin == null)
            {
                return null;
            }
            bool isPasswordMatch = PasswordHelper.VerifyPassword(adminLoginRequestDTO.Password, admin.PasswordHashed);
            if (isPasswordMatch == false)
            {
                return null;
            }
            AdminToken adminToken = GenerateAdminResponse(admin);

            AdminAuthResponseDTO adminAuthResponse = new()
            {
                Id = admin.Id,
                Username = admin.Username,
                Email = admin.Email,
                DisplayName = admin.DisplayName,
                Role = admin.Role,
                Status = admin.Status,
                PhoneNumber = admin.PhoneNumber,
                Address = admin.Address,
                UpdatedAt = admin.UpdatedAt,
                AccessToken = adminToken.AccessToken,
                RefreshToken = adminToken.RefreshToken,
                AccessTokenExpiredIn = adminToken.AccessTokenExpiredIn,
                RefreshTokenExpiredIn = adminToken.RefreshTokenExpiredIn,
            };
            return adminAuthResponse;
        }
    }
}
