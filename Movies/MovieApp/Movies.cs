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
    public partial class Movies : Form
    {
        private readonly MovieBusiness movieBusiness;
        public Movies()
        {
            InitializeComponent();
            this.movieBusiness = new MovieBusiness();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != "" && textBoxYear.Text != "" && textBoxGenre.Text !="" && textBoxIMDB.Text !="" && richTextBoxDescription.Text != "")
            {
                Movie movie = new Movie()
                {
                    Name = textBoxName.Text,
                    Year = Convert.ToInt32(textBoxYear.Text),
                    Genre = textBoxGenre.Text,
                    IMDBLink = textBoxIMDB.Text,
                    Description = richTextBoxDescription.Text
                };
                if (this.movieBusiness.InsertMovie(movie) == true)
                {
                    MessageBox.Show("Uspesno dodat film!");
                    List<Movie> movies = this.movieBusiness.GetAllMovies();
                    dataGridViewMovies.DataSource = movies;
                }
                else
                {
                    MessageBox.Show("Greska prilikom dodavanja filma");
                }

            }
        }

        public void ClearFields()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxYear.Text = "";
            textBoxGenre.Text = "";
            checkBoxFavorite.Checked = false;
            textBoxIMDB.Text = "";
            richTextBoxDescription.Text = "";

        }

        private void buttonUpdateMovie_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text != "" && textBoxName.Text != "" && textBoxYear.Text != "" && textBoxGenre.Text != "" && textBoxIMDB.Text !="" && richTextBoxDescription.Text != "")
            {
                Movie movie = new Movie()
                {
                    Id = Convert.ToInt32(textBoxId.Text),
                    Name = textBoxName.Text,
                    Year = Convert.ToInt32(textBoxYear.Text),
                    Genre = textBoxGenre.Text,
                    Favorite = checkBoxFavorite.Checked,
                    IMDBLink = textBoxIMDB.Text,
                    Description = richTextBoxDescription.Text
                };
                if (this.movieBusiness.UpdateMovie(movie) == true)
                {
                    MessageBox.Show("Uspesno izmenjen film");
                    List<Movie> movies = this.movieBusiness.GetAllMovies();
                    dataGridViewMovies.DataSource = movies;
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Greska prilikom izmene");
                }
            }
        }

        private void buttonDeleteMovie_Click(object sender, EventArgs e)
        {
            if(textBoxId.Text != "")
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if(this.movieBusiness.DeleteMovie(id) == true)
                {
                    MessageBox.Show("Uspesno obrisan film");
                    List<Movie> movies = this.movieBusiness.GetAllMovies();
                    dataGridViewMovies.DataSource = movies;
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Greska!");
                }
            }
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            List<Movie> movies = this.movieBusiness.GetAllMovies();
            dataGridViewMovies.DataSource = movies;

        }

        private void dataGridViewMovies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridViewMovies.SelectedRows[0].Cells["Id"].Value.ToString();
            textBoxName.Text = dataGridViewMovies.SelectedRows[0].Cells["Name"].Value.ToString();
            textBoxYear.Text = dataGridViewMovies.SelectedRows[0].Cells["Year"].Value.ToString();
            textBoxGenre.Text = dataGridViewMovies.SelectedRows[0].Cells["Genre"].Value.ToString();
            richTextBoxDescription.Text = dataGridViewMovies.SelectedRows[0].Cells["Description"].Value.ToString();
            textBoxIMDB.Text = dataGridViewMovies.SelectedRows[0].Cells["IMDBLink"].Value.ToString();
            String cb = dataGridViewMovies.SelectedRows[0].Cells["Favorite"].Value.ToString().ToLower();
            if(cb == "true")
            {
                checkBoxFavorite.Checked = true;
            }
            else
            {
                checkBoxFavorite.Checked = false;
            }
        }
    }
}
