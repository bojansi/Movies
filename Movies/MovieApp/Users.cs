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

        //add user 
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
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text != "" && textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxEmail.Text != "" && textBoxUserName.Text != "" && textBoxPassword.Text != "")
            {
                User u = new User()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Email = textBoxEmail.Text,
                    UserName = textBoxUserName.Text,
                    Password = textBoxPassword.Text
                };
                if(this.userBusiness.UpdateUser(u) == true)
                {
                    MessageBox.Show("Uspesno ste izmenili korisnika!");
                    List<User> users = this.userBusiness.GetAllUsers();
                    dataGridViewUser.DataSource = users;
                    ClearTextBox();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }

        //delete user
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if(textBoxIdDelete.Text != "")
            {
                int id = Convert.ToInt32(textBoxIdDelete.Text);
                if(this.userBusiness.DeleteUser(id) == true)
                {
                    MessageBox.Show("Uspesno ste izbrisali korisnika!");
                    List<User> list = this.userBusiness.GetAllUsers();
                    dataGridViewUser.DataSource = list;
                    ClearTextBox();
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
            textBoxIdDelete.Text = null;
        }


    }
}
