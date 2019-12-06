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
        bool Create(UserViewModel model);
        bool Update(UserViewModel model);
        bool Delete(ulong id);
        IEnumerable<UserViewModel> GetViewModels();
        bool IsEmailExists(string email);
        string GetHashedPassword(string password);
        IEnumerable<string> GetUserNames();
    }
}
