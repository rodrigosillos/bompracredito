using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using BomPraCredito.Domain.Configurations;
using BomPraCredito.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System;

namespace BomPraCredito.Application.Services
{
    public class AuthService
    {
        private readonly JWTSettings _jwtSettings;

        public AuthService(JWTSettings jwtSettings)
        {
            _jwtSettings = jwtSettings;
        }

        public string GenerateToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Id),
                    new Claim(ClaimTypes.Role, user.Role)
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
