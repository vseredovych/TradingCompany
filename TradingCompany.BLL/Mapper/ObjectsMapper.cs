using AutoMapper;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;

namespace TradingCompany.BLL.Mapper
{
    public sealed class ObjectsMapper
    {

        private volatile IMapper mapper = null;
        private MapperConfiguration config = null;
        public ObjectsMapper()
        {
            config = ConfigMapper();
            mapper = config.CreateMapper();
        }
        public IMapper Get()
        {
            return mapper;
        }
        public MapperConfiguration ConfigMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();

                cfg.CreateMap<UserDTO, UserViewModel>()
                    .ForMember(x => x.Role,
                               m => m.MapFrom(y => y.Role.Name))
 ;
            });
            return config;
        }
    }
}
