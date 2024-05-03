using ApplicationCore.Model.Request;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryContracts
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpRequestModel model);

        Task<SignInResult> LoginAsync(LoginRequestModel mdoel);
    }


}
