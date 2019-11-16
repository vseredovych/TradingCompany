using System;
using System.Windows.Forms;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.FormsUI.Menu;

namespace TradingCompany.FormsUI.Login
{
    public partial class LoginForm : Form
    {
        UsersRepository Users = new UsersRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Button_sing_up_Click(object sender, EventArgs e)
        {

        }

        private void Button_sign_in_Click(object sender, EventArgs e)
        {
            var hash_pwd = PasswordHandler.Hash(textbox_password.Text);
            User user = Users.Get(new UserFilter() { Email = textbox_email.Text });

            MenuForm menu = new MenuForm();
            this.Hide();
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
