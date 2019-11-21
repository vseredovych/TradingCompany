using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCompany.BLL.Models
{
    class OrderViewModel
    {
        public ulong Id { get; set; }

        public string User { get; set; }

        public string Destination { get; set; }

        public DateTime? OrderDate { get; set; }
    }
}
