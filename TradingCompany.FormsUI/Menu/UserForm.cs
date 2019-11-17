using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingCompany.BLL.DTO;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.BLL.Models;

namespace TradingCompany.FormsUI.Menu
{
    public partial class UserForm : Form
    {
        private UserViewModel model;
        public UserForm(UserViewModel model)
        {
            InitializeComponent();
            this.model = model;
            SetUpForm();
        }
        private void SetUpForm()
        {
            textbox_name.Text = model.FirstName;
            textbox_surname.Text = model.LastName;
            textbox_email.Text = model.Email;
            textbox_password.Text = model.HashPassword;
        }
        private void Button_apply_Click(object sender, EventArgs e)
        {

        }

        private void Button_ok_Click(object sender, EventArgs e)
        {

        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
