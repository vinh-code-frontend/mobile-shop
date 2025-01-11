using App.Core.Constants;
using App.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace App.Infrastructure.Initial
{
    public class AdminInitial
    {
        private ModelBuilder _modelBuilder { get; set; }
        public AdminInitial(ModelBuilder modelBuilder)

        {
            _modelBuilder = modelBuilder;
            AddConstraint();
            SowSeeds();
        }
        public void AddConstraint()
        {
            _modelBuilder.Entity<Admin>()
                 .HasIndex(m => m.Username)
                 .IsUnique();
            _modelBuilder.Entity<Admin>()
                .HasIndex(m => m.Email)
                .IsUnique();
            _modelBuilder.Entity<Admin>()
                .Property(m => m.CreatedAt)
                .HasDefaultValueSql("GETDATE()");
            _modelBuilder.Entity<Admin>()
               .Property(m => m.Role)
               .HasDefaultValue(AdminRole.SalesAssociate);
            _modelBuilder.Entity<Admin>()
               .Property(m => m.Status)
               .HasDefaultValue(AdminStatus.Active);
        }
        public void SowSeeds()
        {

            var seedFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Seeds", "admins.json");
            if (File.Exists(seedFilePath))
            {
                var jsonData = File.ReadAllText(seedFilePath);

                List<Admin>? admins = JsonSerializer.Deserialize<List<Admin>>(jsonData);
                if (admins != null)
                {
                    foreach (Admin admin in admins)
                    {
                        _modelBuilder.Entity<Admin>().HasData(admin);
                    }
                }
            }
        }
    }
}
