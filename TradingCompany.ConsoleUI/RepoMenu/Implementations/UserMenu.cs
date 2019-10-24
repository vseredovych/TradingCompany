using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.Implementations.RepoMenu
{
    public class UserMenu : BaseMenu<UsersRepository, User, UserFilter>
    {
        protected override User InputValues()
        {
            User user = new User()
            user.FirstName = Console.ReadLine().ToString();
            user.LastName = Console.ReadLine().ToString();
            user.Email = Console.ReadLine().ToString();
            user.RoleId = Convert.ToUInt64(Console.Read());
            user.HashPassword = Console.ReadLine().ToString();

        }
        protected override void OutputValues()
        {
        }
    }
}
