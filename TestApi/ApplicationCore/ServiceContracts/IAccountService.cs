﻿using ApplicationCore.Model.Request;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceContracts
{
    public interface IAccountServiceAsync
    {
        Task<IdentityResult> SignUpAsync(SignUpRequestModel model);

        Task<string> LoginAsync(LoginRequestModel model);
    }
}
