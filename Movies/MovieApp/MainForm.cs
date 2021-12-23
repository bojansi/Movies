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

            foreach (Movie m in movies)
            {
                listBoxMovies.Items.Add(m.Id + ". " + m.Name + " " + m.Year + " " + m.Genre + " " + m.Favorite + " " + m.IMDBLink + " " + m.Description);
            }
        }

    }
}
