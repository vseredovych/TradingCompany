using TradingCompany.BLL.DTO;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Security;
using TradingCompany.DAL.UnitOfWork;
using TradingCompany.BLL.Services.Abstractions;

namespace TradingCompany.BLL.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        //public UserService() : this(new ObjectsMapper().Get()) {}
        public List<UserViewModel> GetAllUsers()
        {
            //UserDTO userDTO = new UserDTO();
            List<UserViewModel> usersView = new List<UserViewModel>();
            List<UserDTO> usersDTO = new List<UserDTO>();
            List<User> users = _unitOfWork.UsersRepository.GetAll().ToList();

            foreach ( User user in users)
            {
                UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
                userDTO.Role = _unitOfWork.RolesRepository.Get(new RoleFilter() { Id = user.RoleId }) ;
                usersDTO.Add(userDTO);
                usersView.Add(_mapper.Map<UserDTO, UserViewModel>(userDTO));
            }

            return usersView;
        }
        public void CreateUser(UserRegistrationModel model)
        {
            if (_unitOfWork.UsersRepository.Get(new UserFilter() { Email = model.Email }) == null)
            { 
                User user = _mapper.Map<UserRegistrationModel, User>(model);
                user.HashPassword = PasswordHandler.Hash(model.Password);
                user.RoleId = _unitOfWork.RolesRepository.Get(new RoleFilter() { Name = model.Role }).Id;
                _unitOfWork.UsersRepository.Create(user);
            }

        }
    }
}
