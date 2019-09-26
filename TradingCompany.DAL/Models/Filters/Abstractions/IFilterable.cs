using TradingCompany.DAL.Models;
using TradingCompany.DAL.Models.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.DAL.Models.Filters.Abstractions
{
    public interface IFilterable
    {
        ulong? Id { get; set; }
    }
}
