using TradingCompany.DAL.Models.Entities.Abstractions;
using TradingCompany.DAL.Models.Entities.Implementations;

namespace TradingCompany.BLL.Models
{
    public class SuppToProdViewModel
    {
        public ulong Id { get; set; }
        public string Supplier { get; set; }
        public string Product { get; set; }
    }
}
