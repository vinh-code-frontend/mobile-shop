using App.Core.Entities;
using App.Infrastructure.Initial;
using Microsoft.EntityFrameworkCore;

#nullable disable
namespace App.Infrastructure.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public ApplicationDbContext()
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new AdminInitial(modelBuilder);
        }

    }
}
