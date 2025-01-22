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
            List<Claim> claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, admin.Id.ToString()),
                new Claim(ClaimTypes.Name, admin.Username.ToString()),
                new Claim(ClaimTypes.Email, admin.Email),
                new Claim(ClaimTypes.Role, admin.Role)
            };
            SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configration["Jwt:Key"]));
            SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            string _issuer = _configration["Jwt:Issuer"].ToString();

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _issuer,
                audience: null,
                claims: claims,
                expires: DateTime.Now.AddSeconds(expiredIn),
                signingCredentials: creds
            );
            token.Payload["aud"] = _configration["Jwt:Audiences"].ToArray();
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

    }
}
