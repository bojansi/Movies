using BusinessLogicLayer;
using DataAccessLayer.Modals;
using MovieApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class MovieView : Form
    {
        private readonly GradingBusiness gradingBusiness;
        private readonly MovieBusiness movieBusiness;
        private Movie movie;
        Grading grading = new Grading();
        int grade;

        public static int currentUserId;
        public MovieView(MovieBusiness movieBusiness, Movie m)
        {
            
            InitializeComponent();
            this.gradingBusiness = new GradingBusiness();
            this.movieBusiness = new MovieBusiness();
            movie = m;
            labelName.Text = m.Name;
            labelYear.Text = "Godina snimanja : "+ m.Year.ToString();
            labelGenre.Text = "Zanr : " + m.Genre;
            richTextBoxDescription.Text = m.Description;
            string cb = checkBoxFavorite.Checked.ToString();
            if (cb.Equals("true"))
            {
                checkBoxFavorite.Checked = true;
            }
            else
            {
                checkBoxFavorite.Checked = false;
            }
            
            grade = this.gradingBusiness.AlreadyRated(movie.Id, currentUserId);
            labelPrintRate.Text = grade.ToString();

            colorRate(grade);
            
            labelAverageRate.Text = this.gradingBusiness.AverageRate(m.Id).ToString("N2");
        }

        private void colorRate(int grade)
        {
            if(grade > 0)
                pictureBoxStar1.Image = Resources.yellow_star;
            if(grade > 1)
                pictureBoxStar2.Image = Resources.yellow_star;
            if(grade > 2)
                pictureBoxStar3.Image = Resources.yellow_star;
            if(grade > 3)
                pictureBoxStar4.Image = Resources.yellow_star;
            if(grade >4)
                pictureBoxStar5.Image = Resources.yellow_star;
        }



        private void pictureBoxStar1_Click(object sender, EventArgs e)
        {
            if(grade > 0)
                return;

            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.white_star;
            pictureBoxStar3.Image = Resources.white_star;
            pictureBoxStar4.Image = Resources.white_star;
            pictureBoxStar5.Image = Resources.white_star;
            labelPrintRate.Text = "1";
        }

        private void pictureBoxStar2_Click(object sender, EventArgs e)
        {
            if (grade > 0)
                return;
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.white_star;
            pictureBoxStar4.Image = Resources.white_star;
            pictureBoxStar5.Image = Resources.white_star;
            labelPrintRate.Text = "2";
        }

        private void pictureBoxStar3_Click(object sender, EventArgs e)
        {
            if (grade > 0)
                return;
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.yellow_star;
            pictureBoxStar4.Image = Resources.white_star;
            pictureBoxStar5.Image = Resources.white_star;
            labelPrintRate.Text = "3";
        }

        private void pictureBoxStar4_Click(object sender, EventArgs e)
        {
            if (grade > 0)
                return;
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.yellow_star;
            pictureBoxStar4.Image = Resources.yellow_star;
            pictureBoxStar5.Image = Resources.white_star;
            labelPrintRate.Text = "4";
        }

        private void pictureBoxStar5_Click(object sender, EventArgs e)
        {
            if (grade > 0)
                return;
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.yellow_star;
            pictureBoxStar4.Image = Resources.yellow_star;
            pictureBoxStar5.Image = Resources.yellow_star;
            labelPrintRate.Text = "5";
        }

        private void MovieView_FormClosing(object sender, FormClosingEventArgs e)
        {
            movie.Favorite = checkBoxFavorite.Checked;
            this.movieBusiness.UpdateMovie(movie);

            if(this.gradingBusiness.AlreadyRated(movie.Id, currentUserId) != 0)
            {
                return;
            }

            if (labelPrintRate.Text !="0") 
            {
                grading.Rating = Convert.ToInt32(labelPrintRate.Text);
                grading.Movie_Id = movie.Id;

                if(currentUserId == -1)
                {
                    MessageBox.Show("Greska!");
                }
                else
                {
                    grading.User_Id = currentUserId;
                    this.gradingBusiness.InsertGrading(grading);
                }
            }



        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(movie.IMDBLink);
        }
    }
}
