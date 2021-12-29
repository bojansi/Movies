
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.buttonToUser = new System.Windows.Forms.Button();
            this.buttonToMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToAddRows = false;
            this.dataGridViewMovies.AllowUserToDeleteRows = false;
            this.dataGridViewMovies.AllowUserToResizeColumns = false;
            this.dataGridViewMovies.AllowUserToResizeRows = false;
            this.dataGridViewMovies.ColumnHeadersHeight = 29;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMovies.Location = new System.Drawing.Point(461, 23);
            this.dataGridViewMovies.MultiSelect = false;
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ReadOnly = true;
            this.dataGridViewMovies.RowHeadersVisible = false;
            this.dataGridViewMovies.RowHeadersWidth = 51;
            this.dataGridViewMovies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMovies.RowTemplate.Height = 29;
            this.dataGridViewMovies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMovies.Size = new System.Drawing.Size(547, 376);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMovies_CellDoubleClick);
            // 
            // buttonToUser
            // 
            this.buttonToUser.Location = new System.Drawing.Point(101, 304);
            this.buttonToUser.Name = "buttonToUser";
            this.buttonToUser.Size = new System.Drawing.Size(155, 29);
            this.buttonToUser.TabIndex = 2;
            this.buttonToUser.Text = "Izmeni korisnika";
            this.buttonToUser.UseVisualStyleBackColor = true;
            this.buttonToUser.Click += new System.EventHandler(this.buttonToUser_Click);
            // 
            // buttonToMovie
            // 
            this.buttonToMovie.Location = new System.Drawing.Point(101, 222);
            this.buttonToMovie.Name = "buttonToMovie";
            this.buttonToMovie.Size = new System.Drawing.Size(155, 29);
            this.buttonToMovie.TabIndex = 3;
            this.buttonToMovie.Text = "Izmeni Film";
            this.buttonToMovie.UseVisualStyleBackColor = true;
            this.buttonToMovie.Click += new System.EventHandler(this.buttonToMovie_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1061, 447);
            this.Controls.Add(this.buttonToMovie);
            this.Controls.Add(this.buttonToUser);
            this.Controls.Add(this.dataGridViewMovies);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.Button buttonToUser;
        private System.Windows.Forms.Button buttonToMovie;
    }
}