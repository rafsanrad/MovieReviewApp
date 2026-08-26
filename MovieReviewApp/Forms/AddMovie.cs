using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class AddMovie : Form
    {
        private DatabaseHelper db = new DatabaseHelper();

        public AddMovie()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Title = "Select Movie Poster";
                dialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtPosterPath.Text = dialog.FileName;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string genre = txtGenre.Text.Trim();
            string director = txtDirector.Text.Trim();
            string posterPath = txtPosterPath.Text.Trim();

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
                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Movies
                        (
                            Title,
                            Description,
                            ReleaseYear,
                            Genre,
                            Director,
                            PosterPath
                        )
                        VALUES
                        (
                            @Title,
                            @Description,
                            @ReleaseYear,
                            @Genre,
                            @Director,
                            @PosterPath
                        )";

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

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Movie added successfully!",
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
                    "Failed to add movie.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}