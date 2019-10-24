using System;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.RepoMenu.Implementations
{
    class RoleMenu : BaseMenu<RolesRepository, Role, RoleFilter>
    {
        protected override Role InputValues()
        {
            Role role = new Role();
            Console.Write("Name: ");
            role.Name = Console.ReadLine().ToString();
            return role;
        }
    }
}