using App.Application.Interfaces;
using App.Application.IRepositories;
using App.Core.DTO;
using App.Core.Entities;

namespace App.Application.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
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
        public async Task<AdminAuthResponseDTO> Register(AdminRegisterRequestDTO adminRequest)
        {
            Admin admin = adminRequest.ToAdmin();
            admin.Id = Guid.NewGuid();
            Admin _admin = await adminRepository.CreateAdmin(admin);

            throw new NotImplementedException();
        }

    }
}
