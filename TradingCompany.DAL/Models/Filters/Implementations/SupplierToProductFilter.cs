using TradingCompany.DAL.Models.Filters.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.DAL.Models.Filters.Implementations
{
    public class SupplierToProductFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public ulong? SupplierId { get; set; }
        public ulong? ProductId { get; set; }
        public override string ToString()
        {
            return string.Format("SupplierId: {0} \nProductId: {1} \n",
                SupplierId, ProductId);
        }
    }
}
