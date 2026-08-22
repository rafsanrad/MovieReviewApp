namespace MovieReviewApp
{
    partial class MovieForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlReviews = new System.Windows.Forms.Panel();
            this.flowlpReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.lblReviewDate = new System.Windows.Forms.Label();
            this.lblReviewComment = new System.Windows.Forms.Label();
            this.lblReviewRating = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnWriteReview = new System.Windows.Forms.Button();
            this.lblReviews = new System.Windows.Forms.Label();
            this.pnlMovieInfo = new System.Windows.Forms.Panel();
            this.btnAddToWatchList = new System.Windows.Forms.Button();
            this.btnAddToFavourites = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDescriptiontitle = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnWatchList = new System.Windows.Forms.Button();
            this.btnFavourites = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlReviews.SuspendLayout();
            this.flowlpReviews.SuspendLayout();
            this.pnlReview.SuspendLayout();
            this.pnlMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlReviews);
            this.pnlMain.Controls.Add(this.pnlMovieInfo);
            this.pnlMain.Controls.Add(this.pnlNavBar);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1054, 739);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlReviews
            // 
            this.pnlReviews.Controls.Add(this.flowlpReviews);
            this.pnlReviews.Controls.Add(this.btnWriteReview);
            this.pnlReviews.Controls.Add(this.lblReviews);
            this.pnlReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReviews.Location = new System.Drawing.Point(0, 450);
            this.pnlReviews.Name = "pnlReviews";
            this.pnlReviews.Size = new System.Drawing.Size(1054, 289);
            this.pnlReviews.TabIndex = 2;
            // 
            // flowlpReviews
            // 
            this.flowlpReviews.AutoScroll = true;
            this.flowlpReviews.Controls.Add(this.pnlReview);
            this.flowlpReviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlpReviews.Location = new System.Drawing.Point(0, 57);
            this.flowlpReviews.Name = "flowlpReviews";
            this.flowlpReviews.Size = new System.Drawing.Size(1054, 232);
            this.flowlpReviews.TabIndex = 1;
            this.flowlpReviews.WrapContents = false;
            // 
            // pnlReview
            // 
            this.pnlReview.Controls.Add(this.lblReviewDate);
            this.pnlReview.Controls.Add(this.lblReviewComment);
            this.pnlReview.Controls.Add(this.lblReviewRating);
            this.pnlReview.Controls.Add(this.lblName);
            this.pnlReview.Location = new System.Drawing.Point(3, 3);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(1050, 109);
            this.pnlReview.TabIndex = 0;
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.Location = new System.Drawing.Point(20, 80);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(180, 25);
            this.lblReviewDate.TabIndex = 3;
            this.lblReviewDate.Text = "22 August 2026";
            // 
            // lblReviewComment
            // 
            this.lblReviewComment.Location = new System.Drawing.Point(20, 38);
            this.lblReviewComment.Name = "lblReviewComment";
            this.lblReviewComment.Size = new System.Drawing.Size(1002, 42);
            this.lblReviewComment.TabIndex = 2;
            this.lblReviewComment.Text = "Amazing movie! Reallly Enjoyed it.";
            // 
            // lblReviewRating
            // 
            this.lblReviewRating.Location = new System.Drawing.Point(95, 10);
            this.lblReviewRating.Name = "lblReviewRating";
            this.lblReviewRating.Size = new System.Drawing.Size(150, 25);
            this.lblReviewRating.TabIndex = 1;
            this.lblReviewRating.Text = "⭐⭐⭐⭐⭐⭐";
            this.lblReviewRating.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblReviewRating.Click += new System.EventHandler(this.lblReviewRating_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(20, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tamim";
            // 
            // btnWriteReview
            // 
            this.btnWriteReview.Location = new System.Drawing.Point(915, 10);
            this.btnWriteReview.Name = "btnWriteReview";
            this.btnWriteReview.Size = new System.Drawing.Size(128, 36);
            this.btnWriteReview.TabIndex = 4;
            this.btnWriteReview.Text = "WriteReview";
            this.btnWriteReview.UseVisualStyleBackColor = true;
            // 
            // lblReviews
            // 
            this.lblReviews.AutoSize = true;
            this.lblReviews.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.Location = new System.Drawing.Point(8, 15);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(108, 29);
            this.lblReviews.TabIndex = 0;
            this.lblReviews.Text = "Reviews";
            // 
            // pnlMovieInfo
            // 
            this.pnlMovieInfo.Controls.Add(this.btnAddToWatchList);
            this.pnlMovieInfo.Controls.Add(this.btnAddToFavourites);
            this.pnlMovieInfo.Controls.Add(this.lblDescription);
            this.pnlMovieInfo.Controls.Add(this.lblDescriptiontitle);
            this.pnlMovieInfo.Controls.Add(this.lblReview);
            this.pnlMovieInfo.Controls.Add(this.lblDirector);
            this.pnlMovieInfo.Controls.Add(this.lblReleaseYear);
            this.pnlMovieInfo.Controls.Add(this.lblGenre);
            this.pnlMovieInfo.Controls.Add(this.lblTitle);
            this.pnlMovieInfo.Controls.Add(this.picPoster);
            this.pnlMovieInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMovieInfo.Location = new System.Drawing.Point(0, 70);
            this.pnlMovieInfo.MinimumSize = new System.Drawing.Size(0, 380);
            this.pnlMovieInfo.Name = "pnlMovieInfo";
            this.pnlMovieInfo.Size = new System.Drawing.Size(1054, 380);
            this.pnlMovieInfo.TabIndex = 1;
            // 
            // btnAddToWatchList
            // 
            this.btnAddToWatchList.Location = new System.Drawing.Point(687, 320);
            this.btnAddToWatchList.Name = "btnAddToWatchList";
            this.btnAddToWatchList.Size = new System.Drawing.Size(165, 35);
            this.btnAddToWatchList.TabIndex = 2;
            this.btnAddToWatchList.Text = "➕Add to WatchList";
            this.btnAddToWatchList.UseVisualStyleBackColor = true;
            // 
            // btnAddToFavourites
            // 
            this.btnAddToFavourites.Location = new System.Drawing.Point(477, 320);
            this.btnAddToFavourites.Name = "btnAddToFavourites";
            this.btnAddToFavourites.Size = new System.Drawing.Size(165, 35);
            this.btnAddToFavourites.TabIndex = 2;
            this.btnAddToFavourites.Text = "❤️Add To Favourites";
            this.btnAddToFavourites.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(337, 258);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(705, 73);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Earth\'s mightiest heroes must come together and learn to fight as a team if they " +
    "are going to stop the mischievous Loki and his alien army from enslaving humanit" +
    "y.";
            // 
            // lblDescriptiontitle
            // 
            this.lblDescriptiontitle.AutoSize = true;
            this.lblDescriptiontitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptiontitle.Location = new System.Drawing.Point(337, 234);
            this.lblDescriptiontitle.Name = "lblDescriptiontitle";
            this.lblDescriptiontitle.Size = new System.Drawing.Size(110, 21);
            this.lblDescriptiontitle.TabIndex = 6;
            this.lblDescriptiontitle.Text = "Description";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(337, 188);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(83, 29);
            this.lblReview.TabIndex = 5;
            this.lblReview.Text = "⭐4.8/5";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(337, 149);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(202, 21);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director: Joss Whendon";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.Location = new System.Drawing.Point(337, 119);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(162, 21);
            this.lblReleaseYear.TabIndex = 3;
            this.lblReleaseYear.Text = "ReleaseYear: 2012";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(337, 89);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(116, 21);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre: Sci-Fi";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(330, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(337, 56);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "The Avengers";
            // 
            // picPoster
            // 
            this.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPoster.Location = new System.Drawing.Point(40, 25);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(250, 330);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.Controls.Add(this.btnLogout);
            this.pnlNavBar.Controls.Add(this.btnProfile);
            this.pnlNavBar.Controls.Add(this.btnWatchList);
            this.pnlNavBar.Controls.Add(this.btnFavourites);
            this.pnlNavBar.Controls.Add(this.btnHome);
            this.pnlNavBar.Controls.Add(this.lblLogo);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.MaximumSize = new System.Drawing.Size(0, 70);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(1054, 70);
            this.pnlNavBar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(955, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(90, 40);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(859, 15);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(90, 40);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnWatchList
            // 
            this.btnWatchList.Location = new System.Drawing.Point(737, 15);
            this.btnWatchList.Name = "btnWatchList";
            this.btnWatchList.Size = new System.Drawing.Size(115, 40);
            this.btnWatchList.TabIndex = 3;
            this.btnWatchList.Text = "WatchList";
            this.btnWatchList.UseVisualStyleBackColor = true;
            // 
            // btnFavourites
            // 
            this.btnFavourites.Location = new System.Drawing.Point(621, 15);
            this.btnFavourites.Name = "btnFavourites";
            this.btnFavourites.Size = new System.Drawing.Size(110, 40);
            this.btnFavourites.TabIndex = 2;
            this.btnFavourites.Text = "Favourites";
            this.btnFavourites.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(525, 15);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(90, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(11, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(231, 51);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Cineverse";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 739);
            this.Controls.Add(this.pnlMain);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieDetails";
            this.pnlMain.ResumeLayout(false);
            this.pnlReviews.ResumeLayout(false);
            this.pnlReviews.PerformLayout();
            this.flowlpReviews.ResumeLayout(false);
            this.pnlReview.ResumeLayout(false);
            this.pnlReview.PerformLayout();
            this.pnlMovieInfo.ResumeLayout(false);
            this.pnlMovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnWatchList;
        private System.Windows.Forms.Button btnFavourites;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMovieInfo;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescriptiontitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlReviews;
        private System.Windows.Forms.Button btnAddToWatchList;
        private System.Windows.Forms.Button btnAddToFavourites;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.FlowLayoutPanel flowlpReviews;
        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblReviewRating;
        private System.Windows.Forms.Label lblReviewDate;
        private System.Windows.Forms.Label lblReviewComment;
        private System.Windows.Forms.Button btnWriteReview;
    }
}