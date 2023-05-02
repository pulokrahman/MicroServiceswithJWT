using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Authentication.Core.Models;
using Authentication.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;

using Authentication.Core.Contracts.Services;
using Authentication.Core.Contracts.Repositories;

namespace Authentication.Infrastructure.Services
{
    public class AuthenticationServiceAsync:IAuthenticationServiceAsync
    {
        private readonly IAuthenticationRepository authenticationRepository;

        public AuthenticationServiceAsync(IAuthenticationRepository authenticationRepository)
        {
            this.authenticationRepository = authenticationRepository;
        }
        public async Task<IdentityResult> SignUpAsync(SignUpModel model)
        {

            return await authenticationRepository.SignUpAsync(model); 
        }
        public async Task<SignInResult> LoginAsync(LoginModel model)
        {
            return await authenticationRepository.LoginAsync(model);
        }
    }
}
