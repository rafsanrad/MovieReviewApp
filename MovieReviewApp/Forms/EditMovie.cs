using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class EditMovie : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        private int movieId;

        public EditMovie(int movieId)
        {
            InitializeComponent();

            this.movieId = movieId;

            LoadMovie();
        }

        // =====================================================
        // LOAD MOVIE
        // =====================================================

        private void LoadMovie()
        {
            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            Title,
                            Description,
                            ReleaseYear,
                            Genre,
                            Director,
                            PosterPath
                        FROM Movies
                        WHERE MovieId = @MovieId";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@MovieId",
                            movieId
                        );

                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtTitle.Text =
                                    reader["Title"].ToString();

                                txtDescription.Text =
                                    reader["Description"] ==
                                    DBNull.Value
                                    ? ""
                                    : reader["Description"].ToString();

                                txtReleaseYear.Text =
                                    reader["ReleaseYear"] ==
                                    DBNull.Value
                                    ? ""
                                    : reader["ReleaseYear"].ToString();

                                txtGenre.Text =
                                    reader["Genre"] ==
                                    DBNull.Value
                                    ? ""
                                    : reader["Genre"].ToString();

                                txtDirector.Text =
                                    reader["Director"] ==
                                    DBNull.Value
                                    ? ""
                                    : reader["Director"].ToString();

                                txtPosterPath.Text =
                                    reader["PosterPath"] ==
                                    DBNull.Value
                                    ? ""
                                    : reader["PosterPath"].ToString();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Movie not found.",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                );

                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load movie.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // BROWSE POSTER
        // =====================================================

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog =
                   new OpenFileDialog())
            {
                dialog.Title =
                    "Select Movie Poster";

                dialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() ==
                    DialogResult.OK)
                {
                    txtPosterPath.Text =
                        dialog.FileName;
                }
            }
        }

        // =====================================================
        // UPDATE MOVIE
        // =====================================================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title =
                txtTitle.Text.Trim();

            string description =
                txtDescription.Text.Trim();

            string genre =
                txtGenre.Text.Trim();

            string director =
                txtDirector.Text.Trim();

            string posterPath =
                txtPosterPath.Text.Trim();

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show(
                    "Please enter movie title.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrEmpty(genre))
            {
                MessageBox.Show(
                    "Please enter movie genre.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtGenre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(director))
            {
                MessageBox.Show(
                    "Please enter director name.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtDirector.Focus();
                return;
            }

            if (!int.TryParse(
                    txtReleaseYear.Text.Trim(),
                    out int releaseYear))
            {
                MessageBox.Show(
                    "Please enter a valid release year.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtReleaseYear.Focus();
                return;
            }

            try
            {
                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        UPDATE Movies
                        SET
                            Title = @Title,
                            Description = @Description,
                            ReleaseYear = @ReleaseYear,
                            Genre = @Genre,
                            Director = @Director,
                            PosterPath = @PosterPath
                        WHERE MovieId = @MovieId";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Title",
                            title
                        );

                        command.Parameters.AddWithValue(
                            "@Description",
                            description
                        );

                        command.Parameters.AddWithValue(
                            "@ReleaseYear",
                            releaseYear
                        );

                        command.Parameters.AddWithValue(
                            "@Genre",
                            genre
                        );

                        command.Parameters.AddWithValue(
                            "@Director",
                            director
                        );

                        command.Parameters.AddWithValue(
                            "@PosterPath",
                            posterPath
                        );

                        command.Parameters.AddWithValue(
                            "@MovieId",
                            movieId
                        );

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Movie updated successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to update movie.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // CANCEL
        // =====================================================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {

        }
    }
}