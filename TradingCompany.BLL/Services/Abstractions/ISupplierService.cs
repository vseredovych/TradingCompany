using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface ISupplierService
    {
        IEnumerable<SupplierDTO> GetAll();
        SupplierDTO GetById(ulong id);
        bool Create(SupplierDTO model);
        bool Update(SupplierDTO model);
        bool Delete(ulong id);
        IEnumerable<string> GetSupplierByProduct(string product);
    }
}
