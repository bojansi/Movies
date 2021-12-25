using BusinessLogicLayer;
using DataAccessLayer.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class Users : Form
    {
        private readonly UserBusiness userBusiness;
        public Users()
        {
            this.userBusiness = new UserBusiness();
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if(textBoxId != null && textBoxName != null && textBoxSurname != null && textBoxEmail != null && textBoxUserName !=null && textBoxPassword != null)
            {
                User u = new User();
                {
                    u.Name = textBoxName.Text;
                    u.Surname = textBoxSurname.Text;
                    u.Email = textBoxEmail.Text;
                    u.UserName = textBoxUserName.Text;
                    u.Password = textBoxPassword.Text;

                };
                if (this.userBusiness.InsertUser(u) == true)
                {
                    MessageBox.Show("Uspesno unet korisnik!");
                    List<User> list = this.userBusiness.GetAllUsers();
                    dataGridViewUser.DataSource = list;
                    ClearTextBox()
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {
            List<User> list = this.userBusiness.GetAllUsers();
            dataGridViewUser.DataSource = list;
        }

        public void ClearTextBox()
        {
            textBoxId.Text = null;
            textBoxName.Text = null;
            textBoxSurname.Text = null;
            textBoxEmail.Text = null;
            textBoxUserName.Text = null;
            textBoxPassword.Text = null;
        }
    }
}
