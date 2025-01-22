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

        public async Task<Admin?> UpdateAdmin(Admin admin)
        {
            if (_dbContext.Admins == null)
            {
                return null;
            }
            Admin? matchAdmin = await _dbContext.Admins.FirstOrDefaultAsync(temp => temp.Id == admin.Id);
            if (matchAdmin == null)
            {
                return null;
            }
            matchAdmin.Password = admin.Password;
            matchAdmin.Email = admin.Email;
            matchAdmin.DisplayName = admin.DisplayName;
            matchAdmin.Role = admin.Role;
            matchAdmin.Status = admin.Status;
            matchAdmin.PhoneNumber = admin.PhoneNumber;
            matchAdmin.Address = admin.Address;
            matchAdmin.UpdatedAt = DateTime.Now;
            matchAdmin.RefreshToken = admin.RefreshToken;
            matchAdmin.RefreshTokenExpired = admin.RefreshTokenExpired;

            await _dbContext.SaveChangesAsync();

            return matchAdmin;
        }
    }
}
