using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class ReviewForm : Form
    {
        private int movieId;
        private string movieName;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public ReviewForm(
            int movieId,
            string movieName)
        {
            InitializeComponent();

            this.movieId = movieId;
            this.movieName = movieName;

            lblMovieName.Text =
                movieName;

            cmbRating.SelectedIndex = -1;

            btnSubmit.Click +=
                btnSubmit_Click;

            btnCancel.Click +=
                btnCancel_Click;
        }

        // =====================================================
        // SUBMIT REVIEW
        // =====================================================

        private void btnSubmit_Click(
            object sender,
            EventArgs e)
        {
            // =================================================
            // CHECK LOGIN
            // =================================================

            if (Session.UserId <= 0)
            {
                MessageBox.Show(
                    "User session not found. Please login again.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // =================================================
            // CHECK RATING
            // =================================================

            if (cmbRating.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a rating.",
                    "Rating Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // =================================================
            // CHECK REVIEW
            // =================================================

            string reviewText =
                txtReviewComment.Text.Trim();

            if (string.IsNullOrEmpty(reviewText))
            {
                MessageBox.Show(
                    "Please write your review.",
                    "Review Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // =================================================
            // GET RATING
            // =================================================

            int rating =
                cmbRating.SelectedIndex + 1;

            // =================================================
            // SAVE REVIEW
            // =================================================

            try
            {
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Reviews
                        (
                            UserId,
                            MovieId,
                            Rating,
                            ReviewText
                        )
                        VALUES
                        (
                            @UserId,
                            @MovieId,
                            @Rating,
                            @ReviewText
                        )";

                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@UserId",
                            Session.UserId
                        );

                        command.Parameters.AddWithValue(
                            "@MovieId",
                            movieId
                        );

                        command.Parameters.AddWithValue(
                            "@Rating",
                            rating
                        );

                        command.Parameters.AddWithValue(
                            "@ReviewText",
                            reviewText
                        );

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Review submitted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult =
                    DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to submit review.\n\n" +
                    ex.Message,
                    "Review Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // CANCEL
        // =====================================================

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
            this.DialogResult =
                DialogResult.Cancel;

            this.Close();
        }

        // =====================================================
        // PANEL PAINT
        // =====================================================

        private void pnlReview_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}