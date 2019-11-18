using System;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.RepoMenu.Implementations
{
    class OrderToProductMenu : BaseMenu<OrdersToProductsRepository, OrderToProduct, OrderToProductFilter>
    {
        protected override OrderToProduct InputValues()
        {
            OrderToProduct orderToProduct = new OrderToProduct();
            Console.Write("OrderId: ");
            orderToProduct.OrderId = Convert.ToUInt64(Console.ReadLine().ToString());
            Console.Write("ProductId: ");
            orderToProduct.ProductId = Convert.ToUInt64(Console.ReadLine().ToString());
            Console.Write("Quantity: ");
            orderToProduct.Quantity = Convert.ToInt32(Console.ReadLine().ToString());

            return orderToProduct;
        }
    }
}