using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOut.DAL.Models.Entities.Abstractions;

namespace SalesOut.DAL.Models.Entities.Implementations
{
    public class Order : IBaseEntity
    {
        public ulong Id { get; set; }

        public ulong UserId { get; set; }

        public string Destination { get; set; }

        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} \nUserId: {1} \nDestination: {2} \nOrderDate: {3}\n",
                Id, UserId, Destination, OrderDate);
        }
    }
}
