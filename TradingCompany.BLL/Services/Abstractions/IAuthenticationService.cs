﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface IAuthenticationService
    {
        //
        bool CheckCredentials(CredentialsDTO credentials);
        bool UserExist(string email);
    }
}
