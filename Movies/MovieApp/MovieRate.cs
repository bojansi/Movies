using BusinessLogicLayer;
using DataAccessLayer.Modals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class MovieRate : Form 
    {
        private readonly GradingBusiness gradingBusiness;
        private readonly MovieBusiness movieBusiness;
       
        public MovieRate()
        {
            InitializeComponent();
            this.gradingBusiness = new GradingBusiness();
            this.movieBusiness = new MovieBusiness();

        }

        private void TopRatied_Load(object sender, EventArgs e)
        {
            List<Movie> listOfMovies = this.movieBusiness.GetAllMovies();
            Grading g = new Grading();

            dataGridViewTopRatied.DataSource = listOfMovies;
            dataGridViewTopRatied.Columns["Id"].Visible = true;
            dataGridViewTopRatied.Columns["Year"].Visible = false;
            dataGridViewTopRatied.Columns["Genre"].Visible = false;
            dataGridViewTopRatied.Columns["Favorite"].Visible = false;
            dataGridViewTopRatied.Columns["IMDBLink"].Visible = false;
            dataGridViewTopRatied.Columns["Description"].Visible = false;

            dataGridViewTopRatied.Columns.Add("Rate", "Rate");
            int rateColumn = 7;

            int rowNum = Convert.ToInt32(dataGridViewTopRatied.RowCount.ToString());
            int movieId;
            for (int i = 0; i < rowNum; i++)
            {
                movieId = (int)dataGridViewTopRatied.Rows[i].Cells[0].Value;
                dataGridViewTopRatied[rateColumn, i].Value = this.gradingBusiness.AverageRate(movieId).ToString("N2");
            }
        }
    }
}
