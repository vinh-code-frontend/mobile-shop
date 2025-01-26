using App.Core.Constants;
using App.Core.Entities;

namespace App.Core.DTO
{
    public class AdminRegisterRequestDTO
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string DisplayName { get; set; } = String.Empty;
        public Admin ToAdmin()
        {
            return new Admin()
            {
                Username = Username,
                Email = Email,
                DisplayName = DisplayName
            };
        }
    }
    public class AdminLoginRequestDTO
    {
        public string Username { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
    public class AdminAuthResponseDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string DisplayName { get; set; } = String.Empty;
        public string Role { get; set; } = AdminRole.SalesAssociate;
        public string Status { get; set; } = AdminStatus.Active;
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string AccessToken { get; set; } = String.Empty;
        public int AccessTokenExpiredIn { get; set; }
        public string RefreshToken { get; set; } = String.Empty;
        public int RefreshTokenExpiredIn { get; set; }
    }
}
