using App.Core.Entities;

namespace App.Application.IRepositories
{
    public interface IAdminRepository
    {
        Task<Admin> CreateAdminAsync(Admin admin);
        Task<Admin?> UpdateAdminAsync(Admin admin);
        Task<Admin?> GetAdminByEmailAsync(string email);
        Task<Admin?> GetAdminByUsernameAsync(string username);
    }
}
