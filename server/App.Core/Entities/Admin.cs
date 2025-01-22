using App.Core.Constants;
using System.ComponentModel.DataAnnotations;

namespace App.Core.Entities
{
    public class Admin
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; } = String.Empty;
        [Required]
        [StringLength(255)]
        public string Password { get; set; } = String.Empty;
        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;
        [Required]
        [StringLength(100)]
        public string DisplayName { get; set; } = String.Empty;
        [Required]
        [StringLength(20)]
        public string Role { get; set; } = AdminRole.SalesAssociate;
        [Required]
        [StringLength(20)]
        public string Status { get; set; } = AdminStatus.Active;
        [StringLength(20)]
        public string? PhoneNumber { get; set; }
        [StringLength(255)]
        public string? Address { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }

        public Guid? CreatedById { get; set; }
        [StringLength(300)]
        public string? RefreshToken { get; set; }
        public int? RefreshTokenExpired { get; set; }

    }
}
