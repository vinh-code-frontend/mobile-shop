using App.Core.Entities;

namespace App.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateAdminToken(Admin admin, int expiredIn);
    }
}
