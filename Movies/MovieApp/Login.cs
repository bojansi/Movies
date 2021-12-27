using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class Login : Form
    {
        private readonly UserBusiness userBusiness;
        public Login()
        {
            InitializeComponent();
            this.userBusiness = new UserBusiness();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUserName.Text !="" && textBoxPassword.Text != "")
            {
                String userName = textBoxUserName.Text;
                String password = textBoxPassword.Text;
                if (this.userBusiness.GetUserForLogin(userName, password))
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Pogresno korisnicko ime ili lozinka");
                }
            }
        }
    }
}
