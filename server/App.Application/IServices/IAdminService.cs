using App.Core.DTO;
using App.Core.Entities;

namespace App.Application.IServices
{
    public class AdminToken : AdminAuthResponseDTO
    {
        public DateTime RefreshTokenExpiredTime { get; set; }
        public AdminAuthResponseDTO ToResponse()
        {
            return new AdminAuthResponseDTO()
            {
                Id = Id,
                Username = Username,
                Email = Email,
                DisplayName = DisplayName,
                Role = Role,
                Status = Status,
                PhoneNumber = PhoneNumber,
                Address = Address,
                UpdatedAt = UpdatedAt,
                AccessToken = AccessToken,
                RefreshToken = RefreshToken,
                AccessTokenExpiredIn = AccessTokenExpiredIn,
                RefreshTokenExpiredIn = RefreshTokenExpiredIn
            };
        }
    }
    public interface IAdminService
    {
        Task<bool> ValidateRegisterRequest(AdminRegisterRequestDTO? request);
        AdminToken GenerateAdminResponse(Admin response);
        Task<Admin?> GetUserByUsernameAsync(string username);
        Task<AdminAuthResponseDTO> Register(AdminRegisterRequestDTO admin);
        Task<AdminAuthResponseDTO?> Login(AdminLoginRequestDTO adminLoginRequestDTO);
    }
}
