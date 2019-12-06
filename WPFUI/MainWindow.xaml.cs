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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradingCompany.BLL;
using TradingCompany.BLL.Services.Abstractions;

namespace WPFUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            MainAppMenu mainAppMenu = DependencyInjectorBLL.Resolve<MainAppMenu>();
            mainAppMenu.Show();
            this.Close();
        }
    }
}