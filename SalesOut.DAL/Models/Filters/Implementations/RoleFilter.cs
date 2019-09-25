using SalesOut.DAL.Models.Entities.Abstractions;

namespace SalesOut.DAL.Models.Filters.Implementations
{
    public class RoleIdFilter
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
