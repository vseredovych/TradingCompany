using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface IUserService
    {
        IEnumerable<UserDTO> GetAll();
        UserDTO GetById(ulong id);
        UserDTO GetByEmail(string email);
        IEnumerable<UserViewModel> GetViewModels();
        bool IsEmailExists(string email);
        string GetHashedPassword(string password);
        bool CreateUser(UserViewModel model);
        bool UpdateUser(UserViewModel model);
    }
}
