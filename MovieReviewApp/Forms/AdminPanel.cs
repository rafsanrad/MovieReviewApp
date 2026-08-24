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

        private DatabaseHelper db =
            new DatabaseHelper();


        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public AdminPanel()
        {
            InitializeComponent();

            // Make sure panels are in correct position
            panelOverview.Location =
                new Point(33, 115);

            panelMovieManagement.Location =
                new Point(33, 115);

            panelUserManagement.Location =
                new Point(33, 115);


            // Initially show Dashboard
            ShowOverviewPanel();

            // Load dashboard counts
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

            panelUserManagement.BringToFront();

            LoadUsers();
        }


        // =====================================================
        // LOAD DASHBOARD COUNTS
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
                    // TOTAL MOVIES
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
                    // TOTAL USERS
                    // -------------------------------------------------

                    string userQuery =
                        "SELECT COUNT(*) FROM Users " +
                        "WHERE Role <> 'Admin'";

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
                    // TOTAL REVIEWS
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


                // -------------------------------------------------
                // GRID SETTINGS
                // -------------------------------------------------

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
            if (dataGridMovies.Columns.Count == 0)
            {
                return;
            }


            // Hide MovieId
            if (dataGridMovies.Columns["MovieId"] != null)
            {
                dataGridMovies.Columns["MovieId"]
                    .Visible = false;
            }


            // Column headers

            dataGridMovies.Columns["Title"]
                .HeaderText = "Title";

            dataGridMovies.Columns["Genre"]
                .HeaderText = "Genre";

            dataGridMovies.Columns["Director"]
                .HeaderText = "Director";

            dataGridMovies.Columns["ReleaseYear"]
                .HeaderText = "Year";


            // -------------------------------------------------
            // ADD DELETE BUTTON
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
            // GRID LOOK
            // -------------------------------------------------

            dataGridMovies.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridMovies.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridMovies.MultiSelect =
                false;

            dataGridMovies.ReadOnly =
                true;

            dataGridMovies.AllowUserToAddRows =
                false;

            dataGridMovies.AllowUserToDeleteRows =
                false;
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


                    // Admin বাদ দিয়ে শুধু normal users
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


                // Configure grid
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
            if (dataGridUsers.Columns.Count == 0)
            {
                return;
            }


            // Hide UserId
            if (dataGridUsers.Columns["UserId"] != null)
            {
                dataGridUsers.Columns["UserId"]
                    .Visible = false;
            }


            // Header names

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
            // ADD DELETE BUTTON
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
            // GRID LOOK
            // -------------------------------------------------

            dataGridUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridUsers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridUsers.MultiSelect =
                false;

            dataGridUsers.ReadOnly =
                true;

            dataGridUsers.AllowUserToAddRows =
                false;

            dataGridUsers.AllowUserToDeleteRows =
                false;
        }


        // =====================================================
        // MOVIE GRID CELL CLICK
        // =====================================================

        private void dataGridMovies_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            if (dataGridMovies.Columns[e.ColumnIndex].Name
                == "Delete")
            {
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


                    // -------------------------------------------------
                    // IMPORTANT:
                    // Movie may exist in Reviews, Favorites,
                    // Watchlist. So delete related records first.
                    // -------------------------------------------------

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


                // Refresh
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
        // USER GRID CELL CLICK
        // =====================================================

        private void dataGridUsers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }


            if (dataGridUsers.Columns[e.ColumnIndex].Name
                == "Delete")
            {
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


                    // -------------------------------------------------
                    // Delete dependent records first
                    // -------------------------------------------------

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


                // Refresh
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
                        adapter.SelectCommand.Parameters.AddWithValue(
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
                        adapter.SelectCommand.Parameters.AddWithValue(
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
        // DASHBOARD BUTTON
        // =====================================================

        private void btnDashBoard_Click(
            object sender,
            EventArgs e)
        {
            ShowOverviewPanel();

            LoadDashboardCounts();
        }


        // =====================================================
        // MOVIES BUTTON
        // =====================================================

        private void btnMovies_Click(
            object sender,
            EventArgs e)
        {
            ShowMovieManagementPanel();
        }


        // =====================================================
        // USERS BUTTON
        // =====================================================

        private void btnUsers_Click(
            object sender,
            EventArgs e)
        {
            ShowUserManagementPanel();
        }


        // =====================================================
        // REVIEWS BUTTON
        // =====================================================

        private void btnReviews_Click(
            object sender,
            EventArgs e)
        {
            MessageBox.Show(
                "Review Management will be added next.",
                "Reviews"
            );
        }


        // =====================================================
        // ADD MOVIE
        // =====================================================

        private void btnAddMovie_Click(
            object sender,
            EventArgs e)
        {
            // AddMovieForm will be opened here later
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
            // EditMovieForm will be opened here later
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
            btnAddMovie_Click(
                sender,
                e
            );
        }


        // =====================================================
        // EDIT NEW MOVIE
        // =====================================================

        private void btnEditNewMovie_Click(
            object sender,
            EventArgs e)
        {
            btnEditMovie_Click(
                sender,
                e
            );
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