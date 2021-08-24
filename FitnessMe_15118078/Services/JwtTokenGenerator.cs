using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Identity;
using FitnessMe_15118078.Common;
using Microsoft.Extensions.Options;

namespace FitnessMe_15118078.Services
{
    public class JwtTokenGenerator
    {
        private readonly JwtConfigurations _jwtConfigurations;

        public JwtTokenGenerator(IOptions<JwtConfigurations> jwtConfigurations)
        {
            _jwtConfigurations = jwtConfigurations.Value;
        }

        public string Generate(IdentityUser user, IList<string> userRoles)
        {
            Claim[] roles = userRoles.Select(r => new Claim(ClaimTypes.Role, r)).ToArray();

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtConfigurations.Key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id)
                }.Union(roles)),
                Expires = DateTime.UtcNow.AddDays(_jwtConfigurations.ExpirationInDays),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
