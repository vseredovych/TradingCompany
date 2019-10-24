using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.ConsoleUI.Abstractions.RepoMenu;
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
            User user = new User();
            Console.Write("Name: ");
            user.FirstName = Console.ReadLine().ToString();
            Console.Write("Surname: ");
            user.LastName = Console.ReadLine().ToString();
            Console.Write("Email: ");
            user.Email = Console.ReadLine().ToString();
            Console.Write("RoleID: ");
            user.RoleId = Convert.ToUInt64(Console.ReadLine());
            Console.Write("HashPassword: ");
            user.HashPassword = Console.ReadLine().ToString();
            return user;
        }
    }
}
