using ctrlspec.Models;
using ctrlspec.Repos;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ctrlspec.Repos
{
    public class TokenHandler : ITokenHandler
    {
        private readonly IConfiguration configuration;

        public TokenHandler(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        #region CreateTokenAsync
        public Task<string> CreateTokenAsync(Login loginTable)
        {
            try
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));

                //Creating claims
                var claims = new List<Claim>();

                claims.Add(new Claim(ClaimTypes.Email, loginTable.EmailId));

                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"],
                    claims, expires: DateTime.Now.AddMinutes(15), signingCredentials: credentials);

                return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));
            }

            catch (Exception)
            {
                throw;
            }
        }
        #endregion
        // public Task<string> GeneratePasswordTokenAsync(Login users)
        // {
        //     var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:key"]));

        //     //creating claims
        //     var claims = new List<Claim>();
        //     claims.Add(new Claim(ClaimTypes.Email, users.EmailId));

        //     var credentails = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        //     var token = new JwtSecurityToken(configuration["Jwt:Issuer"], configuration["Jwt:Audience"], claims,
        //         expires: DateTime.Now.AddMinutes(5), signingCredentials: credentails);

        //     return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(token));
        // }
    }
}
