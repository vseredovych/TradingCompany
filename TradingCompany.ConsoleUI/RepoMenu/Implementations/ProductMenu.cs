using System;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.RepoMenu.Implementations
{
    class ProductMenu : BaseMenu<ProductsRepository, Product, ProductFilter>
    {
        protected override Product InputValues()
        {
            Product product = new Product();
            Console.Write("Name: ");
            product.Name = Console.ReadLine().ToString();
            Console.Write("Price: ");
            product.Price = Convert.ToInt32(Console.ReadLine().ToString());
            Console.Write("ProducingCountry: ");
            product.ProducingCountry= Console.ReadLine().ToString();
            Console.Write("Brand: ");
            product.Brand = Console.ReadLine().ToString();

            return product;
        }
    }
}
