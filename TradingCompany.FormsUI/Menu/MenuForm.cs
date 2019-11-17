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
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.BLL.Models;
using TradingCompany.BLL.Services.Abstractions;

namespace TradingCompany.FormsUI.Menu
{
    public partial class MenuForm : Form
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        public MenuForm(IAuthenticationService authService, IUserService userService)
        {
            _authenticationService = authService;
            _userService = userService;
            InitializeComponent();
            StartUp();
        }
        public void StartUp()
        {
            var users = _userService.GetAllUsers();
            userViewModelBindingSource.DataSource = users;
        }

        private void Datagrid_tables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var ind = e.RowIndex;
            List<UserViewModel> users = new List<UserViewModel>();
            users = (List<UserViewModel>)userViewModelBindingSource.DataSource;
            UserForm userForm = new UserForm(users[e.RowIndex]);
            userForm.Show();
            //List<User> user = (User)datagrid_tables.DataSource;
        }

    }
}
