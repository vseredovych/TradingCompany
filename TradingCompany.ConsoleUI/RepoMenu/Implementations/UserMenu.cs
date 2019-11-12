using System;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.RepoMenu.Implementations
{
    public class UserMenu : BaseMenu<UsersRepository, User, UserFilter>
    {
        protected override User InputValues()
        {
            User user = new User();
            Console.Write("Name: ");
            user.FirstName = Console.ReadLine();
            Console.Write("Surname: ");
            user.LastName = Console.ReadLine();
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
