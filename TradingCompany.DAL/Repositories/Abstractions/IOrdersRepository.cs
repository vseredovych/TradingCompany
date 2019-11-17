using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;

namespace TradingCompany.DAL.Repositories.Abstractions
{
    public interface IOrdersRepository : IRepository<Order, OrderFilter>
    {

    }
}
