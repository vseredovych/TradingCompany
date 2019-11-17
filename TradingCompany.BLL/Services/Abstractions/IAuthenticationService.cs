using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface IAuthenticationService
    {
        //
        void CheckCredentials(bool credentials);
        void UserExist(string email);
    }
}
