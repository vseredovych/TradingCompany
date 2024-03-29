﻿using TradingCompany.DAL.Models.Filters.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.DAL.Models.Filters.Implementations
{
    public class SupplierFilter : IFilterable
    {
        public ulong? Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("Id: {0} \nName: {1} \n",
                Id, Name);
        }
    }
}
