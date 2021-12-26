
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
            this.checkBoxFavorite.Location = new System.Drawing.Point(46, 310);
            this.checkBoxFavorite.Name = "checkBoxFavorite";
            this.checkBoxFavorite.Size = new System.Drawing.Size(87, 24);
            this.checkBoxFavorite.TabIndex = 4;
            this.checkBoxFavorite.Text = "Omiljeni";
            this.checkBoxFavorite.UseVisualStyleBackColor = true;
            // 
            // labelIMDB
            // 
            this.labelIMDB.AutoSize = true;
            this.labelIMDB.Location = new System.Drawing.Point(46, 348);
            this.labelIMDB.Name = "labelIMDB";
            this.labelIMDB.Size = new System.Drawing.Size(73, 20);
            this.labelIMDB.TabIndex = 5;
            this.labelIMDB.Text = "IMDB link";
            this.labelIMDB.Click += new System.EventHandler(this.labelIMDB_Click);
            // 
            // MovieView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIMDB);
            this.Controls.Add(this.checkBoxFavorite);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieView";
            this.Text = "MovieView";
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
    }
}