using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MovieReviewApp.Models;
using MovieReviewApp.Services;

namespace MovieReviewApp.Forms
{
    public partial class AdminPanel : Form
    {
        private MovieService movieService;

        public AdminPanel()
        {
            InitializeComponent();

            movieService = new MovieService();

            this.Load += AdminPanel_Load;
        }

        // =====================================================
        // FORM LOAD
        // =====================================================

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            ShowOverview();

            LoadDashboardCounts();
            LoadMovies();
            LoadUsers();
            LoadReviews();
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
                List<Movie> movies =
                    movieService.GetAll();

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
                dataGridMovies.Columns["MovieId"].HeaderText = "ID";

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

            if (dataGridMovies.Columns["PosterPath"] != null)
                dataGridMovies.Columns["PosterPath"].HeaderText = "Poster Path";

            dataGridMovies.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridMovies.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dataGridMovies.MultiSelect = false;

            dataGridMovies.ReadOnly = true;

            dataGridMovies.AllowUserToAddRows = false;
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
            OpenAddMovieForm();
        }

        // =====================================================
        // ADD MOVIE - QUICK ACTION
        // =====================================================

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            OpenAddMovieForm();
        }

        // =====================================================
        // OPEN ADD MOVIE FORM
        // =====================================================

        private void OpenAddMovieForm()
        {
            try
            {
                using (AddMovie addMovieForm =
                       new AddMovie())
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
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to open Add Movie form.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
                Convert.ToInt32(
                    row.Cells["MovieId"].Value
                );

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to open Edit Movie form.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // LOAD USERS
        // =====================================================

        private void LoadUsers()
        {
            try
            {
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    string query = @"
                        SELECT
                            UserId,
                            Name,
                            Email,
                            Role,
                            DateRegistered
                        FROM dbo.Users
                        ORDER BY UserId DESC";

                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dataGridUsers.DataSource =
                                table;
                        }
                    }
                }

                dataGridUsers.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                dataGridUsers.SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect;

                dataGridUsers.MultiSelect = false;

                dataGridUsers.ReadOnly = true;

                dataGridUsers.AllowUserToAddRows = false;
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
        // SEARCH USERS
        // =====================================================

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    string query = @"
                        SELECT
                            UserId,
                            Name,
                            Email,
                            Role,
                            DateRegistered
                        FROM dbo.Users
                        WHERE
                            Name LIKE '%' + @Search + '%'
                            OR Email LIKE '%' + @Search + '%'
                        ORDER BY UserId DESC";

                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            txtSearchUser.Text.Trim()
                        );

                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dataGridUsers.DataSource =
                                table;
                        }
                    }
                }
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
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    string query = @"
                        SELECT
                            r.ReviewId,
                            u.Name AS UserName,
                            m.Title AS MovieTitle,
                            r.Rating,
                            r.ReviewText,
                            r.ReviewDate
                        FROM dbo.Reviews r
                        INNER JOIN dbo.Users u
                            ON r.UserId = u.UserId
                        INNER JOIN dbo.Movies m
                            ON r.MovieId = m.MovieId
                        ORDER BY r.ReviewDate DESC";

                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dataGridReviews.DataSource =
                                table;
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

            if (dataGridReviews.Columns["ReviewId"] != null)
                dataGridReviews.Columns["ReviewId"].HeaderText = "ID";

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

            dataGridReviews.MultiSelect = false;

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
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    string query = @"
                        SELECT
                            r.ReviewId,
                            u.Name AS UserName,
                            m.Title AS MovieTitle,
                            r.Rating,
                            r.ReviewText,
                            r.ReviewDate
                        FROM dbo.Reviews r
                        INNER JOIN dbo.Users u
                            ON r.UserId = u.UserId
                        INNER JOIN dbo.Movies m
                            ON r.MovieId = m.MovieId
                        WHERE
                            u.Name LIKE '%' + @Search + '%'
                            OR m.Title LIKE '%' + @Search + '%'
                            OR r.ReviewText LIKE '%' + @Search + '%'
                        ORDER BY r.ReviewDate DESC";

                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Search",
                            txtSearchReview.Text.Trim()
                        );

                        connection.Open();

                        using (SqlDataAdapter adapter =
                               new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dataGridReviews.DataSource =
                                table;
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
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

                    // MOVIES COUNT
                    using (SqlCommand command =
                           new SqlCommand(
                               "SELECT COUNT(*) FROM dbo.Movies",
                               connection))
                    {
                        int count =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblMovieNumber.Text =
                            count.ToString();

                        lblTotalMovies.Text =
                            "Total Movies";
                    }

                    // USERS COUNT
                    using (SqlCommand command =
                           new SqlCommand(
                               "SELECT COUNT(*) FROM dbo.Users",
                               connection))
                    {
                        int count =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblUserNumber.Text =
                            count.ToString();

                        lblTotalUsers.Text =
                            "Total Users";
                    }

                    // REVIEWS COUNT
                    using (SqlCommand command =
                           new SqlCommand(
                               "SELECT COUNT(*) FROM dbo.Reviews",
                               connection))
                    {
                        int count =
                            Convert.ToInt32(
                                command.ExecuteScalar()
                            );

                        lblReviewNumber.Text =
                            count.ToString();

                        lblTotalReviews.Text =
                            "Total Reviews";
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

        private void btnLogout_Click(object sender, EventArgs e)
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
                this.Hide();

                Form1 loginForm =
                    new Form1();

                loginForm.Show();
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