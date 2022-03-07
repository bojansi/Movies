
namespace MovieApp
{
    partial class Movies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movies));
            this.labelId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelIMDB = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxIMDB = new System.Windows.Forms.TextBox();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonUpdateMovie = new System.Windows.Forms.Button();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.checkBoxFavorite = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelId.Location = new System.Drawing.Point(39, 54);
            this.labelId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(39, 22);
            this.labelId.TabIndex = 0;
            this.labelId.Text = "Id :";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(39, 102);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 22);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Naziv filma :";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelYear.Location = new System.Drawing.Point(39, 151);
            this.labelYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(153, 22);
            this.labelYear.TabIndex = 2;
            this.labelYear.Text = "Godina snimanja :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Zanr :";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBoxDescription.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxDescription.Location = new System.Drawing.Point(39, 298);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(374, 161);
            this.richTextBoxDescription.TabIndex = 4;
            this.richTextBoxDescription.Text = "Opis";
            // 
            // labelIMDB
            // 
            this.labelIMDB.AutoSize = true;
            this.labelIMDB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIMDB.Location = new System.Drawing.Point(39, 246);
            this.labelIMDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIMDB.Name = "labelIMDB";
            this.labelIMDB.Size = new System.Drawing.Size(99, 22);
            this.labelIMDB.TabIndex = 6;
            this.labelIMDB.Text = "IMDB link :";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Enabled = false;
            this.textBoxId.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxId.Location = new System.Drawing.Point(256, 51);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(156, 22);
            this.textBoxId.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(256, 99);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 22);
            this.textBoxName.TabIndex = 8;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxYear.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxYear.Location = new System.Drawing.Point(256, 147);
            this.textBoxYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(156, 22);
            this.textBoxYear.TabIndex = 9;
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.textBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxGenre.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGenre.Location = new System.Drawing.Point(256, 196);
            this.textBoxGenre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(156, 22);
            this.textBoxGenre.TabIndex = 10;
            // 
            // textBoxIMDB
            // 
            this.textBoxIMDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.textBoxIMDB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxIMDB.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxIMDB.Location = new System.Drawing.Point(256, 243);
            this.textBoxIMDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIMDB.Name = "textBoxIMDB";
            this.textBoxIMDB.Size = new System.Drawing.Size(156, 22);
            this.textBoxIMDB.TabIndex = 11;
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToAddRows = false;
            this.dataGridViewMovies.AllowUserToDeleteRows = false;
            this.dataGridViewMovies.AllowUserToResizeColumns = false;
            this.dataGridViewMovies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(152)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewMovies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewMovies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.dataGridViewMovies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(152)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMovies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMovies.Location = new System.Drawing.Point(482, 13);
            this.dataGridViewMovies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewMovies.MultiSelect = false;
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ReadOnly = true;
            this.dataGridViewMovies.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(152)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovies.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMovies.RowHeadersVisible = false;
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMovies.RowTemplate.Height = 29;
            this.dataGridViewMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovies.Size = new System.Drawing.Size(1234, 603);
            this.dataGridViewMovies.TabIndex = 12;
            this.dataGridViewMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellClick);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.buttonAddMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddMovie.Location = new System.Drawing.Point(15, 565);
            this.buttonAddMovie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(132, 51);
            this.buttonAddMovie.TabIndex = 13;
            this.buttonAddMovie.Text = "Dodaj film";
            this.buttonAddMovie.UseVisualStyleBackColor = false;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonUpdateMovie
            // 
            this.buttonUpdateMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.buttonUpdateMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateMovie.Location = new System.Drawing.Point(155, 565);
            this.buttonUpdateMovie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonUpdateMovie.Name = "buttonUpdateMovie";
            this.buttonUpdateMovie.Size = new System.Drawing.Size(132, 51);
            this.buttonUpdateMovie.TabIndex = 14;
            this.buttonUpdateMovie.Text = "Izmeni film";
            this.buttonUpdateMovie.UseVisualStyleBackColor = false;
            this.buttonUpdateMovie.Click += new System.EventHandler(this.buttonUpdateMovie_Click);
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.buttonDeleteMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteMovie.Location = new System.Drawing.Point(295, 565);
            this.buttonDeleteMovie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(132, 51);
            this.buttonDeleteMovie.TabIndex = 15;
            this.buttonDeleteMovie.Text = "Obrisi film";
            this.buttonDeleteMovie.UseVisualStyleBackColor = false;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            // 
            // checkBoxFavorite
            // 
            this.checkBoxFavorite.AutoSize = true;
            this.checkBoxFavorite.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxFavorite.Location = new System.Drawing.Point(39, 483);
            this.checkBoxFavorite.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFavorite.Name = "checkBoxFavorite";
            this.checkBoxFavorite.Size = new System.Drawing.Size(96, 26);
            this.checkBoxFavorite.TabIndex = 16;
            this.checkBoxFavorite.Text = "Omiljeni";
            this.checkBoxFavorite.UseVisualStyleBackColor = true;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(1731, 651);
            this.Controls.Add(this.checkBoxFavorite);
            this.Controls.Add(this.buttonDeleteMovie);
            this.Controls.Add(this.buttonUpdateMovie);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.dataGridViewMovies);
            this.Controls.Add(this.textBoxIMDB);
            this.Controls.Add(this.textBoxGenre);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelIMDB);
            this.Controls.Add(this.richTextBoxDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelId);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Movies";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.Movies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelIMDB;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxIMDB;
        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonUpdateMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.CheckBox checkBoxFavorite;
    }
}