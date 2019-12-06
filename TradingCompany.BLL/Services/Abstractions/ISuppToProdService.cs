using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.DAL.Models.Entities.Implementations;

namespace TradingCompany.BLL.Services.Abstractions
{
    public interface ISuppToProdService
    {
        IEnumerable<SuppToProdDTO> GetAll();
        IEnumerable<SuppToProdViewModel> GetViewModels();
        SuppToProdDTO GetById(ulong id);
        bool Create(SuppToProdViewModel order);
        bool Update(SuppToProdViewModel order);
        bool Delete(ulong id);
    }
}
