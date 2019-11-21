using TradingCompany.BLL.DTO;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using System.Collections.Generic;
using AutoMapper;
using TradingCompany.BLL.Mapper;
using System.Linq;
using TradingCompany.BLL.Models;
using TradingCompany.DAL.UnitOfWork;
using TradingCompany.BLL.Services.Abstractions;

namespace TradingCompany.BLL.Services.Implementations
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoleService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<UserViewModel> GetAllRoles()
        {
            //UserDTO userDTO = new UserDTO();
            List<UserViewModel> usersView = new List<UserViewModel>();
            //List<UserDTO> usersDTO = new List<UserDTO>();
            //List<User> users = Users.GetAll().ToList();

            //foreach ( User user in users)
            //{
            //    UserDTO userDTO = mapper.Map<User, UserDTO>(user);
            //    userDTO.Role = Roles.Get(new RoleFilter() { Id = user.RoleId }) ;
            //    usersDTO.Add(userDTO);
            //    usersView.Add(mapper.Map<UserDTO, UserViewModel>(userDTO));
            //}

            return usersView;
        }
        public void CreateRole(UserRegistrationModel model)
        {
            //if (Users.Get(new UserFilter() { Email = model.Email }) != null)
            //{
            //    UserDTO user = mapper.Map<UserRegistrationModel, UserDTO>(model);
                
            //}

        }
        public IEnumerable<string> GetRoleNames()
        {
            List<string> roleNames = new List<string>();
            var roles = _unitOfWork.RolesRepository.GetAll();
            foreach ( Role role in roles)
            {
                roleNames.Add(role.Name);
            }
            return roleNames;
        }
    }
}
