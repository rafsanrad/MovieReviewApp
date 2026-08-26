namespace MovieReviewApp
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.lblProfileRole = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileTitle = new System.Windows.Forms.Label();
            this.panelMovieDetails = new System.Windows.Forms.Panel();
            this.lblReviewCount = new System.Windows.Forms.Label();
            this.flowReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReviewsTitle = new System.Windows.Forms.Label();
            this.btnReview = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptiontitle = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDetailYear = new System.Windows.Forms.Label();
            this.lblDetailGenre = new System.Windows.Forms.Label();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.pictureBoxDetails = new System.Windows.Forms.PictureBox();
            this.btnAddToWatchlist = new System.Windows.Forms.Button();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.btnBackToMovies = new System.Windows.Forms.Button();
            this.flowMovies = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnWatchlist = new System.Windows.Forms.Button();
            this.btnFavorites = new System.Windows.Forms.Button();
            this.panelContent.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.panelMovieDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Ivory;
            this.panelContent.BackgroundImage = global::MovieReviewApp.Properties.Resources.User;
            this.panelContent.Controls.Add(this.panelProfile);
            this.panelContent.Controls.Add(this.panelMovieDetails);
            this.panelContent.Controls.Add(this.flowMovies);
            this.panelContent.Controls.Add(this.cmbGenre);
            this.panelContent.Controls.Add(this.lblGenre);
            this.panelContent.Controls.Add(this.btnSearch);
            this.panelContent.Controls.Add(this.txtSearch);
            this.panelContent.Controls.Add(this.lblSearch);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(157, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(897, 739);
            this.panelContent.TabIndex = 5;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.White;
            this.panelProfile.BackgroundImage = global::MovieReviewApp.Properties.Resources.logbg1;
            this.panelProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfile.Controls.Add(this.lblProfileRole);
            this.panelProfile.Controls.Add(this.lblProfileEmail);
            this.panelProfile.Controls.Add(this.lblProfileName);
            this.panelProfile.Controls.Add(this.lblProfileTitle);
            this.panelProfile.Location = new System.Drawing.Point(215, 136);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(466, 283);
            this.panelProfile.TabIndex = 7;
            this.panelProfile.Visible = false;
            // 
            // lblProfileRole
            // 
            this.lblProfileRole.AutoSize = true;
            this.lblProfileRole.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileRole.Location = new System.Drawing.Point(35, 200);
            this.lblProfileRole.Name = "lblProfileRole";
            this.lblProfileRole.Size = new System.Drawing.Size(68, 30);
            this.lblProfileRole.TabIndex = 3;
            this.lblProfileRole.Text = "Role: ";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileEmail.Location = new System.Drawing.Point(35, 155);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(77, 30);
            this.lblProfileEmail.TabIndex = 2;
            this.lblProfileEmail.Text = "Email: ";
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.Location = new System.Drawing.Point(35, 110);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(125, 30);
            this.lblProfileName.TabIndex = 1;
            this.lblProfileName.Text = "Full Name: ";
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.AutoSize = true;
            this.lblProfileTitle.Font = new System.Drawing.Font("Segoe UI Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileTitle.Location = new System.Drawing.Point(122, 23);
            this.lblProfileTitle.Name = "lblProfileTitle";
            this.lblProfileTitle.Size = new System.Drawing.Size(227, 54);
            this.lblProfileTitle.TabIndex = 0;
            this.lblProfileTitle.Text = "My Profile";
            // 
            // panelMovieDetails
            // 
            this.panelMovieDetails.BackgroundImage = global::MovieReviewApp.Properties.Resources.User;
            this.panelMovieDetails.Controls.Add(this.lblReviewCount);
            this.panelMovieDetails.Controls.Add(this.flowReviews);
            this.panelMovieDetails.Controls.Add(this.lblReviewsTitle);
            this.panelMovieDetails.Controls.Add(this.btnReview);
            this.panelMovieDetails.Controls.Add(this.lblDescription);
            this.panelMovieDetails.Controls.Add(this.lblDescriptiontitle);
            this.panelMovieDetails.Controls.Add(this.lblAverageRating);
            this.panelMovieDetails.Controls.Add(this.lblDirector);
            this.panelMovieDetails.Controls.Add(this.lblDetailYear);
            this.panelMovieDetails.Controls.Add(this.lblDetailGenre);
            this.panelMovieDetails.Controls.Add(this.lblDetailTitle);
            this.panelMovieDetails.Controls.Add(this.pictureBoxDetails);
            this.panelMovieDetails.Controls.Add(this.btnAddToWatchlist);
            this.panelMovieDetails.Controls.Add(this.btnFavorite);
            this.panelMovieDetails.Controls.Add(this.btnBackToMovies);
            this.panelMovieDetails.Location = new System.Drawing.Point(44, 110);
            this.panelMovieDetails.Name = "panelMovieDetails";
            this.panelMovieDetails.Size = new System.Drawing.Size(813, 601);
            this.panelMovieDetails.TabIndex = 6;
            this.panelMovieDetails.Visible = false;
            // 
            // lblReviewCount
            // 
            this.lblReviewCount.AutoSize = true;
            this.lblReviewCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblReviewCount.Location = new System.Drawing.Point(620, 155);
            this.lblReviewCount.Name = "lblReviewCount";
            this.lblReviewCount.Size = new System.Drawing.Size(140, 20);
            this.lblReviewCount.TabIndex = 20;
            this.lblReviewCount.Text = "Total Reviews: 0";
            // 
            // flowReviews
            // 
            this.flowReviews.AutoScroll = true;
            this.flowReviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowReviews.Location = new System.Drawing.Point(58, 390);
            this.flowReviews.Name = "flowReviews";
            this.flowReviews.Size = new System.Drawing.Size(686, 137);
            this.flowReviews.TabIndex = 19;
            this.flowReviews.WrapContents = false;
            // 
            // lblReviewsTitle
            // 
            this.lblReviewsTitle.AutoSize = true;
            this.lblReviewsTitle.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblReviewsTitle.Location = new System.Drawing.Point(57, 349);
            this.lblReviewsTitle.Name = "lblReviewsTitle";
            this.lblReviewsTitle.Size = new System.Drawing.Size(101, 26);
            this.lblReviewsTitle.TabIndex = 18;
            this.lblReviewsTitle.Text = "Reviews";
            // 
            // btnReview
            // 
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.btnReview.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReview.Location = new System.Drawing.Point(381, 332);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(183, 32);
            this.btnReview.TabIndex = 17;
            this.btnReview.Text = "Add a Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDescription.Location = new System.Drawing.Point(235, 205);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(502, 73);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "No description available.";
            // 
            // lblDescriptiontitle
            // 
            this.lblDescriptiontitle.AutoSize = true;
            this.lblDescriptiontitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDescriptiontitle.Location = new System.Drawing.Point(237, 179);
            this.lblDescriptiontitle.Name = "lblDescriptiontitle";
            this.lblDescriptiontitle.Size = new System.Drawing.Size(109, 25);
            this.lblDescriptiontitle.TabIndex = 15;
            this.lblDescriptiontitle.Text = "Description";
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAverageRating.Location = new System.Drawing.Point(235, 145);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(214, 28);
            this.lblAverageRating.TabIndex = 14;
            this.lblAverageRating.Text = "Average Rating: 0 / 5";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(233, 113);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(73, 20);
            this.lblDirector.TabIndex = 13;
            this.lblDirector.Text = "Director: ";
            // 
            // lblDetailYear
            // 
            this.lblDetailYear.AutoSize = true;
            this.lblDetailYear.Location = new System.Drawing.Point(233, 83);
            this.lblDetailYear.Name = "lblDetailYear";
            this.lblDetailYear.Size = new System.Drawing.Size(114, 20);
            this.lblDetailYear.TabIndex = 12;
            this.lblDetailYear.Text = "Release Year: ";
            // 
            // lblDetailGenre
            // 
            this.lblDetailGenre.AutoSize = true;
            this.lblDetailGenre.Location = new System.Drawing.Point(233, 53);
            this.lblDetailGenre.Name = "lblDetailGenre";
            this.lblDetailGenre.Size = new System.Drawing.Size(62, 20);
            this.lblDetailGenre.TabIndex = 11;
            this.lblDetailGenre.Text = "Genre: ";
            // 
            // lblDetailTitle
            // 
            this.lblDetailTitle.AutoSize = true;
            this.lblDetailTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDetailTitle.Location = new System.Drawing.Point(228, 16);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(165, 38);
            this.lblDetailTitle.TabIndex = 10;
            this.lblDetailTitle.Text = "Movie Title";
            // 
            // pictureBoxDetails
            // 
            this.pictureBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDetails.Location = new System.Drawing.Point(24, 25);
            this.pictureBoxDetails.Name = "pictureBoxDetails";
            this.pictureBoxDetails.Size = new System.Drawing.Size(185, 260);
            this.pictureBoxDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDetails.TabIndex = 9;
            this.pictureBoxDetails.TabStop = false;
            this.pictureBoxDetails.Click += new System.EventHandler(this.pictureBoxDetails_Click);
            // 
            // btnAddToWatchlist
            // 
            this.btnAddToWatchlist.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddToWatchlist.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnAddToWatchlist.Location = new System.Drawing.Point(473, 282);
            this.btnAddToWatchlist.Name = "btnAddToWatchlist";
            this.btnAddToWatchlist.Size = new System.Drawing.Size(173, 35);
            this.btnAddToWatchlist.TabIndex = 8;
            this.btnAddToWatchlist.Text = "Add to Watchlist ➕";
            this.btnAddToWatchlist.UseVisualStyleBackColor = true;
            this.btnAddToWatchlist.Click += new System.EventHandler(this.btnAddToWatchlist_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnFavorite.ForeColor = System.Drawing.Color.Firebrick;
            this.btnFavorite.Location = new System.Drawing.Point(252, 282);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(165, 35);
            this.btnFavorite.TabIndex = 7;
            this.btnFavorite.Text = "Add to Favorite ❤️";
            this.btnFavorite.UseVisualStyleBackColor = true;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnBackToMovies
            // 
            this.btnBackToMovies.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnBackToMovies.Location = new System.Drawing.Point(634, 10);
            this.btnBackToMovies.Name = "btnBackToMovies";
            this.btnBackToMovies.Size = new System.Drawing.Size(153, 40);
            this.btnBackToMovies.TabIndex = 6;
            this.btnBackToMovies.Text = "◀ Back to Movies";
            this.btnBackToMovies.UseVisualStyleBackColor = true;
            this.btnBackToMovies.Click += new System.EventHandler(this.btnBackToMovies_Click_1);
            // 
            // flowMovies
            // 
            this.flowMovies.AutoScroll = true;
            this.flowMovies.Location = new System.Drawing.Point(45, 115);
            this.flowMovies.Name = "flowMovies";
            this.flowMovies.Size = new System.Drawing.Size(813, 562);
            this.flowMovies.TabIndex = 5;
            // 
            // cmbGenre
            // 
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cmbGenre.Location = new System.Drawing.Point(281, 65);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(180, 33);
            this.cmbGenre.TabIndex = 4;
            this.cmbGenre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(138, 66);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(132, 25);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre             :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(479, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(279, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 31);
            this.txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(138, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(132, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search Movie :";
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Ivory;
            this.panelSidebar.BackgroundImage = global::MovieReviewApp.Properties.Resources.User;
            this.panelSidebar.Controls.Add(this.pnlDivider);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.btnWatchlist);
            this.panelSidebar.Controls.Add(this.btnFavorites);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(157, 739);
            this.panelSidebar.TabIndex = 4;
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlDivider.Location = new System.Drawing.Point(156, 0);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(1, 739);
            this.pnlDivider.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(17, 676);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(115, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnProfile.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btnProfile.Location = new System.Drawing.Point(11, 231);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(129, 44);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Location = new System.Drawing.Point(11, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(129, 51);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnWatchlist
            // 
            this.btnWatchlist.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnWatchlist.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnWatchlist.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnWatchlist.Location = new System.Drawing.Point(11, 162);
            this.btnWatchlist.Name = "btnWatchlist";
            this.btnWatchlist.Size = new System.Drawing.Size(129, 46);
            this.btnWatchlist.TabIndex = 1;
            this.btnWatchlist.Text = "Watchlist";
            this.btnWatchlist.UseVisualStyleBackColor = false;
            this.btnWatchlist.Click += new System.EventHandler(this.btnWatchlist_Click);
            // 
            // btnFavorites
            // 
            this.btnFavorites.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFavorites.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFavorites.ForeColor = System.Drawing.Color.Firebrick;
            this.btnFavorites.Location = new System.Drawing.Point(11, 94);
            this.btnFavorites.Name = "btnFavorites";
            this.btnFavorites.Size = new System.Drawing.Size(129, 48);
            this.btnFavorites.TabIndex = 1;
            this.btnFavorites.Text = "Favorites";
            this.btnFavorites.UseVisualStyleBackColor = false;
            this.btnFavorites.Click += new System.EventHandler(this.btnFavorites_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 739);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Name = "HomeForm";
            this.Text = "Cineverse";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.panelMovieDetails.ResumeLayout(false);
            this.panelMovieDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetails)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // =====================================================
        // SIDEBAR
        // =====================================================

        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel pnlDivider;

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnWatchlist;
        private System.Windows.Forms.Button btnFavorites;

        // =====================================================
        // MAIN CONTENT
        // =====================================================

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.FlowLayoutPanel flowMovies;

        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblGenre;

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;

        // =====================================================
        // MOVIE DETAILS
        // =====================================================

        private System.Windows.Forms.Panel panelMovieDetails;

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDescriptiontitle;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDetailYear;
        private System.Windows.Forms.Label lblDetailGenre;
        private System.Windows.Forms.Label lblDetailTitle;

        private System.Windows.Forms.PictureBox pictureBoxDetails;

        private System.Windows.Forms.Button btnAddToWatchlist;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Button btnBackToMovies;

        // =====================================================
        // REVIEW SECTION
        // =====================================================

        private System.Windows.Forms.Button btnReview;
        private System.Windows.Forms.Label lblReviewsTitle;
        private System.Windows.Forms.FlowLayoutPanel flowReviews;
        private System.Windows.Forms.Label lblReviewCount;

        // =====================================================
        // PROFILE
        // =====================================================

        private System.Windows.Forms.Panel panelProfile;

        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfileRole;
    }
}