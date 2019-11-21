using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.UnitOfWork;
using TradingCompany.BLL.Security;
using TradingCompany.DAL.Models.Entities.Implementations;

namespace TradingCompany.BLL.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool CheckCredentials(CredentialsDTO credentials)
        {

            User user = _unitOfWork.UsersRepository.Get(new UserFilter() { Email = credentials.Login });
            if (PasswordHandler.Verify(credentials.Password, user.HashPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UserExist(string email)
        {
            if (_unitOfWork.UsersRepository.Get(new UserFilter() { Email = email }) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
