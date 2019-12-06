using TradingCompany.DAL.Models.Entities.Abstractions;

namespace TradingCompany.DAL.Models.Entities.Implementations
{
    public class SuppToProdDTO
    {
        public ulong Id { get; set; }
        public Supplier Supplier { get; set; }
        public Product Product { get; set; }
    }
}
