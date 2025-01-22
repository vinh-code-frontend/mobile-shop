using App.Core.DTO;
using App.Core.Entities;

namespace App.Application.IServices
{
    public interface IAdminService
    {
        Task<bool> ValidateRegisterRequest(AdminRegisterRequestDTO? request);
        Task<Admin> Register(AdminRegisterRequestDTO admin);
    }
}
