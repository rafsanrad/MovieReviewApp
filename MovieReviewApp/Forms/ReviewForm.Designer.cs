namespace MovieReviewApp.Forms
{
    partial class ReviewForm
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
            this.pnlReview = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtReviewComment = new System.Windows.Forms.TextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblMovie = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblReview = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReview
            // 
            this.pnlReview.Controls.Add(this.btnCancel);
            this.pnlReview.Controls.Add(this.btnSubmit);
            this.pnlReview.Controls.Add(this.txtReviewComment);
            this.pnlReview.Controls.Add(this.cmbRating);
            this.pnlReview.Controls.Add(this.lblMovieName);
            this.pnlReview.Controls.Add(this.lblMovie);
            this.pnlReview.Controls.Add(this.lblRating);
            this.pnlReview.Controls.Add(this.lblReview);
            this.pnlReview.Controls.Add(this.lblSubTitle);
            this.pnlReview.Controls.Add(this.lblTitle);
            this.pnlReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReview.Location = new System.Drawing.Point(0, 0);
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(578, 444);
            this.pnlReview.TabIndex = 0;
            this.pnlReview.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlReview_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(310, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(70, 387);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(220, 45);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "SUBMIT REVIEW";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // txtReviewComment
            // 
            this.txtReviewComment.Location = new System.Drawing.Point(70, 250);
            this.txtReviewComment.Multiline = true;
            this.txtReviewComment.Name = "txtReviewComment";
            this.txtReviewComment.Size = new System.Drawing.Size(460, 110);
            this.txtReviewComment.TabIndex = 6;
            // 
            // cmbRating
            // 
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "1⭐",
            "2⭐⭐",
            "3⭐⭐⭐",
            "4⭐⭐⭐⭐",
            "5⭐⭐⭐⭐⭐"});
            this.cmbRating.Location = new System.Drawing.Point(180, 162);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(121, 28);
            this.cmbRating.TabIndex = 5;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(180, 115);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(97, 24);
            this.lblMovieName.TabIndex = 4;
            this.lblMovieName.Text = "Inception";
            // 
            // lblMovie
            // 
            this.lblMovie.AutoSize = true;
            this.lblMovie.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovie.Location = new System.Drawing.Point(70, 115);
            this.lblMovie.Name = "lblMovie";
            this.lblMovie.Size = new System.Drawing.Size(104, 23);
            this.lblMovie.TabIndex = 1;
            this.lblMovie.Text = "Movie      :";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(70, 165);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(102, 23);
            this.lblRating.TabIndex = 2;
            this.lblRating.Text = "Rating     :";
            // 
            // lblReview
            // 
            this.lblReview.AutoSize = true;
            this.lblReview.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview.Location = new System.Drawing.Point(70, 215);
            this.lblReview.Name = "lblReview";
            this.lblReview.Size = new System.Drawing.Size(132, 23);
            this.lblReview.TabIndex = 3;
            this.lblReview.Text = "Your Review :";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(50, 67);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(500, 25);
            this.lblSubTitle.TabIndex = 1;
            this.lblSubTitle.Text = "Share your thoughts about this movie";
            this.lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(50, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Write a Review";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 444);
            this.Controls.Add(this.pnlReview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cineverse - Write Review";
            this.pnlReview.ResumeLayout(false);
            this.pnlReview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblReview;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.TextBox txtReviewComment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
    }
}