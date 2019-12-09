using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TradingCompany.BLL.DTO;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstractions;

namespace WPFUI
{
    public partial class CreateOrderWindow : Window
    {
        private readonly IOrderService _orderService;

        private readonly IUserService _userService;

        OrderListViewModel _viewModel;
       
        public CreateOrderWindow(OrderListViewModel viewModel, IOrderService orderService, IUserService userService)
        {
            _viewModel = viewModel;

            _orderService = orderService;
            _userService = userService;
            DataContext = _viewModel;

            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void create_btn_Click(object sender, RoutedEventArgs e)
        {
            if (destination_txtbx.Text.Length == 0 || orderdate_dp.SelectedDate.ToString().Length == 0)
            {
                MessageBox.Show("Fields can not be empty.");
            }
            else
            {
                OrderViewModel order = new OrderViewModel();
                order.Destination = destination_txtbx.Text;
                order.OrderDate = Convert.ToDateTime(orderdate_dp.SelectedDate.ToString());
                order.User = user_cmbbx.Text.ToString();

                try
                {
                    _orderService.Create(order);
                    MessageBox.Show("Successfully created.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}