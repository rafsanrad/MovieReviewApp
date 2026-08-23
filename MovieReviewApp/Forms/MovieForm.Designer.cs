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
            this.flowlpReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblReviewRating = new System.Windows.Forms.Label();
            this.lblReviewComment = new System.Windows.Forms.Label();
            this.lblReviewDate = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.flowlpReviews.SuspendLayout();
            this.pnlReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlMovieInfo);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1054, 826);
            this.pnlMain.TabIndex = 0;
            // 
            // btnWriteReview
            // 
            this.btnWriteReview.Location = new System.Drawing.Point(803, 428);
            this.btnWriteReview.Name = "btnWriteReview";
            this.btnWriteReview.Size = new System.Drawing.Size(128, 36);
            this.btnWriteReview.TabIndex = 4;
            this.btnWriteReview.Text = "WriteReview";
            this.btnWriteReview.UseVisualStyleBackColor = true;
            // 
            // lblReviews
            // 
            this.lblReviews.AutoSize = true;
            this.lblReviews.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.Location = new System.Drawing.Point(40, 347);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(101, 26);
            this.lblReviews.TabIndex = 0;
            this.lblReviews.Text = "Reviews";
            // 
            // pnlMovieInfo
            // 
            this.pnlMovieInfo.Controls.Add(this.flowlpReviews);
            this.pnlMovieInfo.Controls.Add(this.btnAddToWatchList);
            this.pnlMovieInfo.Controls.Add(this.btnWriteReview);
            this.pnlMovieInfo.Controls.Add(this.btnAddToFavourites);
            this.pnlMovieInfo.Controls.Add(this.lblReviews);
            this.pnlMovieInfo.Controls.Add(this.lblDescription);
            this.pnlMovieInfo.Controls.Add(this.lblDescriptiontitle);
            this.pnlMovieInfo.Controls.Add(this.lblReview);
            this.pnlMovieInfo.Controls.Add(this.lblDirector);
            this.pnlMovieInfo.Controls.Add(this.lblReleaseYear);
            this.pnlMovieInfo.Controls.Add(this.lblGenre);
            this.pnlMovieInfo.Controls.Add(this.lblTitle);
            this.pnlMovieInfo.Controls.Add(this.picPoster);
            this.pnlMovieInfo.Location = new System.Drawing.Point(119, 55);
            this.pnlMovieInfo.MinimumSize = new System.Drawing.Size(0, 380);
            this.pnlMovieInfo.Name = "pnlMovieInfo";
            this.pnlMovieInfo.Size = new System.Drawing.Size(800, 552);
            this.pnlMovieInfo.TabIndex = 1;
            // 
            // btnAddToWatchList
            // 
            this.btnAddToWatchList.Location = new System.Drawing.Point(447, 292);
            this.btnAddToWatchList.Name = "btnAddToWatchList";
            this.btnAddToWatchList.Size = new System.Drawing.Size(165, 35);
            this.btnAddToWatchList.TabIndex = 2;
            this.btnAddToWatchList.Text = "➕Add to WatchList";
            this.btnAddToWatchList.UseVisualStyleBackColor = true;
            // 
            // btnAddToFavourites
            // 
            this.btnAddToFavourites.Location = new System.Drawing.Point(256, 292);
            this.btnAddToFavourites.Name = "btnAddToFavourites";
            this.btnAddToFavourites.Size = new System.Drawing.Size(165, 35);
            this.btnAddToFavourites.TabIndex = 2;
            this.btnAddToFavourites.Text = "❤️Add To Favourites";
            this.btnAddToFavourites.UseVisualStyleBackColor = true;
            this.btnAddToFavourites.Click += new System.EventHandler(this.btnAddToFavourites_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(225, 209);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(502, 73);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Earth\'s mightiest heroes must come together and learn to fight as a team if they " +
    "are going to stop the mischievous Loki and his alien army from enslaving humanit" +
    "y.";
            // 
            // lblDescriptiontitle
            // 
            this.lblDescriptiontitle.AutoSize = true;
            this.lblDescriptiontitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriptiontitle.Location = new System.Drawing.Point(227, 183);
            this.lblDescriptiontitle.Name = "lblDescriptiontitle";
            this.lblDescriptiontitle.Size = new System.Drawing.Size(110, 21);
            this.lblDescriptiontitle.TabIndex = 6;
            this.lblDescriptiontitle.Text = "Description";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(225, 149);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(69, 24);
            this.lblReview.TabIndex = 5;
            this.lblReview.Text = "⭐4.8/5";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirector.Location = new System.Drawing.Point(223, 117);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(202, 21);
            this.lblDirector.TabIndex = 4;
            this.lblDirector.Text = "Director: Joss Whendon";
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.Location = new System.Drawing.Point(223, 87);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(162, 21);
            this.lblReleaseYear.TabIndex = 3;
            this.lblReleaseYear.Text = "ReleaseYear: 2012";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(223, 57);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(116, 21);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Genre: Sci-Fi";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(218, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "The Avengers";
            // 
            // picPoster
            // 
            this.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPoster.Location = new System.Drawing.Point(14, 17);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(185, 260);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 0;
            this.picPoster.TabStop = false;
            // 
            // flowlpReviews
            // 
            this.flowlpReviews.AutoScroll = true;
            this.flowlpReviews.Controls.Add(this.pnlReview);
            this.flowlpReviews.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowlpReviews.Location = new System.Drawing.Point(41, 388);
            this.flowlpReviews.Name = "flowlpReviews";
            this.flowlpReviews.Size = new System.Drawing.Size(686, 137);
            this.flowlpReviews.TabIndex = 1;
            this.flowlpReviews.WrapContents = false;
            // 
            // pnlReview
            // 
            this.pnlReview.Controls.Add(this.lblReviewDate);
            this.pnlReview.Controls.Add(this.lblReviewComment);
            this.pnlReview.Controls.Add(this.lblReviewRating);
            this.pnlReview.Controls.Add(this.lblName);
            this.pnlReview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReview.Location = new System.Drawing.Point(75, 25);
            this.pnlReview.Margin = new System.Windows.Forms.Padding(75, 25, 3, 3);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(542, 74);
            this.pnlReview.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(21, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 21);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tamim";
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
            // lblReviewComment
            // 
            this.lblReviewComment.Location = new System.Drawing.Point(20, 38);
            this.lblReviewComment.Name = "lblReviewComment";
            this.lblReviewComment.Size = new System.Drawing.Size(252, 22);
            this.lblReviewComment.TabIndex = 2;
            this.lblReviewComment.Text = "Amazing movie! Reallly Enjoyed it.";
            // 
            // lblReviewDate
            // 
            this.lblReviewDate.Location = new System.Drawing.Point(20, 80);
            this.lblReviewDate.Name = "lblReviewDate";
            this.lblReviewDate.Size = new System.Drawing.Size(180, 25);
            this.lblReviewDate.TabIndex = 3;
            this.lblReviewDate.Text = "22 August 2026";
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 826);
            this.Controls.Add(this.pnlMain);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieDetails";
            this.pnlMain.ResumeLayout(false);
            this.pnlMovieInfo.ResumeLayout(false);
            this.pnlMovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.flowlpReviews.ResumeLayout(false);
            this.pnlReview.ResumeLayout(false);
            this.pnlReview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMovieInfo;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescriptiontitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnAddToWatchList;
        private System.Windows.Forms.Button btnAddToFavourites;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.Button btnWriteReview;
        private System.Windows.Forms.FlowLayoutPanel flowlpReviews;
        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Label lblReviewDate;
        private System.Windows.Forms.Label lblReviewComment;
        private System.Windows.Forms.Label lblReviewRating;
        private System.Windows.Forms.Label lblName;
    }
}