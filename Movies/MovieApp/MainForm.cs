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
        public MainForm()
        {
            this.movieBusiness = new MovieBusiness();
            InitializeComponent();
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

       /* private void dataGridViewMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Rating rating = new Rating();
            //rating.Show();
        }*/
    }
}
