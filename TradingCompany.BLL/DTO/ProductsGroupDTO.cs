using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.BLL.DTO
{
    class ProductsGroupDTO
    {
        // Order Id
        public ulong Id { get; set; }
        public virtual ICollection<int> Quantity { get; set; }
        public virtual ICollection<ProductDTO> Categories { get; set; }
    }
}
