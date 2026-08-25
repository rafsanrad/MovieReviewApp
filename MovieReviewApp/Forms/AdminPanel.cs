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
        // -----------------------------------------------------
        // DATABASE
        // -----------------------------------------------------

        private DatabaseHelper db =
            new DatabaseHelper();


        // -----------------------------------------------------
        // CONSTRUCTOR
        // -----------------------------------------------------

        public AdminPanel()
        {
            InitializeComponent();

            // -------------------------------------------------
            // PANEL LOCATIONS
            // -------------------------------------------------

            panelOverview.Location =
                new Point(33, 115);

            panelMovieManagement.Location =
                new Point(33, 115);

            panelUserManagement.Location =
                new Point(33, 115);

            panelReviewManagement.Location =
                new Point(33, 115);


            // -------------------------------------------------
            // LOADING INITIAL PANEL
            // -------------------------------------------------

            ShowOverviewPanel();


            // -------------------------------------------------
            // LOADING DASHBOARD
            // -------------------------------------------------

            LoadDashboardCounts();
        }


        // =====================================================
        // SHOW OVERVIEW PANEL
        // =====================================================

        private void ShowOverviewPanel()
        {
            panelOverview.Visible = true;
            panelMovieManagement.Visible = false;
            panelUserManagement.Visible = false;
            panelReviewManagement.Visible = false;

            panelOverview.BringToFront();
        }


        // =====================================================
        // SHOW MOVIE MANAGEMENT PANEL
        // =====================================================

        private void ShowMovieManagementPanel()
        {
            panelOverview.Visible = false;
            panelMovieManagement.Visible = true;
            panelUserManagement.Visible = false;
            panelReviewManagement.Visible = false;

            panelMovieManagement.BringToFront();

            LoadMovies();
        }


        // =====================================================
        // SHOW USER MANAGEMENT PANEL
        // =====================================================

        private void ShowUserManagementPanel()
        {
            panelOverview.Visible = false;
            panelMovieManagement.Visible = false;
            panelUserManagement.Visible = true;
            panelReviewManagement.Visible = false;

            panelUserManagement.BringToFront();

            LoadUsers();
        }


        // =====================================================
        // SHOW REVIEW MANAGEMENT PANEL
        // =====================================================

        private void ShowReviewManagementPanel()
        {
            panelOverview.Visible = false;
            panelMovieManagement.Visible = false;
            panelUserManagement.Visible = false;
            panelReviewManagement.Visible = true;

            panelReviewManagement.BringToFront();

            LoadReviews();
        }


        // =====================================================
        // DASHBOARD COUNTS
        // =====================================================

        private void LoadDashboardCounts()
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();


                    // -------------------------------------------------
                    // MOVIES
                    // -------------------------------------------------

                    string movieQuery =
                        "SELECT COUNT(*) FROM Movies";

                    using (SqlCommand command =
                           new SqlCommand(
                               movieQuery,
                               connection))
                    {
                        int totalMovies =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblMovieNumber.Text =
                            totalMovies.ToString();
                    }


                    // -------------------------------------------------
                    // USERS
                    // -------------------------------------------------

                    string userQuery =
                        "SELECT COUNT(*) FROM Users WHERE Role <> 'Admin'";

                    using (SqlCommand command =
                           new SqlCommand(
                               userQuery,
                               connection))
                    {
                        int totalUsers =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblUserNumber.Text =
                            totalUsers.ToString();
                    }


                    // -------------------------------------------------
                    // REVIEWS
                    // -------------------------------------------------

                    string reviewQuery =
                        "SELECT COUNT(*) FROM Reviews";

                    using (SqlCommand command =
                           new SqlCommand(
                               reviewQuery,
                               connection))
                    {
                        int totalReviews =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblReviewNumber.Text =
                            totalReviews.ToString();
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
        // LOAD MOVIES
        // =====================================================

        private void LoadMovies()
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
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
                           new SqlDataAdapter(
                               query,
                               connection))
                    {
                        DataTable table =
                            new DataTable();

                        adapter.Fill(table);

                        dataGridMovies.DataSource =
                            table;
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


        // =====================================================
        // CONFIGURE MOVIE GRID
        // =====================================================

        private void ConfigureMovieGrid()
        {
            // -------------------------------------------------
            // FIXED GRID SIZE
            // -------------------------------------------------

            dataGridMovies.Size =
                new Size(726, 361);


            // -------------------------------------------------
            // REMOVE EXTRA EMPTY ROW
            // -------------------------------------------------

            dataGridMovies.AllowUserToAddRows =
                false;

            dataGridMovies.AllowUserToDeleteRows =
                false;

            dataGridMovies.ReadOnly =
                true;


            // -------------------------------------------------
            // WHITE BACKGROUND
            // -------------------------------------------------

            dataGridMovies.BackgroundColor =
                Color.White;

            dataGridMovies.GridColor =
                Color.LightGray;

            dataGridMovies.BorderStyle =
                BorderStyle.FixedSingle;


            // -------------------------------------------------
            // SCROLLING
            // -------------------------------------------------

            dataGridMovies.ScrollBars =
                ScrollBars.Vertical;


            // -------------------------------------------------
            // ROW SETTINGS
            // -------------------------------------------------

            dataGridMovies.RowHeadersVisible =
                false;

            dataGridMovies.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridMovies.MultiSelect =
                false;

            dataGridMovies.AutoGenerateColumns =
                true;


            // -------------------------------------------------
            // HEADER
            // -------------------------------------------------

            dataGridMovies.ColumnHeadersVisible =
                true;

            dataGridMovies.ColumnHeadersHeight =
                35;

            dataGridMovies.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // -------------------------------------------------
            // HIDE MOVIE ID
            // -------------------------------------------------

            if (dataGridMovies.Columns["MovieId"] != null)
            {
                dataGridMovies.Columns["MovieId"]
                    .Visible = false;
            }


            // -------------------------------------------------
            // COLUMN NAMES
            // -------------------------------------------------

            dataGridMovies.Columns["Title"]
                .HeaderText = "Title";

            dataGridMovies.Columns["Genre"]
                .HeaderText = "Genre";

            dataGridMovies.Columns["Director"]
                .HeaderText = "Director";

            dataGridMovies.Columns["ReleaseYear"]
                .HeaderText = "Year";


            // -------------------------------------------------
            // DELETE BUTTON
            // -------------------------------------------------

            if (dataGridMovies.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton =
                    new DataGridViewButtonColumn();

                deleteButton.Name =
                    "Delete";

                deleteButton.HeaderText =
                    "Action";

                deleteButton.Text =
                    "Delete";

                deleteButton.UseColumnTextForButtonValue =
                    true;

                dataGridMovies.Columns.Add(
                    deleteButton
                );
            }


            // -------------------------------------------------
            // COLUMN WIDTH
            // -------------------------------------------------

            dataGridMovies.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            // -------------------------------------------------
            // ROW HEIGHT
            // -------------------------------------------------

            dataGridMovies.RowTemplate.Height =
                32;


            // -------------------------------------------------
            // CELL ALIGNMENT
            // -------------------------------------------------

            foreach (DataGridViewColumn column
                     in dataGridMovies.Columns)
            {
                column.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            dataGridMovies.Columns["ReleaseYear"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridMovies.Columns["Delete"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }


        // =====================================================
        // LOAD USERS
        // =====================================================

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
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
                           new SqlDataAdapter(
                               query,
                               connection))
                    {
                        DataTable table =
                            new DataTable();

                        adapter.Fill(table);

                        dataGridUsers.DataSource =
                            table;
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


        // =====================================================
        // CONFIGURE USER GRID
        // =====================================================

        private void ConfigureUserGrid()
        {
            // -------------------------------------------------
            // FIXED GRID SIZE
            // -------------------------------------------------

            dataGridUsers.Size =
                new Size(726, 361);


            // -------------------------------------------------
            // REMOVE EXTRA EMPTY ROW
            // -------------------------------------------------

            dataGridUsers.AllowUserToAddRows =
                false;

            dataGridUsers.AllowUserToDeleteRows =
                false;

            dataGridUsers.ReadOnly =
                true;


            // -------------------------------------------------
            // WHITE BACKGROUND
            // -------------------------------------------------

            dataGridUsers.BackgroundColor =
                Color.White;

            dataGridUsers.GridColor =
                Color.LightGray;

            dataGridUsers.BorderStyle =
                BorderStyle.FixedSingle;


            // -------------------------------------------------
            // SCROLLBAR
            // -------------------------------------------------

            dataGridUsers.ScrollBars =
                ScrollBars.Vertical;


            // -------------------------------------------------
            // ROW HEADER
            // -------------------------------------------------

            dataGridUsers.RowHeadersVisible =
                false;


            // -------------------------------------------------
            // SELECTION
            // -------------------------------------------------

            dataGridUsers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridUsers.MultiSelect =
                false;


            // -------------------------------------------------
            // HEADER
            // -------------------------------------------------

            dataGridUsers.ColumnHeadersVisible =
                true;

            dataGridUsers.ColumnHeadersHeight =
                35;

            dataGridUsers.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // -------------------------------------------------
            // HIDE USER ID
            // -------------------------------------------------

            if (dataGridUsers.Columns["UserId"] != null)
            {
                dataGridUsers.Columns["UserId"]
                    .Visible = false;
            }


            // -------------------------------------------------
            // COLUMN HEADERS
            // -------------------------------------------------

            dataGridUsers.Columns["Name"]
                .HeaderText = "Name";

            dataGridUsers.Columns["Email"]
                .HeaderText = "Email";

            dataGridUsers.Columns["DateRegistered"]
                .HeaderText = "Date Registered";


            // -------------------------------------------------
            // DATE FORMAT
            // -------------------------------------------------

            dataGridUsers.Columns["DateRegistered"]
                .DefaultCellStyle.Format =
                "dd MMM yyyy";


            // -------------------------------------------------
            // DELETE BUTTON
            // -------------------------------------------------

            if (dataGridUsers.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton =
                    new DataGridViewButtonColumn();

                deleteButton.Name =
                    "Delete";

                deleteButton.HeaderText =
                    "Action";

                deleteButton.Text =
                    "Delete";

                deleteButton.UseColumnTextForButtonValue =
                    true;

                dataGridUsers.Columns.Add(
                    deleteButton
                );
            }


            // -------------------------------------------------
            // COLUMN WIDTH
            // -------------------------------------------------

            dataGridUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            // -------------------------------------------------
            // ROW HEIGHT
            // -------------------------------------------------

            dataGridUsers.RowTemplate.Height =
                32;


            // -------------------------------------------------
            // ALIGNMENT
            // -------------------------------------------------

            foreach (DataGridViewColumn column
                     in dataGridUsers.Columns)
            {
                column.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }

            dataGridUsers.Columns["Delete"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }


        // =====================================================
        // LOAD REVIEWS
        // =====================================================

        private void LoadReviews()
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
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
                           new SqlDataAdapter(
                               query,
                               connection))
                    {
                        DataTable table =
                            new DataTable();

                        adapter.Fill(table);

                        dataGridReviews.DataSource =
                            table;
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


        // =====================================================
        // CONFIGURE REVIEW GRID
        // =====================================================

        private void ConfigureReviewGrid()
        {
            // -------------------------------------------------
            // FIXED GRID SIZE
            // -------------------------------------------------

            dataGridReviews.Size =
                new Size(726, 361);


            // -------------------------------------------------
            // REMOVE EXTRA EMPTY ROW
            // -------------------------------------------------

            dataGridReviews.AllowUserToAddRows =
                false;

            dataGridReviews.AllowUserToDeleteRows =
                false;

            dataGridReviews.ReadOnly =
                true;


            // -------------------------------------------------
            // WHITE BACKGROUND
            // -------------------------------------------------

            dataGridReviews.BackgroundColor =
                Color.White;

            dataGridReviews.GridColor =
                Color.LightGray;

            dataGridReviews.BorderStyle =
                BorderStyle.FixedSingle;


            // -------------------------------------------------
            // SCROLLING
            // -------------------------------------------------

            dataGridReviews.ScrollBars =
                ScrollBars.Vertical;


            // -------------------------------------------------
            // ROW HEADER
            // -------------------------------------------------

            dataGridReviews.RowHeadersVisible =
                false;


            // -------------------------------------------------
            // SELECTION
            // -------------------------------------------------

            dataGridReviews.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridReviews.MultiSelect =
                false;

            dataGridReviews.AutoGenerateColumns =
                true;


            // -------------------------------------------------
            // HEADER
            // -------------------------------------------------

            dataGridReviews.ColumnHeadersVisible =
                true;

            dataGridReviews.ColumnHeadersHeight =
                35;

            dataGridReviews.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // -------------------------------------------------
            // HIDE REVIEW ID
            // -------------------------------------------------

            if (dataGridReviews.Columns["ReviewId"] != null)
            {
                dataGridReviews.Columns["ReviewId"]
                    .Visible = false;
            }


            // -------------------------------------------------
            // COLUMN HEADERS
            // -------------------------------------------------

            dataGridReviews.Columns["UserName"]
                .HeaderText = "User";

            dataGridReviews.Columns["MovieTitle"]
                .HeaderText = "Movie";

            dataGridReviews.Columns["Rating"]
                .HeaderText = "Rating";

            dataGridReviews.Columns["ReviewText"]
                .HeaderText = "Review";

            dataGridReviews.Columns["ReviewDate"]
                .HeaderText = "Date";


            // -------------------------------------------------
            // DATE FORMAT
            // -------------------------------------------------

            dataGridReviews.Columns["ReviewDate"]
                .DefaultCellStyle.Format =
                "dd MMM yyyy";


            // -------------------------------------------------
            // DELETE BUTTON
            // -------------------------------------------------

            if (dataGridReviews.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton =
                    new DataGridViewButtonColumn();

                deleteButton.Name =
                    "Delete";

                deleteButton.HeaderText =
                    "Action";

                deleteButton.Text =
                    "Delete";

                deleteButton.UseColumnTextForButtonValue =
                    true;

                dataGridReviews.Columns.Add(
                    deleteButton
                );
            }


            // -------------------------------------------------
            // COLUMN WIDTH
            // -------------------------------------------------

            dataGridReviews.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;


            // -------------------------------------------------
            // ROW HEIGHT
            // -------------------------------------------------

            dataGridReviews.RowTemplate.Height =
                32;


            // -------------------------------------------------
            // ALIGNMENT
            // -------------------------------------------------

            foreach (DataGridViewColumn column
                     in dataGridReviews.Columns)
            {
                column.DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleLeft;
            }


            dataGridReviews.Columns["Rating"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridReviews.Columns["ReviewDate"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridReviews.Columns["Delete"]
                .DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;


            // -------------------------------------------------
            // REVIEW COLUMN
            // -------------------------------------------------

            dataGridReviews.Columns["ReviewText"]
                .DefaultCellStyle.WrapMode =
                DataGridViewTriState.False;
        }


        // =====================================================
        // REVIEW CELL FORMATTING
        // =====================================================

        private void dataGridReviews_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            string columnName =
                dataGridReviews.Columns[e.ColumnIndex].Name;


            // -------------------------------------------------
            // RATING
            // -------------------------------------------------

            if (columnName == "Rating")
            {
                if (e.Value != null &&
                    int.TryParse(
                        e.Value.ToString(),
                        out int rating))
                {
                    if (rating >= 1 && rating <= 5)
                    {
                        e.Value =
                            new string('★', rating) +
                            new string('☆', 5 - rating);

                        e.FormattingApplied = true;
                    }
                }
            }


            // -------------------------------------------------
            // SHORT REVIEW
            // -------------------------------------------------

            if (columnName == "ReviewText")
            {
                if (e.Value != null)
                {
                    string reviewText =
                        e.Value.ToString();

                    if (reviewText.Length > 35)
                    {
                        e.Value =
                            reviewText.Substring(0, 35) +
                            "...";
                    }

                    e.FormattingApplied = true;
                }
            }
        }


        // =====================================================
        // MOVIE DELETE CLICK
        // =====================================================

        private void dataGridMovies_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridMovies.Columns[e.ColumnIndex].Name
                != "Delete")
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
                    movieTitle +
                    "\"?",
                    "Delete Movie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


            if (result == DialogResult.Yes)
            {
                DeleteMovie(movieId);
            }
        }


        // =====================================================
        // DELETE MOVIE
        // =====================================================

        private void DeleteMovie(int movieId)
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

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
                           new SqlCommand(
                               query,
                               connection))
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
        // USER DELETE CLICK
        // =====================================================

        private void dataGridUsers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridUsers.Columns[e.ColumnIndex].Name
                != "Delete")
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
                    userName +
                    "\"?",
                    "Delete User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


            if (result == DialogResult.Yes)
            {
                DeleteUser(userId);
            }
        }


        // =====================================================
        // DELETE USER
        // =====================================================

        private void DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

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
                           new SqlCommand(
                               query,
                               connection))
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
        // REVIEW DELETE CLICK
        // =====================================================

        private void dataGridReviews_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridReviews.Columns[e.ColumnIndex].Name
                != "Delete")
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
                    movieTitle +
                    "\"?",
                    "Delete Review",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );


            if (result == DialogResult.Yes)
            {
                DeleteReview(reviewId);
            }
        }


        // =====================================================
        // DELETE REVIEW
        // =====================================================

        private void DeleteReview(int reviewId)
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        DELETE FROM Reviews
                        WHERE ReviewId = @ReviewId;";

                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
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
                using (SqlConnection connection =
                       db.GetConnection())
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
                           new SqlDataAdapter(
                               query,
                               connection))
                    {
                        adapter.SelectCommand
                            .Parameters.AddWithValue(
                                "@Search",
                                "%" + searchText + "%"
                            );


                        DataTable table =
                            new DataTable();

                        adapter.Fill(table);

                        dataGridMovies.DataSource =
                            table;
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
                using (SqlConnection connection =
                       db.GetConnection())
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
                           new SqlDataAdapter(
                               query,
                               connection))
                    {
                        adapter.SelectCommand
                            .Parameters.AddWithValue(
                                "@Search",
                                "%" + searchText + "%"
                            );


                        DataTable table =
                            new DataTable();

                        adapter.Fill(table);

                        dataGridUsers.DataSource =
                            table;
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
                using (SqlConnection connection =
                       db.GetConnection())
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
                           new SqlDataAdapter(
                               query,
                               connection))
                    {
                        adapter.SelectCommand
                            .Parameters.AddWithValue(
                                "@Search",
                                "%" + searchText + "%"
                            );


                        DataTable table =
                            new DataTable();

                        adapter.Fill(table);

                        dataGridReviews.DataSource =
                            table;
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
        // LOGOUT
        // =====================================================

        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            Session.Clear();

            Form1 loginForm =
                new Form1();

            loginForm.Show();

            this.Close();
        }


        // =====================================================
        // DASHBOARD
        // =====================================================

        private void btnDashBoard_Click(
            object sender,
            EventArgs e)
        {
            ShowOverviewPanel();

            LoadDashboardCounts();
        }


        // =====================================================
        // MOVIES
        // =====================================================

        private void btnMovies_Click(
            object sender,
            EventArgs e)
        {
            ShowMovieManagementPanel();
        }


        // =====================================================
        // USERS
        // =====================================================

        private void btnUsers_Click(
            object sender,
            EventArgs e)
        {
            ShowUserManagementPanel();
        }


        // =====================================================
        // REVIEWS
        // =====================================================

        private void btnReviews_Click(
            object sender,
            EventArgs e)
        {
            ShowReviewManagementPanel();
        }


        // =====================================================
        // ADD MOVIE
        // =====================================================

        private void btnAddMovie_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Add Movie form will open here."
            );
        }


        // =====================================================
        // EDIT MOVIE
        // =====================================================

        private void btnEditMovie_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Edit Movie form will open here."
            );
        }


        // =====================================================
        // ADD NEW MOVIE
        // =====================================================

        private void btnAddNewmovies_Click(
            object sender,
            EventArgs e)
        {
            btnAddMovie_Click(sender, e);
        }


        // =====================================================
        // EDIT NEW MOVIE
        // =====================================================

        private void btnEditNewMovie_Click(
            object sender,
            EventArgs e)
        {
            btnEditMovie_Click(sender, e);
        }


        // =====================================================
        // PANEL BORDERS
        // =====================================================

        private void panelMovieCard_Paint(
            object sender,
            PaintEventArgs e)
        {
            using (Pen pen =
                   new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelMovieCard.Width - 1,
                    panelMovieCard.Height - 1
                );
            }
        }


        private void panelUserCard_Paint(
            object sender,
            PaintEventArgs e)
        {
            using (Pen pen =
                   new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelUserCard.Width - 1,
                    panelUserCard.Height - 1
                );
            }
        }


        private void panelReviewCard_Paint(
            object sender,
            PaintEventArgs e)
        {
            using (Pen pen =
                   new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelReviewCard.Width - 1,
                    panelReviewCard.Height - 1
                );
            }
        }


        private void panelQuickAction_Paint(
            object sender,
            PaintEventArgs e)
        {
            using (Pen pen =
                   new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelQuickAction.Width - 1,
                    panelQuickAction.Height - 1
                );
            }
        }

        
    }
}