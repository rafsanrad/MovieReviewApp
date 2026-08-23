namespace MovieReviewApp
{
    partial class HomeForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnWatchlist = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelMovieDetails = new System.Windows.Forms.Panel();
            this.btnBackToMovies = new System.Windows.Forms.Button();
            this.lblMovieDescription = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDetailYear = new System.Windows.Forms.Label();
            this.lblDetailGenre = new System.Windows.Forms.Label();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.flowMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnAddToWatchlist = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelMovieDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Location = new System.Drawing.Point(17, 676);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.btnWatchlist);
            this.panelSidebar.Controls.Add(this.btnFavorites);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(157, 739);
            this.panelSidebar.TabIndex = 4;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(11, 231);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(129, 44);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(11, 24);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(129, 51);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // btnWatchlist
            // 
            this.btnWatchlist.Location = new System.Drawing.Point(11, 162);
            this.btnWatchlist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnWatchlist.Name = "btnWatchlist";
            this.btnWatchlist.Size = new System.Drawing.Size(129, 46);
            this.btnWatchlist.TabIndex = 1;
            this.btnWatchlist.Text = "Watchlist";
            this.btnWatchlist.UseVisualStyleBackColor = true;
            // 
            // btnFavorites
            // 
            this.btnFavorites.Location = new System.Drawing.Point(11, 94);
            this.btnFavorites.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(129, 48);
            this.btnFavorites.TabIndex = 0;
            this.btnFavorites.Text = "Favorites";
            this.btnFavorites.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelMovieDetails);
            this.panelContent.Controls.Add(this.flowMovies);
            this.panelContent.Controls.Add(this.cmbGenre);
            this.panelContent.Controls.Add(this.lblGenre);
            this.panelContent.Controls.Add(this.btnSearch);
            this.panelContent.Controls.Add(this.txtSearch);
            this.panelContent.Controls.Add(this.lblSearch);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(157, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(897, 739);
            this.panelContent.TabIndex = 5;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panelMovieDetails
            // 
            this.panelMovieDetails.Controls.Add(this.btnAddToWatchlist);
            this.panelMovieDetails.Controls.Add(this.btnFavorite);
            this.panelMovieDetails.Controls.Add(this.btnBackToMovies);
            this.panelMovieDetails.Controls.Add(this.lblMovieDescription);
            this.panelMovieDetails.Controls.Add(this.lblDirector);
            this.panelMovieDetails.Controls.Add(this.lblDetailYear);
            this.panelMovieDetails.Controls.Add(this.lblDetailGenre);
            this.panelMovieDetails.Controls.Add(this.pictureBoxDetails);
            this.panelMovieDetails.Controls.Add(this.lblDetailTitle);
            this.panelMovieDetails.Location = new System.Drawing.Point(42, 148);
            this.panelMovieDetails.Name = "panelMovieDetails";
            this.panelMovieDetails.Size = new System.Drawing.Size(800, 552);
            this.panelMovieDetails.TabIndex = 6;
            this.panelMovieDetails.Visible = false;
            // 
            // btnBackToMovies
            // 
            this.btnBackToMovies.Location = new System.Drawing.Point(331, 449);
            this.btnBackToMovies.Name = "btnBackToMovies";
            this.btnBackToMovies.Size = new System.Drawing.Size(155, 52);
            this.btnBackToMovies.TabIndex = 6;
            this.btnBackToMovies.Text = "Back to Movies";
            this.btnBackToMovies.UseVisualStyleBackColor = true;
            this.btnBackToMovies.Click += new System.EventHandler(this.btnBackToMovies_Click_1);
            // 
            // lblMovieDescription
            // 
            this.lblMovieDescription.AutoSize = true;
            this.lblMovieDescription.Location = new System.Drawing.Point(345, 262);
            this.lblMovieDescription.Name = "lblMovieDescription";
            this.lblMovieDescription.Size = new System.Drawing.Size(51, 20);
            this.lblMovieDescription.TabIndex = 5;
            this.lblMovieDescription.Text = "label1";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(349, 215);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(69, 20);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director:";
            this.lblDirector.Click += new System.EventHandler(this.lblDirector_Click);
            // 
            // lblDetailYear
            // 
            this.lblDetailYear.AutoSize = true;
            this.lblDetailYear.Location = new System.Drawing.Point(349, 175);
            this.lblDetailYear.Name = "lblDetailYear";
            this.lblDetailYear.Size = new System.Drawing.Size(110, 20);
            this.lblDetailYear.TabIndex = 3;
            this.lblDetailYear.Text = "Release Year:";
            this.lblDetailYear.Click += new System.EventHandler(this.lblDetailYear_Click);
            // 
            // lblDetailGenre
            // 
            this.lblDetailGenre.AutoSize = true;
            this.lblDetailGenre.Location = new System.Drawing.Point(345, 130);
            this.lblDetailGenre.Name = "lblDetailGenre";
            this.lblDetailGenre.Size = new System.Drawing.Size(58, 20);
            this.lblDetailGenre.TabIndex = 2;
            this.lblDetailGenre.Text = "Genre:";
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.Location = new System.Drawing.Point(57, 47);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(220, 300);
            this.pictureBoxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetails.TabIndex = 1;
            this.pictureBoxDetails.TabStop = false;
            this.pictureBoxDetails.Click += new System.EventHandler(this.pictureBoxDetails_Click);
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailTitle.Location = new System.Drawing.Point(314, 47);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(219, 48);
            this.lblDetailTitle.TabIndex = 0;
            this.lblDetailTitle.Text = " Movie Title";
            this.lblDetailTitle.Click += new System.EventHandler(this.lblDetailTitle_Click);
            // 
            // flowMovies
            // 
            this.flowMovies.AutoScroll = true;
            this.flowMovies.Location = new System.Drawing.Point(42, 148);
            this.flowMovies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowMovies.Name = "flowMovies";
            this.flowMovies.Size = new System.Drawing.Size(813, 562);
            this.flowMovies.TabIndex = 5;
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
            this.cmbGenre.Location = new System.Drawing.Point(259, 65);
            this.cmbGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(180, 28);
            this.cmbGenre.TabIndex = 4;
            this.cmbGenre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(138, 66);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(114, 20);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre              :";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(462, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(259, 19);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(138, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(113, 20);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Movie :";
            // 
            // btnFavorite
            // 
            this.btnFavorite.Location = new System.Drawing.Point(349, 323);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(162, 38);
            this.btnFavorite.TabIndex = 7;
            this.btnFavorite.Text = "Add to Favorite";
            this.btnFavorite.UseVisualStyleBackColor = true;
            // 
            // btnAddToWatchlist
            // 
            this.btnAddToWatchlist.Location = new System.Drawing.Point(545, 323);
            this.btnAddToWatchlist.Name = "btnAddToWatchlist";
            this.btnAddToWatchlist.Size = new System.Drawing.Size(159, 38);
            this.btnAddToWatchlist.TabIndex = 8;
            this.btnAddToWatchlist.Text = "Add to Watchlist";
            this.btnAddToWatchlist.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 739);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Location = new System.Drawing.Point(180, 50);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeForm";
            this.Text = "Cineverse";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelMovieDetails.ResumeLayout(false);
            this.panelMovieDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnWatchlist;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnFavorites;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.FlowLayoutPanel flowMovies;
        private System.Windows.Forms.Panel panelMovieDetails;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.PictureBox pictureBoxDetails;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDetailYear;
        private System.Windows.Forms.Label lblDetailGenre;
        private System.Windows.Forms.Button btnBackToMovies;
        private System.Windows.Forms.Label lblMovieDescription;
        private System.Windows.Forms.Button btnAddToWatchlist;
        private System.Windows.Forms.Button btnFavorite;
    }
}