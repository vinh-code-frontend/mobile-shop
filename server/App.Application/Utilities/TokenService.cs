using App.Application.Interfaces;
using App.Core.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace App.Application.Utilities
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configration;

        public TokenService(IConfiguration configration)
        {
            _configration = configration;
        }
        public string GenerateAdminToken(Admin admin, int expiredIn)
        {
            if (admin == null)
            {
                throw new ArgumentNullException(nameof(admin), "Admin cannot be null");
            }
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
                new Claim(ClaimTypes.Name, admin.Username.ToString()),
                new Claim(ClaimTypes.Email, admin.Email),
                new Claim(ClaimTypes.Role, admin.Role)
            };
            string[]? jwtAudience = _configration.GetSection("Jwt:Audiences").Get<string[]>();
            string? jwtKey = _configration.GetSection("Jwt:Key").Get<string>();
            string? jwtIssuer = _configration.GetSection("Jwt:Issuer").Get<string>();

            if (string.IsNullOrEmpty(jwtKey) || string.IsNullOrEmpty(jwtIssuer) || jwtAudience == null || jwtAudience.Length == 0)
            {
                throw new ArgumentNullException("JWT configuration values cannot be null or empty");
            }
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey));
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            string _issuer = _configration["Jwt:Issuer"].ToString();

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: jwtIssuer,
                audience: null,
                claims: claims,
                expires: DateTime.Now.AddSeconds(expiredIn),
                signingCredentials: creds
            );
            token.Payload["aud"] = string.Join(",", jwtAudience);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
