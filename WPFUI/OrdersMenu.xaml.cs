using System;
using System.Collections.Generic;
using System.Globalization;
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
using TradingCompany.BLL;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstractions;

namespace WPFUI
{
    /// <summary>
    /// Логика взаимодействия для OrdersMenu.xaml
    /// </summary>
    public partial class OrdersMenu : Window
    {
        OrderListViewModel _viewModel;
        private readonly IOrderService _orderService;
        public OrdersMenu(OrderListViewModel viewModel, IOrderService orderService)
        {
            _viewModel = viewModel;
            _orderService = orderService;
            DataContext = _viewModel;

            InitializeComponent();
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(orders_dtgrd.ItemsSource);
            view.Filter = OrderFilter;
        }

        private bool OrderFilter(object obj)
        {
            if (String.IsNullOrEmpty(filter_txtbx.Text))
                return true;
            else
                return ((obj as OrderViewModel).User.IndexOf(filter_txtbx.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void orders_dtgrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            user_cmbbx.Text = _viewModel.SelectedOrder.User;
        }

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {
            if (orders_dtgrd.SelectedItems.Count > 0)
            {
                OrderViewModel order = new OrderViewModel();
                var dialog = MessageBox.Show("Are you sure?", "Update", MessageBoxButton.YesNo);

                if (dialog == MessageBoxResult.Yes)
                {
                    order = _viewModel.SelectedOrder;
                    order.Destination = destination_txtbx.Text;
                    order.OrderDate = _viewModel.SelectedOrder.OrderDate;

                    order.User = _viewModel.SelectedUser.Email;
                    _orderService.Update(order);
                }
                orders_dtgrd.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Choose order");
            }
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            if (orders_dtgrd.SelectedItems.Count > 0)
            {
                var order = _viewModel.SelectedOrder;
                var dialog = MessageBox.Show("Are you sure?", "Delete", MessageBoxButton.YesNo);

                if (dialog == MessageBoxResult.Yes)
                {
                    _orderService.Delete(order.Id);
                }
                try
                {
                    _viewModel.Orders.Remove(order);
                    orders_dtgrd.Items.Refresh();
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Choose order");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void filter_txtbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(orders_dtgrd.ItemsSource).Refresh();
        }

        private void Create_btn_Click(object sender, RoutedEventArgs e)
        {
            CreateOrderWindow createWindow = DependencyInjectorBLL.Resolve<CreateOrderWindow>();
            createWindow.Show();
        }
    }
}