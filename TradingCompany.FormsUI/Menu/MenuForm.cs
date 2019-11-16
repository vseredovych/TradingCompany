using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.BLL.Services;
using TradingCompany.BLL.DTO;


namespace TradingCompany.FormsUI.Menu
{
    public partial class MenuForm : Form
    {
        private UserService UserService = new UserService();
        public MenuForm()
        {
            InitializeComponent();
            StartUp();
        }
        public void StartUp()
        {
            var users = UserService.GetAllUser();
            userViewModelBindingSource.DataSource = users;
        }

        private void Datagrid_tables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var ind = e.RowIndex;

        }

    }
}
