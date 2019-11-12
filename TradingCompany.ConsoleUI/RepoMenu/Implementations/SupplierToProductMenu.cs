using System;
using TradingCompany.ConsoleUI.RepoMenu;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI.RepoMenu.Implementations
{
    public class SupplierToProductMenu : BaseMenu<SuppToProdRepository, SupplierToProduct, SupplierToProductFilter>
    {
        protected override SupplierToProduct InputValues()
        {
            SupplierToProduct supplierToProduct = new SupplierToProduct();
            Console.Write("ProductId: ");
            supplierToProduct.ProductId = Convert.ToUInt64(Console.ReadLine());
            Console.Write("SupplierId: ");
            supplierToProduct.SupplierId = Convert.ToUInt64(Console.ReadLine());
            return supplierToProduct;
        }
    }
}
