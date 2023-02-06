using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Project_Cms_v6.Context;
using Project_Cms_v6.Models;
using Project_Cms_v6.ViewModels;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Project_Cms_v6.Repositories.Data
{
    public class LoginRepository
    {
        public IConfiguration _configuration;
        private readonly AppDbContext appDbContext;
        public LoginRepository(IConfiguration configuration, AppDbContext appDbContext)
        {
            _configuration = configuration;
            this.appDbContext = appDbContext;
        }

        DynamicParameters parameters = new DynamicParameters();
        public UserTokenVM Login(LoginVM loginVM)
        {
            using (SqlConnection connection = new SqlConnection(_configuration["ConnectionStrings:APICms"]))
            {
                var spCheckPassword = "SP_UsersCheckPassword";
                parameters.Add("@Email", loginVM.Email);
                var userPassword = connection.QueryFirstOrDefault<Accounts>(spCheckPassword, parameters, commandType: CommandType.StoredProcedure);
                if (userPassword == null)
                {
                    return null;
                }

                bool verified = BCrypt.Net.BCrypt.Verify(loginVM.Password, userPassword.Password);
                if (!verified)
                {
                    return null;
                }

                parameters = new DynamicParameters();
                var spUserToken = "SP_UsersGetLoginTokenData";
                parameters.Add("@NIK", userPassword.NIK);
                var userToken = connection.QuerySingleOrDefault<UserTokenVM>(spUserToken, parameters, commandType: CommandType.StoredProcedure);
                if (userPassword == null)
                {
                    return null;
                }

                string token = GenerateJwtToken(userToken);
                userToken.Token = token;
                return userToken;
            }
        }

        private string GenerateJwtToken(UserTokenVM userToken)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim("NIK", userToken.NIK),
                new Claim("Email", userToken.Email),
                new Claim("Role", userToken?.RoleName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(7),
                signingCredentials: creds
            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
