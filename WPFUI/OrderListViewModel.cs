using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Services.Abstractions;

namespace WPFUI
{
    public class OrderListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly IOrderService _orderService;
        public ObservableCollection<OrderDTO> Orders { get; set; }

        private OrderDTO _selectedOrder;

        public OrderDTO SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged("SelectedOrder");
            }
        }

        public OrderListViewModel(IOrderService OrderService)
        {
            _orderService = OrderService;
            Update();
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
        //public DateTime OrderDate
        //{
        //  get { return _selectedOrder.OrderDate; }
        //    set
        //    {
        //        _selectedOrder.OrderDate = value;
        //        OnPropertyChanged("Email");
         //   }
        //}


        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void Update()
        {
            Orders = new ObservableCollection<OrderDTO>(_orderService.GetAll());
        }
    }
}
