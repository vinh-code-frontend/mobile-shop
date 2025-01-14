using App.Core.Entities;

namespace App.Application.IRepositories
{
    public interface IAdminRepository
    {
        Task<Admin> CreateAdmin(Admin admin);
        Task<Admin?> GetAdminByEmail(string email);
    }
}
