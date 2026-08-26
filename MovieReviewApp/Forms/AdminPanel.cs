using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MovieReviewApp.Models;
using MovieReviewApp.Services;

namespace MovieReviewApp.Forms
{
    public partial class AdminPanel : Form
    {
        private MovieService movieService;
        private DatabaseHelper db;

        public AdminPanel()
        {
            InitializeComponent();

            movieService = new MovieService();
            db = new DatabaseHelper();

            this.Load += AdminPanel_Load;
        }

        // =====================================================
        // FORM LOAD
        // =====================================================

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            SetPanelStyles();

            ShowOverview();

            LoadDashboardCounts();
            LoadMovies();
            LoadUsers();
            LoadReviews();
        }

        // =====================================================
        // PANEL STYLES
        // =====================================================

        private void SetPanelStyles()
        {
            // CONTENT PANEL LABELS - TRANSPARENT
            SetLabelsTransparent(panelContent);

            // OVERVIEW
            SetPanelStyle(panelOverview);

            // OVERVIEW CARDS
            SetPanelStyle(panelMovieCard);
            SetPanelStyle(panelUserCard);
            SetPanelStyle(panelReviewCard);

            // QUICK ACTION
            SetPanelStyle(panelQuickAction);

            // MANAGEMENT PANELS
            SetPanelStyle(panelUserManagement);
            SetPanelStyle(panelMovieManagement);
            SetPanelStyle(panelReviewManagement);

            // DATA GRIDS
            SetGridBorder(dataGridUsers);
            SetGridBorder(dataGridMovies);
            SetGridBorder(dataGridReviews);
        }

