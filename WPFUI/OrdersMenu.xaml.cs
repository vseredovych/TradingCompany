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
using TradingCompany.BLL.Services.Abstractions;

namespace WPFUI
{
    /// <summary>
    /// Логика взаимодействия для OrdersMenu.xaml
    /// </summary>
    /// 
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

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(users_dtgrd.ItemsSource);
            //view.Filter = UserFilter;
        }
        private void users_dtgrd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            role_cmbbx.Text = _viewModel.SelectedOrder.Id.ToString();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (users_dtgrd.SelectedItems.Count > 0)
            //{
            //    UserDTO user = new UserDTO();
            //    var dialog = MessageBox.Show("Are you sure?", "Update", MessageBoxButton.YesNo);

            //    if (dialog == MessageBoxResult.Yes)
            //    {
            //        user = _viewModel.SelectedUser;
            //        user.FirstName = fname_txtbx.Text;
            //        user.LastName = lname_txtbx.Text;
            //        user.Role = _viewModel.SelectedRole.RoleId;
            //        _userService.Update(user);
            //    }
            //    users_dtgrd.Items.Refresh();
            //}
            //else
            //{
            //    MessageBox.Show("Choose user");
            //}
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            //if (users_dtgrd.SelectedItems.Count > 0)
            //{
            //    var user = _viewModel.SelectedUser;
            //    var dialog = MessageBox.Show("Are you sure?", "Delete", MessageBoxButton.YesNo);

            //    if (dialog == MessageBoxResult.Yes)
            //    {
            //        _userService.Remove(user);
            //    }
            //    _viewModel.Users.Remove(user);
            //    users_dtgrd.Items.Refresh();
            //}
            //else
            //{
            //    MessageBox.Show("Choose user");
            //}
        }


        private void filter_txtbx_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(users_dtgrd.ItemsSource).Refresh();
        }

        private void save_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
