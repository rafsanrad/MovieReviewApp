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
        /// Required method for Designer support.
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
            this.panelMovieManagement = new System.Windows.Forms.Panel();
            this.btnEditNewMovie = new System.Windows.Forms.Button();
            this.btnAddNewmovies = new System.Windows.Forms.Button();
            this.dataGridMovies = new System.Windows.Forms.DataGridView();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.lblSearchMovie = new System.Windows.Forms.Label();
            this.lblMovieManagement = new System.Windows.Forms.Label();
            this.panelReviewManagement = new System.Windows.Forms.Panel();
            this.dataGridReviews = new System.Windows.Forms.DataGridView();
            this.btnSearchReview = new System.Windows.Forms.Button();
            this.txtSearchReview = new System.Windows.Forms.TextBox();
            this.lblSearchReview = new System.Windows.Forms.Label();
            this.lblReviewManagement = new System.Windows.Forms.Label();
            this.panelOverview = new System.Windows.Forms.Panel();
            this.panelQuickAction = new System.Windows.Forms.Panel();
            this.btnEditMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.lblQuickAction = new System.Windows.Forms.Label();
            this.panelReviewCard = new System.Windows.Forms.Panel();
            this.lblTotalReviews = new System.Windows.Forms.Label();
            this.lblReviewNumber = new System.Windows.Forms.Label();
            this.lblReviews = new System.Windows.Forms.Label();
            this.panelUserManagement = new System.Windows.Forms.Panel();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.lablUserManagement = new System.Windows.Forms.Label();
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
            this.panelMovieManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).BeginInit();
            this.panelReviewManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReviews)).BeginInit();
            this.panelOverview.SuspendLayout();
            this.panelQuickAction.SuspendLayout();
            this.panelReviewCard.SuspendLayout();
            this.panelUserManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
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
            this.panelSidebar.Size = new System.Drawing.Size(263, 701);
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
            this.btnReviews.Click += new System.EventHandler(this.btnReviews_Click);
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
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
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
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
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
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
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
            this.lblAdminPanel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAdminPanel.Location = new System.Drawing.Point(330, 8);
            this.lblAdminPanel.Name = "lblAdminPanel";
            this.lblAdminPanel.Size = new System.Drawing.Size(264, 104);
            this.lblAdminPanel.TabIndex = 6;
            this.lblAdminPanel.Text = "        🧑‍💻\r\nAdmin Panel";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.Control;
            this.panelContent.BackgroundImage = global::MovieReviewApp.Properties.Resources.rsz_office_coffee_interior_design;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelContent.Controls.Add(this.panelUserManagement);
            this.panelContent.Controls.Add(this.panelReviewManagement);
            this.panelContent.Controls.Add(this.panelMovieManagement);
            this.panelContent.Controls.Add(this.panelOverview);
            this.panelContent.Controls.Add(this.lblAdminPanel);
            this.panelContent.Controls.Add(this.panelDivider);
            this.panelContent.Location = new System.Drawing.Point(170, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(884, 700);
            this.panelContent.TabIndex = 7;
            // 
            // panelMovieManagement
            // 
            this.panelMovieManagement.Controls.Add(this.btnEditNewMovie);
            this.panelMovieManagement.Controls.Add(this.btnAddNewmovies);
            this.panelMovieManagement.Controls.Add(this.dataGridMovies);
            this.panelMovieManagement.Controls.Add(this.btnSearchMovie);
            this.panelMovieManagement.Controls.Add(this.txtSearchMovie);
            this.panelMovieManagement.Controls.Add(this.lblSearchMovie);
            this.panelMovieManagement.Controls.Add(this.lblMovieManagement);
            this.panelMovieManagement.Location = new System.Drawing.Point(33, 115);
            this.panelMovieManagement.Name = "panelMovieManagement";
            this.panelMovieManagement.Size = new System.Drawing.Size(826, 561);
            this.panelMovieManagement.TabIndex = 8;
            this.panelMovieManagement.Visible = false;
            // 
            // btnEditNewMovie
            // 
            this.btnEditNewMovie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNewMovie.ForeColor = System.Drawing.Color.Crimson;
            this.btnEditNewMovie.Location = new System.Drawing.Point(431, 512);
            this.btnEditNewMovie.Name = "btnEditNewMovie";
            this.btnEditNewMovie.Size = new System.Drawing.Size(170, 39);
            this.btnEditNewMovie.TabIndex = 6;
            this.btnEditNewMovie.Text = "✍️ Edit Movie";
            this.btnEditNewMovie.UseVisualStyleBackColor = true;
            this.btnEditNewMovie.Click += new System.EventHandler(this.btnEditNewMovie_Click);
            // 
            // btnAddNewmovies
            // 
            this.btnAddNewmovies.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewmovies.ForeColor = System.Drawing.Color.Teal;
            this.btnAddNewmovies.Location = new System.Drawing.Point(193, 512);
            this.btnAddNewmovies.Name = "btnAddNewmovies";
            this.btnAddNewmovies.Size = new System.Drawing.Size(170, 39);
            this.btnAddNewmovies.TabIndex = 5;
            this.btnAddNewmovies.Text = "➕Add Movie";
            this.btnAddNewmovies.UseVisualStyleBackColor = true;
            this.btnAddNewmovies.Click += new System.EventHandler(this.btnAddNewmovies_Click);
            // 
            // dataGridMovies
            // 
            this.dataGridMovies.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovies.Location = new System.Drawing.Point(32, 135);
            this.dataGridMovies.Name = "dataGridMovies";
            this.dataGridMovies.RowHeadersWidth = 62;
            this.dataGridMovies.RowTemplate.Height = 28;
            this.dataGridMovies.Size = new System.Drawing.Size(762, 361);
            this.dataGridMovies.TabIndex = 4;
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMovie.Location = new System.Drawing.Point(635, 73);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(82, 34);
            this.btnSearchMovie.TabIndex = 3;
            this.btnSearchMovie.Text = "Search";
            this.btnSearchMovie.UseVisualStyleBackColor = true;
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Location = new System.Drawing.Point(205, 76);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(405, 29);
            this.txtSearchMovie.TabIndex = 2;
            // 
            // lblSearchMovie
            // 
            this.lblSearchMovie.AutoSize = true;
            this.lblSearchMovie.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchMovie.Location = new System.Drawing.Point(43, 76);
            this.lblSearchMovie.Name = "lblSearchMovie";
            this.lblSearchMovie.Size = new System.Drawing.Size(151, 28);
            this.lblSearchMovie.TabIndex = 1;
            this.lblSearchMovie.Text = "Search Movie :";
            // 
            // lblMovieManagement
            // 
            this.lblMovieManagement.AutoSize = true;
            this.lblMovieManagement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieManagement.ForeColor = System.Drawing.Color.Firebrick;
            this.lblMovieManagement.Location = new System.Drawing.Point(198, 15);
            this.lblMovieManagement.Name = "lblMovieManagement";
            this.lblMovieManagement.Size = new System.Drawing.Size(408, 48);
            this.lblMovieManagement.TabIndex = 0;
            this.lblMovieManagement.Text = "🎬Movie Management";
            // 
            // panelReviewManagement
            // 
            this.panelReviewManagement.Controls.Add(this.dataGridReviews);
            this.panelReviewManagement.Controls.Add(this.btnSearchReview);
            this.panelReviewManagement.Controls.Add(this.txtSearchReview);
            this.panelReviewManagement.Controls.Add(this.lblSearchReview);
            this.panelReviewManagement.Controls.Add(this.lblReviewManagement);
            this.panelReviewManagement.Location = new System.Drawing.Point(33, 115);
            this.panelReviewManagement.Name = "panelReviewManagement";
            this.panelReviewManagement.Size = new System.Drawing.Size(826, 561);
            this.panelReviewManagement.TabIndex = 10;
            this.panelReviewManagement.Visible = false;
            this.panelReviewManagement.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReviewManagement_Paint);
            // 
            // dataGridReviews
            // 
            this.dataGridReviews.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReviews.Location = new System.Drawing.Point(48, 170);
            this.dataGridReviews.Name = "dataGridReviews";
            this.dataGridReviews.RowHeadersWidth = 62;
            this.dataGridReviews.RowTemplate.Height = 28;
            this.dataGridReviews.Size = new System.Drawing.Size(762, 361);
            this.dataGridReviews.TabIndex = 9;
            // 
            // btnSearchReview
            // 
            this.btnSearchReview.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReview.Location = new System.Drawing.Point(635, 98);
            this.btnSearchReview.Name = "btnSearchReview";
            this.btnSearchReview.Size = new System.Drawing.Size(82, 34);
            this.btnSearchReview.TabIndex = 8;
            this.btnSearchReview.Text = "Search";
            this.btnSearchReview.UseVisualStyleBackColor = true;
            this.btnSearchReview.Click += new System.EventHandler(this.btnSearchReview_Click);
            // 
            // txtSearchReview
            // 
            this.txtSearchReview.Location = new System.Drawing.Point(205, 101);
            this.txtSearchReview.Name = "txtSearchReview";
            this.txtSearchReview.Size = new System.Drawing.Size(405, 29);
            this.txtSearchReview.TabIndex = 7;
            // 
            // lblSearchReview
            // 
            this.lblSearchReview.AutoSize = true;
            this.lblSearchReview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchReview.Location = new System.Drawing.Point(43, 101);
            this.lblSearchReview.Name = "lblSearchReview";
            this.lblSearchReview.Size = new System.Drawing.Size(160, 28);
            this.lblSearchReview.TabIndex = 6;
            this.lblSearchReview.Text = "Search Review :";
            // 
            // lblReviewManagement
            // 
            this.lblReviewManagement.AutoSize = true;
            this.lblReviewManagement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewManagement.ForeColor = System.Drawing.Color.Chocolate;
            this.lblReviewManagement.Location = new System.Drawing.Point(191, 40);
            this.lblReviewManagement.Name = "lblReviewManagement";
            this.lblReviewManagement.Size = new System.Drawing.Size(423, 48);
            this.lblReviewManagement.TabIndex = 5;
            this.lblReviewManagement.Text = "📝Review Management";
            // 
            // panelOverview
            // 
            this.panelOverview.Controls.Add(this.panelQuickAction);
            this.panelOverview.Controls.Add(this.panelReviewCard);
            this.panelOverview.Controls.Add(this.panelUserCard);
            this.panelOverview.Controls.Add(this.panelMovieCard);
            this.panelOverview.Location = new System.Drawing.Point(33, 115);
            this.panelOverview.Name = "panelOverview";
            this.panelOverview.Size = new System.Drawing.Size(826, 561);
            this.panelOverview.TabIndex = 8;
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
            this.btnEditMovie.Click += new System.EventHandler(this.btnEditMovie_Click);
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
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
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
            this.lblTotalReviews.Size = new System.Drawing.Size(155, 30);
            this.lblTotalReviews.TabIndex = 8;
            this.lblTotalReviews.Text = "Total Reviews";
            // 
            // lblReviewNumber
            // 
            this.lblReviewNumber.AutoSize = true;
            this.lblReviewNumber.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewNumber.Location = new System.Drawing.Point(64, 95);
            this.lblReviewNumber.Name = "lblReviewNumber";
            this.lblReviewNumber.Size = new System.Drawing.Size(33, 38);
            this.lblReviewNumber.TabIndex = 7;
            this.lblReviewNumber.Text = "0";
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
            // panelUserManagement
            // 
            this.panelUserManagement.Controls.Add(this.dataGridUsers);
            this.panelUserManagement.Controls.Add(this.btnSearchUser);
            this.panelUserManagement.Controls.Add(this.txtSearchUser);
            this.panelUserManagement.Controls.Add(this.lblSearchUser);
            this.panelUserManagement.Controls.Add(this.lablUserManagement);
            this.panelUserManagement.Location = new System.Drawing.Point(33, 115);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(826, 561);
            this.panelUserManagement.TabIndex = 9;
            this.panelUserManagement.Visible = false;
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Location = new System.Drawing.Point(32, 135);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersWidth = 62;
            this.dataGridUsers.RowTemplate.Height = 28;
            this.dataGridUsers.Size = new System.Drawing.Size(762, 361);
            this.dataGridUsers.TabIndex = 4;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(635, 73);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(82, 34);
            this.btnSearchUser.TabIndex = 3;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(205, 76);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(405, 29);
            this.txtSearchUser.TabIndex = 2;
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchUser.Location = new System.Drawing.Point(43, 76);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(134, 28);
            this.lblSearchUser.TabIndex = 1;
            this.lblSearchUser.Text = "Search User :";
            // 
            // lablUserManagement
            // 
            this.lablUserManagement.AutoSize = true;
            this.lablUserManagement.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablUserManagement.ForeColor = System.Drawing.Color.ForestGreen;
            this.lablUserManagement.Location = new System.Drawing.Point(226, 15);
            this.lablUserManagement.Name = "lablUserManagement";
            this.lablUserManagement.Size = new System.Drawing.Size(378, 48);
            this.lablUserManagement.TabIndex = 0;
            this.lablUserManagement.Text = "👤User Management";
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
            this.lblTotalUsers.Size = new System.Drawing.Size(129, 30);
            this.lblTotalUsers.TabIndex = 5;
            this.lblTotalUsers.Text = "Total Users";
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.AutoSize = true;
            this.lblUserNumber.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNumber.Location = new System.Drawing.Point(67, 93);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(33, 38);
            this.lblUserNumber.TabIndex = 4;
            this.lblUserNumber.Text = "0";
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
            this.lblMovieNumber.Size = new System.Drawing.Size(33, 38);
            this.lblMovieNumber.TabIndex = 1;
            this.lblMovieNumber.Text = "0";
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
            this.panelMovieManagement.ResumeLayout(false);
            this.panelMovieManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovies)).EndInit();
            this.panelReviewManagement.ResumeLayout(false);
            this.panelReviewManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReviews)).EndInit();
            this.panelOverview.ResumeLayout(false);
            this.panelQuickAction.ResumeLayout(false);
            this.panelQuickAction.PerformLayout();
            this.panelReviewCard.ResumeLayout(false);
            this.panelReviewCard.PerformLayout();
            this.panelUserManagement.ResumeLayout(false);
            this.panelUserManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.panelUserCard.ResumeLayout(false);
            this.panelUserCard.PerformLayout();
            this.panelMovieCard.ResumeLayout(false);
            this.panelMovieCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // =====================================================
        // SIDEBAR
        // =====================================================

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelDivider;

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnMovies;

        // =====================================================
        // CONTENT
        // =====================================================

        private System.Windows.Forms.Label lblAdminPanel;
        private System.Windows.Forms.Panel panelContent;

        // =====================================================
        // OVERVIEW
        // =====================================================

        private System.Windows.Forms.Panel panelOverview;

        private System.Windows.Forms.Panel panelQuickAction;

        private System.Windows.Forms.Button btnEditMovie;
        private System.Windows.Forms.Button btnAddMovie;

        private System.Windows.Forms.Label lblQuickAction;

        // =====================================================
        // MOVIE CARD
        // =====================================================

        private System.Windows.Forms.Panel panelMovieCard;

        private System.Windows.Forms.Label lblMovies;
        private System.Windows.Forms.Label lblMovieNumber;
        private System.Windows.Forms.Label lblTotalMovies;

        // =====================================================
        // USER CARD
        // =====================================================

        private System.Windows.Forms.Panel panelUserCard;

        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.Label lblTotalUsers;

        // =====================================================
        // REVIEW CARD
        // =====================================================

        private System.Windows.Forms.Panel panelReviewCard;

        private System.Windows.Forms.Label lblReviews;
        private System.Windows.Forms.Label lblReviewNumber;
        private System.Windows.Forms.Label lblTotalReviews;

        // =====================================================
        // MOVIE MANAGEMENT
        // =====================================================

        private System.Windows.Forms.Panel panelMovieManagement;

        private System.Windows.Forms.Label lblMovieManagement;
        private System.Windows.Forms.Label lblSearchMovie;

        private System.Windows.Forms.TextBox txtSearchMovie;

        private System.Windows.Forms.DataGridView dataGridMovies;

        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.Button btnEditNewMovie;
        private System.Windows.Forms.Button btnAddNewmovies;

        // =====================================================
        // USER MANAGEMENT
        // =====================================================

        private System.Windows.Forms.Panel panelUserManagement;

        private System.Windows.Forms.DataGridView dataGridUsers;

        private System.Windows.Forms.Button btnSearchUser;

        private System.Windows.Forms.TextBox txtSearchUser;

        private System.Windows.Forms.Label lblSearchUser;

        private System.Windows.Forms.Label lablUserManagement;

        // =====================================================
        // REVIEW MANAGEMENT
        // =====================================================

        private System.Windows.Forms.Panel panelReviewManagement;

        private System.Windows.Forms.DataGridView dataGridReviews;

        private System.Windows.Forms.Button btnSearchReview;

        private System.Windows.Forms.TextBox txtSearchReview;

        private System.Windows.Forms.Label lblSearchReview;

        private System.Windows.Forms.Label lblReviewManagement;
    }
}