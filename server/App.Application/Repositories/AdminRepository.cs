using App.Application.IRepositories;
using App.Core.Entities;
using App.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Application.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public AdminRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Admin> CreateAdmin(Admin admin)
        {
            _dbContext.Admins.Add(admin);
            await _dbContext.SaveChangesAsync();
            return admin;
        }

        public async Task<Admin?> GetAdminByEmail(string email)
        {
            if (_dbContext.Admins == null)
            {
                return null;
            }
            return await _dbContext.Admins.FirstOrDefaultAsync(temp => temp.Email == email);
        }
    }
}
