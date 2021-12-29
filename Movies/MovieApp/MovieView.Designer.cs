
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
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.pictureBoxStar1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxStar5 = new System.Windows.Forms.PictureBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.labelPrintRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAverageRate = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
            this.labelName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(311, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 22);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Naslov filma :";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYear.Location = new System.Drawing.Point(51, 64);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(153, 22);
            this.labelYear.TabIndex = 1;
            this.labelYear.Text = "Godina snimanja :";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenre.Location = new System.Drawing.Point(51, 101);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(101, 22);
            this.labelGenre.TabIndex = 2;
            this.labelGenre.Text = "Zanr filma :";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(51, 137);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(101, 22);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Opis filma :";
            // 
            // checkBoxFavorite
            // 
            this.checkBoxFavorite.AutoSize = true;
            this.checkBoxFavorite.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFavorite.Location = new System.Drawing.Point(51, 335);
            this.checkBoxFavorite.Name = "checkBoxFavorite";
            this.checkBoxFavorite.Size = new System.Drawing.Size(96, 26);
            this.checkBoxFavorite.TabIndex = 4;
            this.checkBoxFavorite.Text = "Omiljeni";
            this.checkBoxFavorite.UseVisualStyleBackColor = true;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxDescription.Location = new System.Drawing.Point(52, 162);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(658, 101);
            this.richTextBoxDescription.TabIndex = 11;
            this.richTextBoxDescription.Text = "";
            // 
            // pictureBoxStar1
            // 
            this.pictureBoxStar1.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar1.Location = new System.Drawing.Point(52, 289);
            this.pictureBoxStar1.Name = "pictureBoxStar1";
            this.pictureBoxStar1.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStar1.TabIndex = 12;
            this.pictureBoxStar1.TabStop = false;
            this.pictureBoxStar1.Click += new System.EventHandler(this.pictureBoxStar1_Click);
            // 
            // pictureBoxStar2
            // 
            this.pictureBoxStar2.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar2.Location = new System.Drawing.Point(97, 289);
            this.pictureBoxStar2.Name = "pictureBoxStar2";
            this.pictureBoxStar2.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStar2.TabIndex = 13;
            this.pictureBoxStar2.TabStop = false;
            this.pictureBoxStar2.Click += new System.EventHandler(this.pictureBoxStar2_Click);
            // 
            // pictureBoxStar4
            // 
            this.pictureBoxStar4.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar4.Location = new System.Drawing.Point(192, 289);
            this.pictureBoxStar4.Name = "pictureBoxStar4";
            this.pictureBoxStar4.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStar4.TabIndex = 15;
            this.pictureBoxStar4.TabStop = false;
            this.pictureBoxStar4.Click += new System.EventHandler(this.pictureBoxStar4_Click);
            // 
            // pictureBoxStar3
            // 
            this.pictureBoxStar3.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar3.Location = new System.Drawing.Point(144, 289);
            this.pictureBoxStar3.Name = "pictureBoxStar3";
            this.pictureBoxStar3.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStar3.TabIndex = 14;
            this.pictureBoxStar3.TabStop = false;
            this.pictureBoxStar3.Click += new System.EventHandler(this.pictureBoxStar3_Click);
            // 
            // pictureBoxStar5
            // 
            this.pictureBoxStar5.Image = global::MovieApp.Properties.Resources.white_star;
            this.pictureBoxStar5.Location = new System.Drawing.Point(239, 289);
            this.pictureBoxStar5.Name = "pictureBoxStar5";
            this.pictureBoxStar5.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStar5.TabIndex = 16;
            this.pictureBoxStar5.TabStop = false;
            this.pictureBoxStar5.Click += new System.EventHandler(this.pictureBoxStar5_Click);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRate.Location = new System.Drawing.Point(311, 294);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(71, 22);
            this.labelRate.TabIndex = 17;
            this.labelRate.Text = "Ocena :";
            // 
            // labelPrintRate
            // 
            this.labelPrintRate.AutoSize = true;
            this.labelPrintRate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrintRate.Location = new System.Drawing.Point(375, 294);
            this.labelPrintRate.Name = "labelPrintRate";
            this.labelPrintRate.Size = new System.Drawing.Size(0, 22);
            this.labelPrintRate.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 19;
            this.label1.Text = "Prosecna ocena :";
            // 
            // labelAverageRate
            // 
            this.labelAverageRate.AutoSize = true;
            this.labelAverageRate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAverageRate.Location = new System.Drawing.Point(201, 409);
            this.labelAverageRate.Name = "labelAverageRate";
            this.labelAverageRate.Size = new System.Drawing.Size(0, 22);
            this.labelAverageRate.TabIndex = 20;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(52, 374);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(86, 22);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "IMDBLink";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.labelAverageRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPrintRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.pictureBoxStar5);
            this.Controls.Add(this.pictureBoxStar4);
            this.Controls.Add(this.pictureBoxStar3);
            this.Controls.Add(this.pictureBoxStar2);
            this.Controls.Add(this.pictureBoxStar1);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.checkBoxFavorite);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieView";
            this.Text = "Pregled filma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MovieView_FormClosing);
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
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.PictureBox pictureBoxStar1;
        private System.Windows.Forms.PictureBox pictureBoxStar2;
        private System.Windows.Forms.PictureBox pictureBoxStar4;
        private System.Windows.Forms.PictureBox pictureBoxStar3;
        private System.Windows.Forms.PictureBox pictureBoxStar5;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Label labelPrintRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAverageRate;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}