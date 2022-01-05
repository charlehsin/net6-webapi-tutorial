using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace TodoApi.Authentication;

public class JwtAuth : GeneralAuth, IJwtAuth
{
    private readonly string _key;

    public JwtAuth(string key)
    {
        _key = key;
    }

    public string GetToken(string userName, IList<string> roles)
    {
        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();

        var tokenKey = Encoding.ASCII.GetBytes(_key);

        var securityTokenDescriptor = new SecurityTokenDescriptor()
        {
            Subject = new ClaimsIdentity(
                GetAuthClaims(userName, roles),
                JwtBearerDefaults.AuthenticationScheme),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha512Signature)
        };

        var token = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);

        return jwtSecurityTokenHandler.WriteToken(token);
    }
}