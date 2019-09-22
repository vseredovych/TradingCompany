using TransIT.DAL.Models.Entities.Abstractions;

namespace SalesOut.DAL.Models.Entities.Implementations
{
    public class Role : IBaseEntity
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
    }
}
