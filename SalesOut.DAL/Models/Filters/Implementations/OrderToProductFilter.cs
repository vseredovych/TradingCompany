using SalesOut.DAL.Models.Filters.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOut.DAL.Models.Filters.Implementations
{
    public class OrderToProductFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public ulong? ProductId { get; set; }

        public ulong? OrderId { get; set; }

        public ulong? Quantity { get; set; }

        public override string ToString()
        {
            return string.Format("ProductId: {0} \nOrderId: {1} \nQuantity: {2} \n",
                ProductId, OrderId, Quantity);
        }
    }
}
