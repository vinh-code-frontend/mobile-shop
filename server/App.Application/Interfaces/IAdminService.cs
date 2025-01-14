using App.Core.DTO;
using App.Core.Entities;

namespace App.Application.Interfaces
{
    public interface IAdminService
    {
        Task<bool> ValidateRegisterRequest(AdminRegisterRequestDTO? request);
        Task<AdminAuthResponseDTO> Register(Admin admin);
    }
}
