using SalesOut.DAL.Models;
using SalesOut.DAL.Models.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOut.DAL.Repositories.Abstractions
{
    public interface IFilterable
    {
        ulong? Id { get; set; }
    }
}
