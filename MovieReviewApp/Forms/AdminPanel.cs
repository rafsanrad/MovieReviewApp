using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class AdminPanel : Form
    {
        // =====================================================
        // DATABASE
        // =====================================================

        private DatabaseHelper db = new DatabaseHelper();


        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public AdminPanel()
        {
            InitializeComponent();

            // Set all management panels to the same position
            SetPanelLocations();

            // Show dashboard when Admin Panel opens
            ShowOverviewPanel();

            // Load dashboard statistics
            LoadDashboardCounts();
        }


        // =====================================================
        // PANEL SETUP
        // =====================================================

        private void SetPanelLocations()
        {
            Point panelLocation = new Point(33, 115);

            panelOverview.Location = panelLocation;
            panelMovieManagement.Location = panelLocation;
            panelUserManagement.Location = panelLocation;
            panelReviewManagement.Location = panelLocation;
        }


        // =====================================================
        // PANEL NAVIGATION
        // =====================================================

        private void ShowPanel(Panel panel)
        {
            // Hide all panels first
            panelOverview.Visible = false;
            panelMovieManagement.Visible = false;
            panelUserManagement.Visible = false;
            panelReviewManagement.Visible = false;

            // Show selected panel
            panel.Visible = true;
            panel.BringToFront();
        }


        private void ShowOverviewPanel()
        {
            ShowPanel(panelOverview);
        }


        private void ShowMovieManagementPanel()
        {
            ShowPanel(panelMovieManagement);
            LoadMovies();
        }


        private void ShowUserManagementPanel()
        {
            ShowPanel(panelUserManagement);
            LoadUsers();
        }


        private void ShowReviewManagementPanel()
        {
            ShowPanel(panelReviewManagement);
            LoadReviews();
        }


        // =====================================================
        // DASHBOARD STATISTICS
        // =====================================================

        private void LoadDashboardCounts()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Total Movies
                    string movieQuery =
                        "SELECT COUNT(*) FROM Movies";

                    using (SqlCommand command =
                           new SqlCommand(movieQuery, connection))
                    {
                        lblMovieNumber.Text =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            ).ToString();
                    }


                    // Total Users (excluding Admin)
                    string userQuery =
                        "SELECT COUNT(*) FROM Users WHERE Role <> 'Admin'";

                    using (SqlCommand command =
                           new SqlCommand(userQuery, connection))
                    {
                        lblUserNumber.Text =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            ).ToString();
                    }


                    // Total Reviews
                    string reviewQuery =
                        "SELECT COUNT(*) FROM Reviews";

                    using (SqlCommand command =
                           new SqlCommand(reviewQuery, connection))
                    {
                        lblReviewNumber.Text =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            ).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load dashboard statistics.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // COMMON DATAGRIDVIEW SETUP
        // =====================================================

        private void ConfigureGrid(DataGridView grid)
        {
            // Basic grid settings
            grid.Size = new Size(726, 361);
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;

            // Appearance
            grid.BackgroundColor = Color.White;
            grid.GridColor = Color.LightGray;
            grid.BorderStyle = BorderStyle.FixedSingle;

            // Scrolling
            grid.ScrollBars = ScrollBars.Vertical;

            // Row settings
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 32;

            // Selection
            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grid.MultiSelect = false;

            // Automatically create columns from DataTable
            grid.AutoGenerateColumns = true;

            // Header
            grid.ColumnHeadersVisible = true;
            grid.ColumnHeadersHeight = 35;

            grid.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Column width
            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // Default cell alignment
            foreach (DataGridViewColumn column in grid.Columns)
            {
                column.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }
        }


        // =====================================================
        // COMMON DELETE BUTTON
        // =====================================================

        private void AddDeleteButton(DataGridView grid)
        {
            // Prevent duplicate Delete columns
            if (grid.Columns["Delete"] != null)
                return;

            DataGridViewButtonColumn deleteButton =
                new DataGridViewButtonColumn();

            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "Action";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;

            grid.Columns.Add(deleteButton);

            grid.Columns["Delete"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }


        // =====================================================
        // MOVIE MANAGEMENT
        // =====================================================

        private void LoadMovies()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            MovieId,
                            Title,
                            Genre,
                            Director,
                            ReleaseYear
                        FROM Movies
                        ORDER BY MovieId DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridMovies.DataSource = table;
                    }
                }

                ConfigureMovieGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load movies.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void ConfigureMovieGrid()
        {
            ConfigureGrid(dataGridMovies);

            // Hide database ID
            dataGridMovies.Columns["MovieId"].Visible = false;

            // Column headers
            dataGridMovies.Columns["Title"].HeaderText = "Title";
            dataGridMovies.Columns["Genre"].HeaderText = "Genre";
            dataGridMovies.Columns["Director"].HeaderText = "Director";
            dataGridMovies.Columns["ReleaseYear"].HeaderText = "Year";

            // Center the year column
            dataGridMovies.Columns["ReleaseYear"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Add Delete button
            AddDeleteButton(dataGridMovies);
        }


        // =====================================================
        // USER MANAGEMENT
        // =====================================================

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            UserId,
                            Name,
                            Email,
                            DateRegistered
                        FROM Users
                        WHERE Role <> 'Admin'
                        ORDER BY UserId DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridUsers.DataSource = table;
                    }
                }

                ConfigureUserGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load users.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void ConfigureUserGrid()
        {
            ConfigureGrid(dataGridUsers);

            // Hide database ID
            dataGridUsers.Columns["UserId"].Visible = false;

            // Column headers
            dataGridUsers.Columns["Name"].HeaderText = "Name";
            dataGridUsers.Columns["Email"].HeaderText = "Email";
            dataGridUsers.Columns["DateRegistered"]
                .HeaderText = "Date Registered";

            // Date format
            dataGridUsers.Columns["DateRegistered"]
                .DefaultCellStyle.Format = "dd MMM yyyy";

            // Add Delete button
            AddDeleteButton(dataGridUsers);
        }


        // =====================================================
        // REVIEW MANAGEMENT
        // =====================================================

        private void LoadReviews()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            r.ReviewId,
                            u.Name AS UserName,
                            m.Title AS MovieTitle,
                            r.Rating,
                            r.ReviewText,
                            r.ReviewDate
                        FROM Reviews r
                        INNER JOIN Users u
                            ON r.UserId = u.UserId
                        INNER JOIN Movies m
                            ON r.MovieId = m.MovieId
                        ORDER BY r.ReviewId DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridReviews.DataSource = table;
                    }
                }

                ConfigureReviewGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load reviews.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void ConfigureReviewGrid()
        {
            ConfigureGrid(dataGridReviews);

            // Hide database ID
            dataGridReviews.Columns["ReviewId"].Visible = false;

            // Column headers
            dataGridReviews.Columns["UserName"].HeaderText = "User";
            dataGridReviews.Columns["MovieTitle"].HeaderText = "Movie";
            dataGridReviews.Columns["Rating"].HeaderText = "Rating";
            dataGridReviews.Columns["ReviewText"].HeaderText = "Review";
            dataGridReviews.Columns["ReviewDate"].HeaderText = "Date";

            // Date format
            dataGridReviews.Columns["ReviewDate"]
                .DefaultCellStyle.Format = "dd MMM yyyy";

            // Center Rating and Date
            dataGridReviews.Columns["Rating"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridReviews.Columns["ReviewDate"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Keep review text in one line
            dataGridReviews.Columns["ReviewText"]
                .DefaultCellStyle.WrapMode =
                DataGridViewTriState.False;

            // Add Delete button
            AddDeleteButton(dataGridReviews);
        }


        // =====================================================
        // REVIEW DISPLAY FORMATTING
        // =====================================================

        private void dataGridReviews_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string columnName =
                dataGridReviews.Columns[e.ColumnIndex].Name;


            // Convert rating number to stars
            if (columnName == "Rating" &&
                e.Value != null &&
                int.TryParse(e.Value.ToString(), out int rating))
            {
                if (rating >= 1 && rating <= 5)
                {
                    e.Value =
                        new string('★', rating) +
                        new string('☆', 5 - rating);

                    e.FormattingApplied = true;
                }
            }


            // Show only a short version of the review
            if (columnName == "ReviewText" &&
                e.Value != null)
            {
                string reviewText = e.Value.ToString();

                if (reviewText.Length > 35)
                {
                    e.Value =
                        reviewText.Substring(0, 35) + "...";
                }

                e.FormattingApplied = true;
            }
        }


        // =====================================================
        // MOVIE DELETE
        // =====================================================

        private void dataGridMovies_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                dataGridMovies.Columns[e.ColumnIndex].Name != "Delete")
                return;

            int movieId =
                Convert.ToInt32(
                    dataGridMovies.Rows[e.RowIndex]
                    .Cells["MovieId"]
                    .Value
                );

            string movieTitle =
                dataGridMovies.Rows[e.RowIndex]
                .Cells["Title"]
                .Value
                .ToString();

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete \"" +
                    movieTitle + "\"?",
                    "Delete Movie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
                DeleteMovie(movieId);
            }
        }


        private void DeleteMovie(int movieId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Delete related data before deleting the movie
                    string query = @"
                        DELETE FROM Reviews
                        WHERE MovieId = @MovieId;

                        DELETE FROM Favorites
                        WHERE MovieId = @MovieId;

                        DELETE FROM Watchlist
                        WHERE MovieId = @MovieId;

                        DELETE FROM Movies
                        WHERE MovieId = @MovieId;";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@MovieId",
                            movieId
                        );

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Movie deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadMovies();
                LoadDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete movie.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // USER DELETE
        // =====================================================

        private void dataGridUsers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                dataGridUsers.Columns[e.ColumnIndex].Name != "Delete")
                return;

            int userId =
                Convert.ToInt32(
                    dataGridUsers.Rows[e.RowIndex]
                    .Cells["UserId"]
                    .Value
                );

            string userName =
                dataGridUsers.Rows[e.RowIndex]
                .Cells["Name"]
                .Value
                .ToString();

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete user \"" +
                    userName + "\"?",
                    "Delete User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
                DeleteUser(userId);
            }
        }


        private void DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // Delete related data before deleting the user
                    string query = @"
                        DELETE FROM Reviews
                        WHERE UserId = @UserId;

                        DELETE FROM Favorites
                        WHERE UserId = @UserId;

                        DELETE FROM Watchlist
                        WHERE UserId = @UserId;

                        DELETE FROM Users
                        WHERE UserId = @UserId
                        AND Role <> 'Admin';";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@UserId",
                            userId
                        );

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "User deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadUsers();
                LoadDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete user.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // REVIEW DELETE
        // =====================================================

        private void dataGridReviews_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                dataGridReviews.Columns[e.ColumnIndex].Name != "Delete")
                return;

            int reviewId =
                Convert.ToInt32(
                    dataGridReviews.Rows[e.RowIndex]
                    .Cells["ReviewId"]
                    .Value
                );

            string userName =
                dataGridReviews.Rows[e.RowIndex]
                .Cells["UserName"]
                .Value
                .ToString();

            string movieTitle =
                dataGridReviews.Rows[e.RowIndex]
                .Cells["MovieTitle"]
                .Value
                .ToString();

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete " +
                    userName +
                    "'s review for \"" +
                    movieTitle + "\"?",
                    "Delete Review",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result == DialogResult.Yes)
            {
                DeleteReview(reviewId);
            }
        }


        private void DeleteReview(int reviewId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        DELETE FROM Reviews
                        WHERE ReviewId = @ReviewId;";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@ReviewId",
                            reviewId
                        );

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Review deleted successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadReviews();
                LoadDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete review.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // MOVIE SEARCH
        // =====================================================

        private void btnSearchMovie_Click(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtSearchMovie.Text.Trim();

            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            MovieId,
                            Title,
                            Genre,
                            Director,
                            ReleaseYear
                        FROM Movies
                        WHERE Title LIKE @Search
                           OR Genre LIKE @Search
                           OR Director LIKE @Search
                        ORDER BY MovieId DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue(
                            "@Search",
                            "%" + searchText + "%"
                        );

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridMovies.DataSource = table;
                    }
                }

                ConfigureMovieGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Movie search failed.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // USER SEARCH
        // =====================================================

        private void btnSearchUser_Click(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtSearchUser.Text.Trim();

            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            UserId,
                            Name,
                            Email,
                            DateRegistered
                        FROM Users
                        WHERE Role <> 'Admin'
                        AND
                        (
                            Name LIKE @Search
                            OR Email LIKE @Search
                        )
                        ORDER BY UserId DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue(
                            "@Search",
                            "%" + searchText + "%"
                        );

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridUsers.DataSource = table;
                    }
                }

                ConfigureUserGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "User search failed.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // REVIEW SEARCH
        // =====================================================

        private void btnSearchReview_Click(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtSearchReview.Text.Trim();

            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            r.ReviewId,
                            u.Name AS UserName,
                            m.Title AS MovieTitle,
                            r.Rating,
                            r.ReviewText,
                            r.ReviewDate
                        FROM Reviews r
                        INNER JOIN Users u
                            ON r.UserId = u.UserId
                        INNER JOIN Movies m
                            ON r.MovieId = m.MovieId
                        WHERE u.Name LIKE @Search
                           OR m.Title LIKE @Search
                           OR r.ReviewText LIKE @Search
                        ORDER BY r.ReviewId DESC";

                    using (SqlDataAdapter adapter =
                           new SqlDataAdapter(query, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue(
                            "@Search",
                            "%" + searchText + "%"
                        );

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dataGridReviews.DataSource = table;
                    }
                }

                ConfigureReviewGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Review search failed.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // NAVIGATION BUTTONS
        // =====================================================

        private void btnDashBoard_Click(
            object sender,
            EventArgs e)
        {
            ShowOverviewPanel();
            LoadDashboardCounts();
        }


        private void btnMovies_Click(
            object sender,
            EventArgs e)
        {
            ShowMovieManagementPanel();
        }


        private void btnUsers_Click(
            object sender,
            EventArgs e)
        {
            ShowUserManagementPanel();
        }


        private void btnReviews_Click(
            object sender,
            EventArgs e)
        {
            ShowReviewManagementPanel();
        }


        // =====================================================
        // MOVIE ACTION BUTTONS
        // =====================================================

        private void btnAddMovie_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Add Movie form will open here."
            );
        }


        private void btnEditMovie_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Edit Movie form will open here."
            );
        }


        private void btnAddNewmovies_Click(
            object sender,
            EventArgs e)
        {
            btnAddMovie_Click(sender, e);
        }


        private void btnEditNewMovie_Click(
            object sender,
            EventArgs e)
        {
            btnEditMovie_Click(sender, e);
        }


        // =====================================================
        // LOGOUT
        // =====================================================

        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            Session.Clear();

            Form1 loginForm = new Form1();

            loginForm.Show();

            this.Close();
        }


        // =====================================================
        // OVERVIEW CARD BORDERS
        // =====================================================

        private void DrawPanelBorder(
            PaintEventArgs e,
            Panel panel)
        {
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panel.Width - 1,
                    panel.Height - 1
                );
            }
        }


        private void panelMovieCard_Paint(
            object sender,
            PaintEventArgs e)
        {
            DrawPanelBorder(e, panelMovieCard);
        }


        private void panelUserCard_Paint(
            object sender,
            PaintEventArgs e)
        {
            DrawPanelBorder(e, panelUserCard);
        }


        private void panelReviewCard_Paint(
            object sender,
            PaintEventArgs e)
        {
            DrawPanelBorder(e, panelReviewCard);
        }


        private void panelQuickAction_Paint(
            object sender,
            PaintEventArgs e)
        {
            DrawPanelBorder(e, panelQuickAction);
        }
    }
}