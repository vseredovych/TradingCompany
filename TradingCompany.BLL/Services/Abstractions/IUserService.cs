using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.Models;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface IUserService
    {
        List<UserViewModel> GetAllUsers();
        void CreateUser(UserRegistrationModel model);
    }
}
