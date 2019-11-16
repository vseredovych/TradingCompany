using TradingCompany.BLL.DTO;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using System.Collections.Generic;
using AutoMapper;
using TradingCompany.BLL.Mapper;
using System.Linq;
using TradingCompany.BLL.Models;

namespace TradingCompany.BLL.Services
{
    public class UserService
    {
        private UsersRepository Users = new UsersRepository();
        private RolesRepository Roles = new RolesRepository();
        private IMapper mapper;

        public UserService(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public UserService() : this(new ObjectsMapper().Get()) {}
        public List<UserViewModel> GetAllUser()
        {
            //UserDTO userDTO = new UserDTO();
            List<UserViewModel> usersView = new List<UserViewModel>();
            List<UserDTO> usersDTO = new List<UserDTO>();
            List<User> users = Users.GetAll().ToList();

            foreach ( User user in users)
            {
                UserDTO userDTO = mapper.Map<User, UserDTO>(user);
                userDTO.Role = Roles.Get(new RoleFilter() { Id = user.RoleId }) ;
                usersDTO.Add(userDTO);
                usersView.Add(mapper.Map<UserDTO, UserViewModel>(userDTO));
            }

            return usersView;
        }
    }
}
