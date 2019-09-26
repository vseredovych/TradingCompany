using TradingCompany.DAL.Models.Entities.Abstractions;

namespace TradingCompany.DAL.Models.Entities.Implementations
{
    public class Role : IBaseEntity
    {
        public ulong Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return string.Format("Id: {0} \nName: {1} \n",
                Id, Name);
        }
    }
}
