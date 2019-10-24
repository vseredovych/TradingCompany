using System;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.RepoMenu.Implementations
{
    class OrderMenu : BaseMenu<OrdersRepository, Order, OrderFilter>
    {
        protected override Order InputValues()
        {
            Order order = new Order();
            Console.Write("Destination: ");
            order.UserId = Convert.ToUInt64(Console.ReadLine().ToString());
            Console.Write("OrderDate: ");
            order.OrderDate = Convert.ToDateTime(Console.ReadLine().ToString());

            return order;
        }
    }
}