using SalesOut.DAL.Models.Entities.Abstractions;

namespace SalesOut.DAL.Models.Entities.Implementations
{
    public class OrderToProduct : IBaseEntity
    {
        public ulong Id { get; set; }
        public ulong ProductId { get; set; }

        public ulong OrderId { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return string.Format("ProductId: {0} \nOrderId: {1} \nQuantity: {2} \n",
                ProductId, OrderId, Quantity);
        }
    }
}
