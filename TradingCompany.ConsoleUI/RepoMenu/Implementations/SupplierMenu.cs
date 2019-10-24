using System;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.RepoMenu.Implementations
{
    class SupplierMenu : BaseMenu<SuppliersRepository, Supplier, SupplierFilter>
    {
        protected override Supplier InputValues()
        {
            Supplier supplier = new Supplier();
            Console.Write("Name: ");
            supplier.Name = Console.ReadLine().ToString();
            return supplier;
        }
    }
}