using ApplicationCore.Model.Request;
using ApplicationCore.RepositoryContracts;
using ApplicationCore.ServiceContracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;

// System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace Infrastructure.Service
{
    
    public class AccountServiceAsync: IAccountServiceAsync
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IConfiguration _configuration;
        public AccountServiceAsync(IAccountRepository accountRepository, IConfiguration configuration) {
            _accountRepository = accountRepository;
            _configuration = configuration;
        }

        public async Task<IdentityResult> SignUpAsync(SignUpRequestModel model) {
            return await _accountRepository.SignUpAsync(model);
        }

        public async Task<string> LoginAsync(LoginRequestModel model) {
            var loginResult = await _accountRepository.LoginAsync(model);
            if (loginResult.Succeeded) {
                var authClaim = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,model.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    
                };

                var authSignKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(1),
                    claims: authClaim,
                    signingCredentials: new SigningCredentials(authSignKey, SecurityAlgorithms.HmacSha256Signature)
                    );

                var handler = new JwtSecurityTokenHandler().WriteToken(token);
                return handler;
            }
            return null;
        }
    }
}