        private void SetPanelStyle(Panel panel)
        {
            panel.BackColor = Color.Transparent;
            panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SetGridBorder(DataGridView grid)
        {
            grid.BorderStyle = BorderStyle.FixedSingle;
        }

        private void SetLabelsTransparent(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label)
                {
                    control.BackColor = Color.Transparent;
                }

                if (control.HasChildren)
                {
                    SetLabelsTransparent(control);
                }
            }
        }

        // =====================================================
        // SHOW OVERVIEW
        // =====================================================

        private void ShowOverview()
        {
            panelOverview.Visible = true;
            panelMovieManagement.Visible = false;
            panelUserManagement.Visible = false;
            panelReviewManagement.Visible = false;
        }

        // =====================================================
        // SHOW MOVIES
        // =====================================================

        private void ShowMovies()
        {
            panelOverview.Visible = false;
            panelMovieManagement.Visible = true;
            panelUserManagement.Visible = false;
            panelReviewManagement.Visible = false;

            LoadMovies();
        }

        // =====================================================
        // SHOW USERS
        // =====================================================

        private void ShowUsers()
        {
            panelOverview.Visible = false;
            panelMovieManagement.Visible = false;
            panelUserManagement.Visible = true;
            panelReviewManagement.Visible = false;

            LoadUsers();
        }

        // =====================================================
        // SHOW REVIEWS
        // =====================================================

        private void ShowReviews()
        {
            panelOverview.Visible = false;
            panelMovieManagement.Visible = false;
            panelUserManagement.Visible = false;
            panelReviewManagement.Visible = true;

            LoadReviews();
        }

        // =====================================================
        // DASHBOARD BUTTON
        // =====================================================

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ShowOverview();
            LoadDashboardCounts();
        }

        // =====================================================
        // MOVIES BUTTON
        // =====================================================

        private void btnMovies_Click(object sender, EventArgs e)
        {
            ShowMovies();
        }

        // =====================================================
        // USERS BUTTON
        // =====================================================

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowUsers();
        }

        // =====================================================
        // REVIEWS BUTTON
        // =====================================================

        private void btnReviews_Click(object sender, EventArgs e)
        {
            ShowReviews();
        }

        // =====================================================
        // LOAD MOVIES
        // =====================================================

        private void LoadMovies()
        {
            try
            {
                List<Movie> movies = movieService.GetAll();

                dataGridMovies.DataSource = null;
                dataGridMovies.DataSource = movies;

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
                return;

            if (dataGridMovies.Columns["MovieId"] != null)
                dataGridMovies.Columns["MovieId"].Visible = false;

            if (dataGridMovies.Columns["PosterPath"] != null)
                dataGridMovies.Columns["PosterPath"].Visible = false;

            if (dataGridMovies.Columns["Title"] != null)
                dataGridMovies.Columns["Title"].HeaderText = "Title";

            if (dataGridMovies.Columns["Description"] != null)
                dataGridMovies.Columns["Description"].HeaderText = "Description";

            if (dataGridMovies.Columns["ReleaseYear"] != null)
                dataGridMovies.Columns["ReleaseYear"].HeaderText = "Year";

            if (dataGridMovies.Columns["Genre"] != null)
                dataGridMovies.Columns["Genre"].HeaderText = "Genre";

            if (dataGridMovies.Columns["Director"] != null)
                dataGridMovies.Columns["Director"].HeaderText = "Director";

            dataGridMovies.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridMovies.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridMovies.MultiSelect = false;
            dataGridMovies.ReadOnly = true;
            dataGridMovies.AllowUserToAddRows = false;

            RemoveMovieDeleteColumn();

            DataGridViewButtonColumn deleteColumn =
                new DataGridViewButtonColumn();

            deleteColumn.Name = "DeleteMovie";
            deleteColumn.HeaderText = "Action";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Width = 80;
            deleteColumn.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;

            dataGridMovies.Columns.Add(deleteColumn);

            dataGridMovies.Columns["DeleteMovie"].DisplayIndex =
                dataGridMovies.Columns.Count - 1;

            dataGridMovies.CellContentClick -=
                dataGridMovies_CellContentClick;

            dataGridMovies.CellContentClick +=
                dataGridMovies_CellContentClick;
        }

        // =====================================================
        // REMOVE MOVIE DELETE COLUMN
        // =====================================================

        private void RemoveMovieDeleteColumn()
        {
            if (dataGridMovies.Columns["DeleteMovie"] != null)
                dataGridMovies.Columns.Remove("DeleteMovie");
        }

        // =====================================================
        // MOVIE DELETE BUTTON
        // =====================================================

        private void dataGridMovies_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridMovies.Columns[e.ColumnIndex].Name !=
                "DeleteMovie")
                return;

            DataGridViewRow row =
                dataGridMovies.Rows[e.RowIndex];

            if (row.Cells["MovieId"].Value == null)
            {
                MessageBox.Show(
                    "Unable to identify this movie.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int movieId =
                Convert.ToInt32(row.Cells["MovieId"].Value);

            string movieTitle =
                row.Cells["Title"].Value?.ToString() ?? "";

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this movie?\n\n" +
                    "Movie: " + movieTitle,
                    "Delete Movie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result != DialogResult.Yes)
                return;

            DeleteMovie(movieId);
        }

        // =====================================================
        // DELETE MOVIE
        // =====================================================

        private void DeleteMovie(int movieId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                           connection.BeginTransaction())
                    {
                        try
                        {
                            string[] queries =
                            {
                                "DELETE FROM Reviews WHERE MovieId = @MovieId",
                                "DELETE FROM Favorites WHERE MovieId = @MovieId",
                                "DELETE FROM Watchlist WHERE MovieId = @MovieId",
                                "DELETE FROM Movies WHERE MovieId = @MovieId"
                            };

                            foreach (string query in queries)
                            {
                                using (SqlCommand command =
                                       new SqlCommand(
                                           query,
                                           connection,
                                           transaction))
                                {
                                    command.Parameters.AddWithValue(
                                        "@MovieId",
                                        movieId
                                    );

                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "Movie deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadMovies();
                LoadReviews();
                LoadDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete movie.\n\n" +
                    ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // SEARCH MOVIES
        // =====================================================

        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText =
                    txtSearchMovie.Text.Trim();

                List<Movie> movies =
                    movieService.SearchMovies(
                        searchText,
                        "All"
                    );

                dataGridMovies.DataSource = null;
                dataGridMovies.DataSource = movies;

                ConfigureMovieGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to search movies.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // ADD MOVIE - MOVIE MANAGEMENT
        // =====================================================

        private void btnAddNewmovies_Click(object sender, EventArgs e)
        {
            using (AddMovie addMovieForm = new AddMovie())
            {
                DialogResult result =
                    addMovieForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    LoadMovies();
                    LoadDashboardCounts();
                }
            }
        }

        // =====================================================
        // ADD MOVIE - QUICK ACTION
        // =====================================================

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            using (AddMovie addMovieForm = new AddMovie())
            {
                DialogResult result =
                    addMovieForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    LoadMovies();
                    LoadDashboardCounts();
                }
            }
        }

        // =====================================================
        // EDIT MOVIE - MOVIE MANAGEMENT
        // =====================================================

        private void btnEditNewMovie_Click(object sender, EventArgs e)
        {
            EditSelectedMovie();
        }

        // =====================================================
        // EDIT MOVIE - QUICK ACTION
        // =====================================================

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            ShowMovies();

            MessageBox.Show(
                "Select a movie from the list and then click Edit Movie.",
                "Edit Movie",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // =====================================================
        // EDIT SELECTED MOVIE
        // =====================================================

        private void EditSelectedMovie()
        {
            if (dataGridMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a movie first.",
                    "Edit Movie",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DataGridViewRow row =
                dataGridMovies.SelectedRows[0];

            if (row.Cells["MovieId"].Value == null)
            {
                MessageBox.Show(
                    "Unable to identify the selected movie.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int movieId =
                Convert.ToInt32(row.Cells["MovieId"].Value);

            using (EditMovie editMovieForm =
                   new EditMovie(movieId))
            {
                DialogResult result =
                    editMovieForm.ShowDialog(this);

                if (result == DialogResult.OK)
                {
                    LoadMovies();
                    LoadDashboardCounts();
                }
            }
        }

        // =====================================================
        // LOAD USERS
        // =====================================================

        private void LoadUsers()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    string query = @"
                        SELECT
                            UserId,
                            Name,
                            Email,
                            Role,
                            DateRegistered
                        FROM Users
                        WHERE Role <> 'Admin'
                        ORDER BY UserId DESC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dataGridUsers.DataSource = null;
                            dataGridUsers.DataSource = table;
                        }
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
            if (dataGridUsers.Columns.Count == 0)
                return;

            if (dataGridUsers.Columns["UserId"] != null)
                dataGridUsers.Columns["UserId"].Visible = false;

            if (dataGridUsers.Columns["Name"] != null)
                dataGridUsers.Columns["Name"].HeaderText = "Name";

            if (dataGridUsers.Columns["Email"] != null)
                dataGridUsers.Columns["Email"].HeaderText = "Email";

            if (dataGridUsers.Columns["Role"] != null)
                dataGridUsers.Columns["Role"].HeaderText = "Role";

            if (dataGridUsers.Columns["DateRegistered"] != null)
                dataGridUsers.Columns["DateRegistered"].HeaderText =
                    "Registered Date";

            dataGridUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridUsers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridUsers.MultiSelect = false;
            dataGridUsers.ReadOnly = true;
            dataGridUsers.AllowUserToAddRows = false;

            RemoveUserDeleteColumn();

            DataGridViewButtonColumn deleteColumn =
                new DataGridViewButtonColumn();

            deleteColumn.Name = "DeleteUser";
            deleteColumn.HeaderText = "Action";
            deleteColumn.Text = "Delete";
            deleteColumn.UseColumnTextForButtonValue = true;
            deleteColumn.Width = 80;
            deleteColumn.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.None;

            dataGridUsers.Columns.Add(deleteColumn);

            dataGridUsers.Columns["DeleteUser"].DisplayIndex =
                dataGridUsers.Columns.Count - 1;

            dataGridUsers.CellContentClick -=
                dataGridUsers_CellContentClick;

            dataGridUsers.CellContentClick +=
                dataGridUsers_CellContentClick;
        }

        // =====================================================
        // REMOVE USER DELETE COLUMN
        // =====================================================

        private void RemoveUserDeleteColumn()
        {
            if (dataGridUsers.Columns["DeleteUser"] != null)
                dataGridUsers.Columns.Remove("DeleteUser");
        }

        // =====================================================
        // USER DELETE BUTTON
        // =====================================================

        private void dataGridUsers_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridUsers.Columns[e.ColumnIndex].Name !=
                "DeleteUser")
                return;

            DataGridViewRow row =
                dataGridUsers.Rows[e.RowIndex];

            if (row.Cells["UserId"].Value == null)
            {
                MessageBox.Show(
                    "Unable to identify this user.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            int userId =
                Convert.ToInt32(row.Cells["UserId"].Value);

            string userName =
                row.Cells["Name"].Value?.ToString() ?? "";

            if (userId == GetCurrentUserId())
            {
                MessageBox.Show(
                    "You cannot delete the currently logged-in admin.",
                    "Delete User",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this user?\n\n" +
                    "User: " + userName +
                    "\n\nAll reviews, favorites and watchlist items " +
                    "of this user will also be removed.",
                    "Delete User",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result != DialogResult.Yes)
                return;

            DeleteUser(userId);
        }

        // =====================================================
        // GET CURRENT USER ID
        // =====================================================

        private int GetCurrentUserId()
        {
            try
            {
                return Session.UserID;
            }
            catch
            {
                return -1;
            }
        }

        // =====================================================
        // DELETE USER
        // =====================================================

        private void DeleteUser(int userId)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                           connection.BeginTransaction())
                    {
                        try
                        {
                            string[] queries =
                            {
                                "DELETE FROM Reviews WHERE UserId = @UserId",
                                "DELETE FROM Favorites WHERE UserId = @UserId",
                                "DELETE FROM Watchlist WHERE UserId = @UserId",
                                "DELETE FROM Users WHERE UserId = @UserId"
                            };

                            foreach (string query in queries)
                            {
                                using (SqlCommand command =
                                       new SqlCommand(
                                           query,
                                           connection,
                                           transaction))
                                {
                                    command.Parameters.AddWithValue(
                                        "@UserId",
                                        userId
                                    );

                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show(
                    "User deleted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LoadUsers();
                LoadReviews();
                LoadDashboardCounts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete user.\n\n" +
                    ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // SEARCH USERS
        // =====================================================

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    string query = @"
                        SELECT
                            UserId,
                            Name,
                            Email,
                            Role,
                            DateRegistered
                        FROM Users
                        WHERE
                            Role <> 'Admin'
                            AND
                            (
                                Name LIKE '%' + @Search + '%'
                                OR Email LIKE '%' + @Search + '%'
                            )
                        ORDER BY UserId DESC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            txtSearchUser.Text.Trim()
                        );

                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dataGridUsers.DataSource = null;
                            dataGridUsers.DataSource = table;
                        }
                    }
                }

                ConfigureUserGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to search users.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // LOAD REVIEWS
        // =====================================================

        private void LoadReviews()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    string query = @"
                        SELECT
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
                        ORDER BY r.ReviewDate DESC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dataGridReviews.DataSource = null;
                            dataGridReviews.DataSource = table;
                        }
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
            if (dataGridReviews.Columns.Count == 0)
                return;

            if (dataGridReviews.Columns["UserName"] != null)
                dataGridReviews.Columns["UserName"].HeaderText = "User";

            if (dataGridReviews.Columns["MovieTitle"] != null)
                dataGridReviews.Columns["MovieTitle"].HeaderText = "Movie";

            if (dataGridReviews.Columns["Rating"] != null)
                dataGridReviews.Columns["Rating"].HeaderText = "Rating";

            if (dataGridReviews.Columns["ReviewText"] != null)
                dataGridReviews.Columns["ReviewText"].HeaderText = "Review";

            if (dataGridReviews.Columns["ReviewDate"] != null)
                dataGridReviews.Columns["ReviewDate"].HeaderText = "Date";

            dataGridReviews.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridReviews.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridReviews.ReadOnly = true;
            dataGridReviews.AllowUserToAddRows = false;
        }

        // =====================================================
        // SEARCH REVIEWS
        // =====================================================

        private void btnSearchReview_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    string query = @"
                        SELECT
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
                        WHERE
                            u.Name LIKE '%' + @Search + '%'
                            OR m.Title LIKE '%' + @Search + '%'
                            OR r.ReviewText LIKE '%' + @Search + '%'
                        ORDER BY r.ReviewDate DESC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            txtSearchReview.Text.Trim()
                        );

                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            dataGridReviews.DataSource = null;
                            dataGridReviews.DataSource = table;
                        }
                    }
                }

                ConfigureReviewGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to search reviews.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // DASHBOARD COUNTS
        // =====================================================

        private void LoadDashboardCounts()
        {
            try
            {
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    // MOVIES
                    using (SqlCommand command =
                           new SqlCommand(
                               "SELECT COUNT(*) FROM Movies",
                               connection))
                    {
                        int count =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblMovieNumber.Text = count.ToString();
                        lblTotalMovies.Text = "Total Movies";
                    }

                    // USERS - ADMIN EXCLUDED
                    using (SqlCommand command =
                           new SqlCommand(
                               "SELECT COUNT(*) FROM Users WHERE Role <> 'Admin'",
                               connection))
                    {
                        int count =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblUserNumber.Text = count.ToString();
                        lblTotalUsers.Text = "Total Users";
                    }

                    // REVIEWS
                    using (SqlCommand command =
                           new SqlCommand(
                               "SELECT COUNT(*) FROM Reviews",
                               connection))
                    {
                        int count =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblReviewNumber.Text = count.ToString();
                        lblTotalReviews.Text = "Total Reviews";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load dashboard data.\n\n" +
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
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                Session.Clear();

                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                this.Close();
            }
        }

        // =====================================================
        // PAINT EVENTS
        // =====================================================

        private void panelReviewManagement_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void panelQuickAction_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void panelReviewCard_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void panelUserCard_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void panelMovieCard_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}