using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstractions;

namespace WPFUI
{
        public class OrdersListViewModel : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            private readonly IUserService _userService;
            private readonly IRoleService _roleService;

            public ObservableCollection<UserDTO> Users { get; set; }
            public ObservableCollection<RoleDTO> Roles { get; set; }
            private UserDTO _selectedUser;
            private RoleDTO _selectedRole;

            public RoleDTO SelectedRole
            {
                get { return _selectedRole; }
                set
                {
                    _selectedRole = value;
                    OnPropertyChanged("SelectedRole");
                }
            }

            //public UserDTO SelectedUser
            //{
            //    get { return _selectedUser; }
            //    set
            //    {
            //        _selectedUser = value;
            //        _selectedRole  = _roleService.GetById(_selectedUser.RoleId);
            //        OnPropertyChanged("SelectedUser");
            //    }
            //}

            public OrdersListViewModel(IUserService userService, IRoleService roleService)
            {
                _userService = userService;
                _roleService = roleService;
                Update();
            }

            public string FirstName
            {
                get { return _selectedUser.FirstName; }
                set
                {
                    _selectedUser.FirstName = value;
                    OnPropertyChanged("FirstName");
                }
            }
            public string LastName
            {
                get { return _selectedUser.LastName; }
                set
                {
                    _selectedUser.LastName = value;
                    OnPropertyChanged("LastName");
                }
            }
            public string Email
            {
                get { return _selectedUser.Email; }
                set
                {
                    _selectedUser.Email = value;
                    OnPropertyChanged("Email");
                }
            }

            //public string Login
            //{
            //    get { return _selectedUser.Login; }
            //    set
            //    {
            //        _selectedUser.Login = value;
            //        OnPropertyChanged("Login");
            //    }
            //}

            //public string RoleDescription
            //{
            //    get { return _roleService.GetById(_selectedUser.RoleId).RoleDescription; }
            //    set
            //    {
            //        _selectedRole.RoleDescription = value;
            //        OnPropertyChanged("RoleDescription");
            //    }
            //}

            public void OnPropertyChanged([CallerMemberName]string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }

        public void Update()
        {
            Users = new ObservableCollection<UserDTO>(_userService.GetAll());
            //Roles = new ObservableCollection<RoleDTO>(_roleService.GetAll());

        }
    }
}
