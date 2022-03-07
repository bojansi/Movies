
namespace MovieApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.buttonToUser = new System.Windows.Forms.Button();
            this.buttonToMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMovieRate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
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
            this.dataGridViewMovies.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewMovies.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMovies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMovies.ColumnHeadersHeight = 29;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMovies.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(152)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMovies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMovies.GridColor = System.Drawing.Color.Black;
            this.dataGridViewMovies.Location = new System.Drawing.Point(365, 21);
            this.dataGridViewMovies.MultiSelect = false;
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ReadOnly = true;
            this.dataGridViewMovies.RowHeadersVisible = false;
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridViewMovies.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMovies.RowTemplate.Height = 29;
            this.dataGridViewMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovies.Size = new System.Drawing.Size(378, 330);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellDoubleClick);
            // 
            // buttonToUser
            // 
            this.buttonToUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.buttonToUser.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonToUser.ForeColor = System.Drawing.Color.Black;
            this.buttonToUser.Location = new System.Drawing.Point(85, 230);
            this.buttonToUser.Name = "buttonToUser";
            this.buttonToUser.Size = new System.Drawing.Size(193, 60);
            this.buttonToUser.TabIndex = 2;
            this.buttonToUser.Text = "Izmeni korisnika";
            this.buttonToUser.UseVisualStyleBackColor = false;
            this.buttonToUser.Click += new System.EventHandler(this.buttonToUser_Click);
            // 
            // buttonToMovie
            // 
            this.buttonToMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.buttonToMovie.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonToMovie.ForeColor = System.Drawing.Color.Black;
            this.buttonToMovie.Location = new System.Drawing.Point(85, 160);
            this.buttonToMovie.Name = "buttonToMovie";
            this.buttonToMovie.Size = new System.Drawing.Size(193, 60);
            this.buttonToMovie.TabIndex = 3;
            this.buttonToMovie.Text = "Izmeni film";
            this.buttonToMovie.UseVisualStyleBackColor = false;
            this.buttonToMovie.Click += new System.EventHandler(this.buttonToMovie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 89);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filmovi";
            // 
            // buttonMovieRate
            // 
            this.buttonMovieRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(233)))), ((int)(((byte)(207)))));
            this.buttonMovieRate.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMovieRate.ForeColor = System.Drawing.Color.Black;
            this.buttonMovieRate.Location = new System.Drawing.Point(85, 300);
            this.buttonMovieRate.Name = "buttonMovieRate";
            this.buttonMovieRate.Size = new System.Drawing.Size(193, 60);
            this.buttonMovieRate.TabIndex = 5;
            this.buttonMovieRate.Text = "Ocene Filmova";
            this.buttonMovieRate.UseVisualStyleBackColor = false;
            this.buttonMovieRate.Click += new System.EventHandler(this.buttonTopRatied_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(202)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(774, 402);
            this.Controls.Add(this.buttonMovieRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonToMovie);
            this.Controls.Add(this.buttonToUser);
            this.Controls.Add(this.dataGridViewMovies);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Button buttonToUser;
        private System.Windows.Forms.Button buttonToMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMovieRate;
    }
}