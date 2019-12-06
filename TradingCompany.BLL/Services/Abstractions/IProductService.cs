using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface IProductService
    {
        IEnumerable<ProductDTO> GetAll();
        ProductDTO GetById(ulong id);
        bool Create(ProductDTO product);
        bool Update(ProductDTO model);
        bool Delete(ulong id);
        IEnumerable<string> GetProducts();
    }
}
