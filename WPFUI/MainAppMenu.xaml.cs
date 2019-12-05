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
using TradingCompany.BLL;

namespace WPFUI
{
    /// <summary>
    /// Логика взаимодействия для MainAppMenu.xaml
    /// </summary>
    public partial class MainAppMenu : Window
    {
        public MainAppMenu()
        {
            InitializeComponent();
        }

        private void BtnOrders_Click(object sender, RoutedEventArgs e)
        {
            OrdersMenu ordersMenu = DependencyInjectorBLL.Resolve<OrdersMenu>();
            ordersMenu.Show();
        }
    }
}
