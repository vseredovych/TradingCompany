using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;

namespace TradingCompany.DAL.Models
{
    class MapperConfig
    {
        public MapperConfig()
        {

        }
        public IMapper GetMapper()
        {
            //var config = new MapperConfiguration(cfg => {
            //    cfg.CreateMap<User, UserFilter>()
            //    .ForMember("Name", opt => opt.MapFrom(c => c.FirstName + " " + c.LastName))
            //    .ForMember("Email", opt => opt.MapFrom(src => src.Login));
            //});
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<User, UserFilter>();
            });
            return config.CreateMapper();
        }
    }
}
