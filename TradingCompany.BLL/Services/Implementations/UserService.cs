using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Security;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.UnitOfWork;

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
        public IEnumerable<UserViewModel> GetViewModels()
        {
            IEnumerable<UserDTO> usersDTO = this.GetAll();
            var usersView = usersDTO.ToList().ConvertAll(x => _mapper.Map<UserDTO, UserViewModel>(x));
            return usersView;
        }
        public IEnumerable<UserDTO> GetAll()
        {
            List<UserDTO> usersDTO = new List<UserDTO>();
            foreach(var user in _unitOfWork.UsersRepository.GetAll())
            {
                UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
                userDTO.Role = _unitOfWork.RolesRepository.Get(new RoleFilter() { Id = user.RoleId });
                usersDTO.Add(userDTO);
            }
            return usersDTO;
        }
        public UserDTO GetById(ulong id)
        {
            User user = _unitOfWork.UsersRepository.Get(new UserFilter() { Id = id });
            UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
            return userDTO;
        }
        public UserDTO GetByEmail(string email)
        {
            User user = _unitOfWork.UsersRepository.Get(new UserFilter() { Email = email });
            UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
            return userDTO;
        }
        public bool CreateUser(UserViewModel model)
        {
            try
            {
                User user = _mapper.Map<UserViewModel, User>(model);
                user.RoleId = _unitOfWork.RolesRepository.Get(new RoleFilter() { Name = model.Role }).Id;
                _unitOfWork.UsersRepository.Create(user);
            }
            catch
            {
                return false;
            }
            return true;
        }
        public bool UpdateUser(UserViewModel model)
        {
            try
            {

                User user = _mapper.Map<UserViewModel, User>(model);
                user.RoleId = _unitOfWork.RolesRepository.Get(new RoleFilter() { Name = model.Role }).Id;
                _unitOfWork.UsersRepository.Update(user, new UserFilter() { Id = user.Id});
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public string GetHashedPassword(string password)
        {
            return PasswordHandler.Hash(password);
        }

        public bool IsEmailExists(string email)
        {
            if (_unitOfWork.UsersRepository.Get(new UserFilter() { Email = email}) != null)
            {
                return false;
            }
            return true;
        }
    }
}
