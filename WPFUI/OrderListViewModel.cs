using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstractions;

namespace WPFUI
{
    public class OrderListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;


        public ObservableCollection<OrderViewModel> Orders { get; set; }
        public ObservableCollection<UserViewModel> Users { get; set; }


        private OrderViewModel _selectedOrder;
        private OrderViewModel _selectedUser;

        public OrderViewModel SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        public OrderViewModel SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");
            }
        }

        public OrderListViewModel(IOrderService orderService, IRoleService roleService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
            Update();
        }
        public string User
        {
            get { return _selectedOrder.User; }
            set
            {
                _selectedOrder.User = value;
                OnPropertyChanged("User");
            }
        }
        public string Destination
        {
            get { return _selectedOrder.Destination; }
            set
            {
                _selectedOrder.Destination = value;
                OnPropertyChanged("Destination");
            }
        }
        public string OrderDate
        {
            get { return _selectedOrder.OrderDate.ToString(); }
            set
            {
                _selectedOrder.OrderDate = Convert.ToDateTime(value);
                OnPropertyChanged("OrderDate");
            }
        }

        public string UsersDescription
        {
            get { return _userService.GetByEmail(_selectedUser.User).Email; }
            set
            {
                _selectedUser.User = value;
                OnPropertyChanged("UsersDescription");
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Update()
        {
            Orders = new ObservableCollection<OrderViewModel>(_orderService.GetViewModels());
            Users = new ObservableCollection<UserViewModel>(_userService.GetViewModels());

        }
    }
}
