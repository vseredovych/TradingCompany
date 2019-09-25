using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOut.DAL.Models.Filters.Implementations
{
    class ProductFilter
    {
        public ulong Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public ulong ProducingCountry { get; set; }

        public ulong Price { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0} \nName: {1} \nBrand: {2} \nProducingCOuntry: {3} \nPrice: {4} \n",
                Id, Name, Brand, ProducingCountry, Price);
        }
    }
}
