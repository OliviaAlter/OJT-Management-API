using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using API.Entities;
using API.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ojt_management_api.Entities;

namespace ojt_management_api.Services;

public class TokenServices : ITokenServices
{
    private readonly SymmetricSecurityKey _securityKey;

    public TokenServices(IConfiguration configuration)
    {
        _securityKey =
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["NotTokenKeyForSureSourceTrustMeDude"]));
    }

    public string CreateToken(Users user)
    {
        var claims = new List<Claim>
        {
            new(JwtRegisteredClaimNames.NameId, user.Username)
        };
        var credential = new SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha512Signature);

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(1),
            SigningCredentials = credential
        };

        var tokenHandler = new JwtSecurityTokenHandler();

        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}