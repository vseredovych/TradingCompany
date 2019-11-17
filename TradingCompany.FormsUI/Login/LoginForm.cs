using System;
using System.Windows.Forms;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.FormsUI.Menu;
using TradingCompany.BLL.Security;
using TradingCompany.BLL.Services.Abstractions;
using TradingCompany.BLL;

namespace TradingCompany.FormsUI.Login
{
    public partial class LoginForm : Form
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IUserService _userService;
        public LoginForm( IAuthenticationService authenticationService, IUserService userService)
        {
            _authenticationService = authenticationService;
            _userService = userService;

            InitializeComponent();
        }


        private void Button_sing_up_Click(object sender, EventArgs e)
        {
            //this.Hide();
            RegistrationForm registration = new RegistrationForm(
                DependencyInjectorBLL.Resolve<IAuthenticationService>(), 
                DependencyInjectorBLL.Resolve<IUserService>(),
                DependencyInjectorBLL.Resolve<IRoleService>());
            registration.Show();
        }

        private void Button_sign_in_Click(object sender, EventArgs e)
        {
            //TODO now
            //var hash_pwd = PasswordHandler.Hash(textbox_password.Text);
            //User user = Users.Get(new UserFilter() { Email = textbox_email.Text });

            MenuForm menu = new MenuForm(
                DependencyInjectorBLL.Resolve<IAuthenticationService>(), 
                DependencyInjectorBLL.Resolve<IUserService>()
                );
            //this.Hide();
            menu.Show();


            //if (user != null && PasswordHandler.Verify(textbox_password.Text, user.HashPassword))
            //{
            //    MenuForm menu = new MenuForm();
            //    this.Hide();
            //    menu.Show();
            //}
            ////button_sign_in.Text
            //textbox_email.Text = "email";
        }
    }
}
