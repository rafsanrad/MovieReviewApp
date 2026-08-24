namespace MovieReviewApp.Forms
{
    partial class AdminPanel
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.lblAdminPanel = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelOverView = new System.Windows.Forms.Panel();
            this.panelQuickAction = new System.Windows.Forms.Panel();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblQuickAction = new System.Windows.Forms.Label();
            this.panelReviewCard = new System.Windows.Forms.Panel();
            this.lblTotalReviews = new System.Windows.Forms.Label();
            this.lblReviewNumber = new System.Windows.Forms.Label();
            this.lblReviews = new System.Windows.Forms.Label();
            this.panelUserCard = new System.Windows.Forms.Panel();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.panelMovieCard = new System.Windows.Forms.Panel();
            this.lblTotalMovies = new System.Windows.Forms.Label();
            this.lblMovieNumber = new System.Windows.Forms.Label();
            this.lblMovies = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelOverView.SuspendLayout();
            this.panelQuickAction.SuspendLayout();
            this.panelReviewCard.SuspendLayout();
            this.panelUserCard.SuspendLayout();
            this.panelMovieCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnReviews);
            this.panelSidebar.Controls.Add(this.btnDashBoard);
            this.panelSidebar.Controls.Add(this.btnUsers);
            this.panelSidebar.Controls.Add(this.btnMovies);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(175, 701);
            this.panelSidebar.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Tomato;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(19, 605);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 52);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReviews
            // 
            this.btnReviews.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviews.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviews.ForeColor = System.Drawing.Color.Chocolate;
            this.btnReviews.Location = new System.Drawing.Point(9, 232);
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(155, 52);
            this.btnReviews.TabIndex = 2;
            this.btnReviews.Text = "📝Reviews";
            this.btnReviews.UseVisualStyleBackColor = false;
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDashBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDashBoard.Location = new System.Drawing.Point(9, 25);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(155, 52);
            this.btnDashBoard.TabIndex = 0;
            this.btnDashBoard.Text = "🏠 DashBoard";
            this.btnDashBoard.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnUsers.Location = new System.Drawing.Point(9, 163);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(155, 52);
            this.btnUsers.TabIndex = 1;
            this.btnUsers.Text = "👤Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.Color.Firebrick;
            this.btnMovies.Location = new System.Drawing.Point(9, 95);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(155, 52);
            this.btnMovies.TabIndex = 1;
            this.btnMovies.Text = "🎬 Movies";
            this.btnMovies.UseVisualStyleBackColor = false;
            // 
            // panelDivider
            // 
            this.panelDivider.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelDivider.Location = new System.Drawing.Point(1, 0);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(1, 700);
            this.panelDivider.TabIndex = 3;
            // 
            // lblAdminPanel
            // 
            this.lblAdminPanel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblAdminPanel.Location = new System.Drawing.Point(317, 8);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(221, 104);
            this.lblAdminPanel.TabIndex = 6;
            this.lblAdminPanel.Text = "        🧑‍💻\r\nAdmin Panel";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.panelOverView);
            this.panelContent.Controls.Add(this.lblAdminPanel);
            this.panelContent.Controls.Add(this.panelDivider);
            this.panelContent.Location = new System.Drawing.Point(170, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(884, 700);
            this.panelContent.TabIndex = 7;
            // 
            // panelOverView
            // 
            this.panelOverView.Controls.Add(this.panelQuickAction);
            this.panelOverView.Controls.Add(this.panelReviewCard);
            this.panelOverView.Controls.Add(this.panelUserCard);
            this.panelOverView.Controls.Add(this.panelMovieCard);
            this.panelOverView.Location = new System.Drawing.Point(33, 115);
            this.panelOverView.Name = "panelOverView";
            this.panelOverView.Size = new System.Drawing.Size(826, 561);
            this.panelOverView.TabIndex = 8;
            // 
            // panelQuickAction
            // 
            this.panelQuickAction.Controls.Add(this.btnEditMovie);
            this.panelQuickAction.Controls.Add(this.btnAddMovie);
            this.panelQuickAction.Controls.Add(this.lblQuickAction);
            this.panelQuickAction.Location = new System.Drawing.Point(207, 328);
            this.panelQuickAction.Name = "panelQuickAction";
            this.panelQuickAction.Size = new System.Drawing.Size(391, 176);
            this.panelQuickAction.TabIndex = 0;
            this.panelQuickAction.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuickAction_Paint);
            // 
            // btnEditMovie
            // 
            this.btnEditMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMovie.ForeColor = System.Drawing.Color.Crimson;
            this.btnEditMovie.Location = new System.Drawing.Point(202, 95);
            this.btnEditMovie.Name = "btnEditMovie";
            this.btnEditMovie.Size = new System.Drawing.Size(152, 40);
            this.btnEditMovie.TabIndex = 2;
            this.btnEditMovie.Text = "✍️ Edit Movie";
            this.btnEditMovie.UseVisualStyleBackColor = true;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Teal;
            this.btnAddMovie.Location = new System.Drawing.Point(27, 95);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(152, 40);
            this.btnAddMovie.TabIndex = 1;
            this.btnAddMovie.Text = "➕ Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            // 
            // lblQuickAction
            // 
            this.lblQuickAction.AutoSize = true;
            this.lblQuickAction.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickAction.Location = new System.Drawing.Point(102, 12);
            this.lblQuickAction.Name = "lblQuickAction";
            this.lblQuickAction.Size = new System.Drawing.Size(178, 38);
            this.lblQuickAction.TabIndex = 0;
            this.lblQuickAction.Text = "QuickAction";
            // 
            // panelReviewCard
            // 
            this.panelReviewCard.Controls.Add(this.lblTotalReviews);
            this.panelReviewCard.Controls.Add(this.lblReviewNumber);
            this.panelReviewCard.Controls.Add(this.lblReviews);
            this.panelReviewCard.Location = new System.Drawing.Point(576, 60);
            this.panelReviewCard.Name = "panelReviewCard";
            this.panelReviewCard.Size = new System.Drawing.Size(200, 211);
            this.panelReviewCard.TabIndex = 2;
            this.panelReviewCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReviewCard_Paint);
            // 
            // lblTotalReviews
            // 
            this.lblTotalReviews.AutoSize = true;
            this.lblTotalReviews.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalReviews.Location = new System.Drawing.Point(28, 150);
            this.lblTotalReviews.Name = "lblTotalReviews";
            this.lblTotalReviews.Size = new System.Drawing.Size(145, 30);
            this.lblTotalReviews.TabIndex = 8;
            this.lblTotalReviews.Text = "Total Movies";
            // 
            // lblReviewNumber
            // 
            this.lblReviewNumber.AutoSize = true;
            this.lblReviewNumber.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewNumber.Location = new System.Drawing.Point(64, 95);
            this.lblReviewNumber.Name = "lblReviewNumber";
            this.lblReviewNumber.Size = new System.Drawing.Size(49, 38);
            this.lblReviewNumber.TabIndex = 7;
            this.lblReviewNumber.Text = "16";
            this.lblReviewNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReviews
            // 
            this.lblReviews.AutoSize = true;
            this.lblReviews.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviews.ForeColor = System.Drawing.Color.Chocolate;
            this.lblReviews.Location = new System.Drawing.Point(44, 30);
            this.lblReviews.Name = "lblReviews";
            this.lblReviews.Size = new System.Drawing.Size(121, 38);
            this.lblReviews.TabIndex = 6;
            this.lblReviews.Text = "Reviews";
            this.lblReviews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelUserCard
            // 
            this.panelUserCard.Controls.Add(this.lblTotalUsers);
            this.panelUserCard.Controls.Add(this.lblUserNumber);
            this.panelUserCard.Controls.Add(this.lblUsers);
            this.panelUserCard.Location = new System.Drawing.Point(305, 60);
            this.panelUserCard.Name = "panelUserCard";
            this.panelUserCard.Size = new System.Drawing.Size(200, 211);
            this.panelUserCard.TabIndex = 1;
            this.panelUserCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserCard_Paint);
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalUsers.Location = new System.Drawing.Point(31, 148);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(145, 30);
            this.lblTotalUsers.TabIndex = 5;
            this.lblTotalUsers.Text = "Total Movies";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumber.Location = new System.Drawing.Point(67, 93);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(49, 38);
            this.lblUserNumber.TabIndex = 4;
            this.lblUserNumber.Text = "12";
            this.lblUserNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblUsers.Location = new System.Drawing.Point(57, 28);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(87, 38);
            this.lblUsers.TabIndex = 3;
            this.lblUsers.Text = "Users";
            this.lblUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMovieCard
            // 
            this.panelMovieCard.Controls.Add(this.lblTotalMovies);
            this.panelMovieCard.Controls.Add(this.lblMovieNumber);
            this.panelMovieCard.Controls.Add(this.lblMovies);
            this.panelMovieCard.Location = new System.Drawing.Point(42, 60);
            this.panelMovieCard.Name = "panelMovieCard";
            this.panelMovieCard.Size = new System.Drawing.Size(200, 211);
            this.panelMovieCard.TabIndex = 0;
            this.panelMovieCard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMovieCard_Paint);
            // 
            // lblTotalMovies
            // 
            this.lblTotalMovies.AutoSize = true;
            this.lblTotalMovies.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMovies.Location = new System.Drawing.Point(31, 148);
            this.lblTotalMovies.Name = "lblTotalMovies";
            this.lblTotalMovies.Size = new System.Drawing.Size(145, 30);
            this.lblTotalMovies.TabIndex = 2;
            this.lblTotalMovies.Text = "Total Movies";
            // 
            // lblMovieNumber
            // 
            this.lblMovieNumber.AutoSize = true;
            this.lblMovieNumber.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieNumber.Location = new System.Drawing.Point(67, 93);
            this.lblMovieNumber.Name = "lblMovieNumber";
            this.lblMovieNumber.Size = new System.Drawing.Size(65, 38);
            this.lblMovieNumber.TabIndex = 1;
            this.lblMovieNumber.Text = "100";
            this.lblMovieNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovies
            // 
            this.lblMovies.AutoSize = true;
            this.lblMovies.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovies.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMovies.Location = new System.Drawing.Point(48, 28);
            this.lblMovies.Name = "lblMovies";
            this.lblMovies.Size = new System.Drawing.Size(111, 38);
            this.lblMovies.TabIndex = 0;
            this.lblMovies.Text = "Movies";
            this.lblMovies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 701);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cineverse";
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelOverView.ResumeLayout(false);
            this.panelQuickAction.ResumeLayout(false);
            this.panelQuickAction.PerformLayout();
            this.panelReviewCard.ResumeLayout(false);
            this.panelReviewCard.PerformLayout();
            this.panelUserCard.ResumeLayout(false);
            this.panelUserCard.PerformLayout();
            this.panelMovieCard.ResumeLayout(false);
            this.panelMovieCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelDivider;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelOverView;
        private System.Windows.Forms.Panel panelQuickAction;
        private System.Windows.Forms.Panel panelReviewCard;
        private System.Windows.Forms.Panel panelUserCard;
        private System.Windows.Forms.Panel panelMovieCard;
        private System.Windows.Forms.Label lblMovieNumber;
        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblTotalMovies;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblTotalReviews;
        private System.Windows.Forms.Label lblReviewNumber;
        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Label lblQuickAction;
    }
}