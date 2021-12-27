using BusinessLogicLayer;
using DataAccessLayer.Modals;
using MovieApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class MovieView : Form
    {
        private void pictureBoxStar1_Click(object sender, EventArgs e)
        {
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.white_star;
            pictureBoxStar3.Image = Resources.white_star;
            pictureBoxStar4.Image = Resources.white_star;
            pictureBoxStar5.Image = Resources.white_star;
        }

        private void pictureBoxStar2_Click(object sender, EventArgs e)
        {
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.white_star;
            pictureBoxStar4.Image = Resources.white_star;
            pictureBoxStar5.Image = Resources.white_star;
        }

        private void pictureBoxStar3_Click(object sender, EventArgs e)
        {
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.yellow_star;
            pictureBoxStar4.Image = Resources.white_star;
            pictureBoxStar5.Image = Resources.white_star;
        }

        private void pictureBoxStar4_Click(object sender, EventArgs e)
        {
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.yellow_star;
            pictureBoxStar4.Image = Resources.yellow_star;
            pictureBoxStar5.Image = Resources.white_star;
        }

        private void pictureBoxStar5_Click(object sender, EventArgs e)
        {
            pictureBoxStar1.Image = Resources.yellow_star;
            pictureBoxStar2.Image = Resources.yellow_star;
            pictureBoxStar3.Image = Resources.yellow_star;
            pictureBoxStar4.Image = Resources.yellow_star;
            pictureBoxStar5.Image = Resources.yellow_star;
        }

    }
}
