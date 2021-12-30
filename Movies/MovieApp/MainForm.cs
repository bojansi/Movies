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
            InitializeComponent();
            this.movieBusiness = new MovieBusiness();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            List<Movie> movies = this.movieBusiness.GetAllMovies();

            dataGridViewMovies.DataSource = movies;
            dataGridViewMovies.Columns["Id"].Visible = false;
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

        private void dataGridViewMovies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Login login = new Login();
            if(login.ShowDialog() == DialogResult.OK)
            { 
                if(dataGridViewMovies.SelectedRows[0] != null)
                {
                    int movieId = Convert.ToInt32(dataGridViewMovies.SelectedRows[0].Cells["Id"].Value);
                    Movie m = this.movieBusiness.GetMoviesById(movieId);
                    MovieView mv = new MovieView(this.movieBusiness, m);
                    mv.Show();
                }
            }
        }

        private void buttonTopRatied_Click(object sender, EventArgs e)
        {
            MovieRate tr = new MovieRate();
            tr.Show();
        }
    }
}
