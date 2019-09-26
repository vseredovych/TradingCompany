using TradingCompany.DAL.Models.Entities.Abstractions;

namespace TradingCompany.DAL.Models.Entities.Implementations
{
    public class SupplierToProduct : IBaseEntity
    {
        public ulong Id { get; set; }
        public ulong SupplierId { get; set; }
        public ulong ProductId { get; set; }
        public override string ToString()
        {
            return string.Format("SupplierId: {0} \nProductId: {1} \n",
                SupplierId, ProductId);
        }
    }
}
