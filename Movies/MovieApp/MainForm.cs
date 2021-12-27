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
    public partial class MainForm : Form
    {
        private readonly MovieBusiness movieBusiness;
        private readonly UserBusiness userBusiness;
        public MainForm()
        {
            InitializeComponent();
            this.movieBusiness = new MovieBusiness();
            this.userBusiness = new UserBusiness();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Movie> movies = this.movieBusiness.GetAllMovies();

            dataGridViewMovies.DataSource = movies;
            dataGridViewMovies.Columns["Id"].Visible = false;
            dataGridViewMovies.Columns["Name"].Width = 350;
            dataGridViewMovies.Columns["Year"].Width = 70;
            dataGridViewMovies.Columns["Genre"].Width = 130;
            dataGridViewMovies.Columns["Favorite"].Visible = false;
            dataGridViewMovies.Columns["IMDBLink"].Visible = false;
            dataGridViewMovies.Columns["Description"].Visible = false;
            
        }
        private void buttonToUser_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if(login.ShowDialog() == DialogResult.OK)
            {
                Users users = new Users();
                users.Show();
            }
        }

        private void buttonToMovie_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            if(login.ShowDialog() == DialogResult.OK)
            {
                Movies movies = new Movies();
                movies.Show();
            }

        }


    }
}
