using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.DAL.UnitOfWork;

namespace TradingCompany.BLL.Services.Implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AuthenticationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CheckCredentials(bool credentials)
        {

        }
        public void UserExist(string email)
        {

        }
        //public Task<bool> CheckCredentials(CredentialsDTO credentials)
        //{
        //    return ( _unitOfWork.UsersRepository
        //        .GetAsync(u => u.Login == credentials.Email))
        //        .Any(u => u.PasswordHash == Hash(credentials.Password));
        //}

        //public Task<bool> UserExist(string email)
        //{
        //    return (_unitOfWork.UsersRepository
        //        .GetAsync(u => u.Email == email))
        //        .Any();
        //}
    }
}
