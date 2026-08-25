using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class ReviewForm : Form
    {
        private int movieId;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public ReviewForm(int movieId, string movieName)
        {
            InitializeComponent();

            this.movieId = movieId;

            // Show selected movie name
            lblMovieName.Text = movieName;

            // No rating selected initially
            cmbRating.SelectedIndex = -1;

            // Connect button events
            btnSubmit.Click += btnSubmit_Click;
            btnCancel.Click += btnCancel_Click;
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
                    "Please login first.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
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
            // CHECK REVIEW TEXT
            // =================================================

            string reviewText =
                txtReviewComment.Text.Trim();

            if (string.IsNullOrWhiteSpace(reviewText))
            {
                MessageBox.Show(
                    "Please write your review.",
                    "Review Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtReviewComment.Focus();

                return;
            }

            // =================================================
            // GET RATING VALUE
            // =================================================

            int rating =
                cmbRating.SelectedIndex + 1;

            // =================================================
            // SAVE REVIEW TO DATABASE
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
                            ReviewText,
                            ReviewDate
                        )
                        VALUES
                        (
                            @UserId,
                            @MovieId,
                            @Rating,
                            @ReviewText,
                            GETDATE()
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

                // =================================================
                // SUCCESS MESSAGE
                // =================================================

                MessageBox.Show(
                    "Review submitted successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Tell HomeForm that review was submitted
                this.DialogResult =
                    DialogResult.OK;

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to submit review.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // CANCEL BUTTON
        // =====================================================

        private void btnCancel_Click(
            object sender,
            EventArgs e)
        {
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