namespace MovieReviewApp.Forms
{
    partial class AddMovie
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
            this.pnlAddMovie = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPosterPath = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.textReleaseYear = new System.Windows.Forms.TextBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.txtMovieTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblReleaseyear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlAddMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddMovie
            // 
            this.pnlAddMovie.Controls.Add(this.btnClear);
            this.pnlAddMovie.Controls.Add(this.btnCancel);
            this.pnlAddMovie.Controls.Add(this.btnAddMovie);
            this.pnlAddMovie.Controls.Add(this.btnBrowse);
            this.pnlAddMovie.Controls.Add(this.txtPosterPath);
            this.pnlAddMovie.Controls.Add(this.txtDescription);
            this.pnlAddMovie.Controls.Add(this.txtDirector);
            this.pnlAddMovie.Controls.Add(this.textReleaseYear);
            this.pnlAddMovie.Controls.Add(this.cmbGenre);
            this.pnlAddMovie.Controls.Add(this.txtMovieTitle);
            this.pnlAddMovie.Controls.Add(this.label6);
            this.pnlAddMovie.Controls.Add(this.lblDescription);
            this.pnlAddMovie.Controls.Add(this.lblDirector);
            this.pnlAddMovie.Controls.Add(this.lblReleaseyear);
            this.pnlAddMovie.Controls.Add(this.lblGenre);
            this.pnlAddMovie.Controls.Add(this.lblMovieTitle);
            this.pnlAddMovie.Controls.Add(this.lblSubTitle);
            this.pnlAddMovie.Controls.Add(this.lblTitle);
            this.pnlAddMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddMovie.Location = new System.Drawing.Point(0, 0);
            this.pnlAddMovie.Name = "pnlAddMovie";
            this.pnlAddMovie.Size = new System.Drawing.Size(678, 584);
            this.pnlAddMovie.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(414, 535);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 35);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Crimson;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(194, 535);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 35);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMovie.Location = new System.Drawing.Point(194, 462);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(400, 45);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "ADD MOVIE";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(504, 416);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 30);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // txtPosterPath
            // 
            this.txtPosterPath.Location = new System.Drawing.Point(194, 417);
            this.txtPosterPath.Name = "txtPosterPath";
            this.txtPosterPath.Size = new System.Drawing.Size(300, 26);
            this.txtPosterPath.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(194, 297);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 100);
            this.txtDescription.TabIndex = 10;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(194, 252);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(400, 26);
            this.txtDirector.TabIndex = 9;
            // 
            // textReleaseYear
            // 
            this.textReleaseYear.Location = new System.Drawing.Point(194, 207);
            this.textReleaseYear.Name = "textReleaseYear";
            this.textReleaseYear.Size = new System.Drawing.Size(150, 26);
            this.textReleaseYear.TabIndex = 1;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "All",
            "Action",
            "Adventure",
            "Comedy",
            "Drama",
            "Horror",
            "Romance",
            "Sci-Fi",
            "Thriller",
            "Animation"});
            this.cmbGenre.Location = new System.Drawing.Point(194, 162);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(250, 28);
            this.cmbGenre.TabIndex = 8;
            // 
            // txtMovieTitle
            // 
            this.txtMovieTitle.Location = new System.Drawing.Point(194, 117);
            this.txtMovieTitle.Name = "txtMovieTitle";
            this.txtMovieTitle.Size = new System.Drawing.Size(400, 26);
            this.txtMovieTitle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 420);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Poster             :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(70, 300);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(113, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description     :";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(70, 255);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(113, 20);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director           :";
            // 
            // lblReleaseyear
            // 
            this.lblReleaseyear.AutoSize = true;
            this.lblReleaseyear.Location = new System.Drawing.Point(70, 210);
            this.lblReleaseyear.Name = "lblReleaseyear";
            this.lblReleaseyear.Size = new System.Drawing.Size(114, 20);
            this.lblReleaseyear.TabIndex = 3;
            this.lblReleaseyear.Text = "Release Year :";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(70, 165);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(114, 20);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre              :";
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Location = new System.Drawing.Point(70, 120);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(115, 20);
            this.lblMovieTitle.TabIndex = 1;
            this.lblMovieTitle.Text = "Movie Title       :";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(243, 62);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(209, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Enter movie information";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Add New Movie";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 584);
            this.Controls.Add(this.pnlAddMovie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cineverse - Add Movie";
            this.pnlAddMovie.ResumeLayout(false);
            this.pnlAddMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddMovie;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblReleaseyear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.TextBox txtMovieTitle;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.TextBox textReleaseYear;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPosterPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnClear;
    }
}