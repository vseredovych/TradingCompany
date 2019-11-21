using AutoMapper;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.DAL.Models.Entities.Implementations;

namespace TradingCompany.BLL.Mapper
{
    public static class ObjectsMapper
    {
        public static IMapper CreateMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, UserViewModel>()
                    .ForMember(x => x.Role,
                               m => m.MapFrom(y => y.Role.Name));
                cfg.CreateMap<UserViewModel, User>();
                cfg.CreateMap<Order, OrderDTO>();


                cfg.CreateMap<UserRegistrationModel, User>();
                cfg.CreateMap<UserRegistrationModel, UserDTO>();
            }).CreateMapper();
        }
    }
}
