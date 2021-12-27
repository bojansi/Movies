
namespace MovieApp
{
    partial class MovieView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieView));
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.checkBoxFavorite = new System.Windows.Forms.CheckBox();
            this.labelIMDB = new System.Windows.Forms.Label();
            this.pictureBoxStar1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar5 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar5)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(311, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(99, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Naslov filma :";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(46, 63);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(147, 20);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "Godina proizvodnje :";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(46, 98);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(84, 20);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Zanr filma :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(46, 133);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(84, 20);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Opis filma :";
            // 
            // checkBoxFavorite
            // 
            this.checkBoxFavorite.AutoSize = true;
            this.checkBoxFavorite.Location = new System.Drawing.Point(43, 355);
            this.checkBoxFavorite.Name = "checkBoxFavorite";
            this.checkBoxFavorite.Size = new System.Drawing.Size(87, 24);
            this.checkBoxFavorite.TabIndex = 4;
            this.checkBoxFavorite.Text = "Omiljeni";
            this.checkBoxFavorite.UseVisualStyleBackColor = true;
            // 
            // labelIMDB
            // 
            this.labelIMDB.AutoSize = true;
            this.labelIMDB.Location = new System.Drawing.Point(43, 393);
            this.labelIMDB.Name = "labelIMDB";
            this.labelIMDB.Size = new System.Drawing.Size(73, 20);
            this.labelIMDB.TabIndex = 5;
            this.labelIMDB.Text = "IMDB link";
            // 
            // pictureBoxStar1
            // 
            this.pictureBoxStar1.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar1.Location = new System.Drawing.Point(42, 314);
            this.pictureBoxStar1.Name = "pictureBoxStar1";
            this.pictureBoxStar1.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStar1.TabIndex = 6;
            this.pictureBoxStar1.TabStop = false;
            this.pictureBoxStar1.Click += new System.EventHandler(this.pictureBoxStar1_Click);
            // 
            // pictureBoxStar2
            // 
            this.pictureBoxStar2.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar2.Location = new System.Drawing.Point(88, 314);
            this.pictureBoxStar2.Name = "pictureBoxStar2";
            this.pictureBoxStar2.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStar2.TabIndex = 7;
            this.pictureBoxStar2.TabStop = false;
            this.pictureBoxStar2.Click += new System.EventHandler(this.pictureBoxStar2_Click);
            // 
            // pictureBoxStar4
            // 
            this.pictureBoxStar4.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar4.Location = new System.Drawing.Point(179, 314);
            this.pictureBoxStar4.Name = "pictureBoxStar4";
            this.pictureBoxStar4.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStar4.TabIndex = 9;
            this.pictureBoxStar4.TabStop = false;
            this.pictureBoxStar4.Click += new System.EventHandler(this.pictureBoxStar4_Click);
            // 
            // pictureBoxStar3
            // 
            this.pictureBoxStar3.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar3.Location = new System.Drawing.Point(133, 314);
            this.pictureBoxStar3.Name = "pictureBoxStar3";
            this.pictureBoxStar3.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStar3.TabIndex = 8;
            this.pictureBoxStar3.TabStop = false;
            this.pictureBoxStar3.Click += new System.EventHandler(this.pictureBoxStar3_Click);
            // 
            // pictureBoxStar5
            // 
            this.pictureBoxStar5.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar5.Location = new System.Drawing.Point(225, 314);
            this.pictureBoxStar5.Name = "pictureBoxStar5";
            this.pictureBoxStar5.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxStar5.TabIndex = 10;
            this.pictureBoxStar5.TabStop = false;
            this.pictureBoxStar5.Click += new System.EventHandler(this.pictureBoxStar5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(52, 162);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(658, 101);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // MovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBoxStar5);
            this.Controls.Add(this.pictureBoxStar4);
            this.Controls.Add(this.pictureBoxStar3);
            this.Controls.Add(this.pictureBoxStar2);
            this.Controls.Add(this.pictureBoxStar1);
            this.Controls.Add(this.labelIMDB);
            this.Controls.Add(this.checkBoxFavorite);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieView";
            this.Text = "MovieView";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStar5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.CheckBox checkBoxFavorite;
        private System.Windows.Forms.Label labelIMDB;
        private System.Windows.Forms.PictureBox pictureBoxStar1;
        private System.Windows.Forms.PictureBox pictureBoxStar2;
        private System.Windows.Forms.PictureBox pictureBoxStar4;
        private System.Windows.Forms.PictureBox pictureBoxStar3;
        private System.Windows.Forms.PictureBox pictureBoxStar5;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}