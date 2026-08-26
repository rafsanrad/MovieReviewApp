using MovieReviewApp.Forms;
using MovieReviewApp.Models;
using MovieReviewApp.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class HomeForm : Form
    {
        // =====================================================
        // SERVICES
        // =====================================================

        private MovieService movieService =
            new MovieService();

        private FavoriteService favoriteService =
            new FavoriteService();

        private WatchlistService watchlistService =
            new WatchlistService();

        private ReviewService reviewService =
            new ReviewService();

        // =====================================================
        // SELECTED MOVIE
        // =====================================================

        private Movie selectedMovie;

        // =====================================================
        // CONSTRUCTOR
        // =====================================================

        public HomeForm()
        {
            InitializeComponent();

            if (cmbGenre.Items.Count > 0)
            {
                cmbGenre.SelectedIndex = 0;
            }

            flowMovies.Visible = true;
            panelMovieDetails.Visible = false;
            panelProfile.Visible = false;
        }

        // =====================================================
        // FORM LOAD
        // =====================================================

        private void HomeForm_Load(
            object sender,
            EventArgs e)
        {
            ShowHomePage();
        }

        // =====================================================
        // HOME BUTTON
        // =====================================================

        private void btnHome_Click(
            object sender,
            EventArgs e)
        {
            ShowHomePage();
        }

        // =====================================================
        // SHOW HOME PAGE
        // =====================================================

        private void ShowHomePage()
        {
            selectedMovie = null;

            lblSearch.Visible = true;
            txtSearch.Visible = true;
            btnSearch.Visible = true;
            lblGenre.Visible = true;
            cmbGenre.Visible = true;

            flowMovies.Visible = true;
            panelMovieDetails.Visible = false;
            panelProfile.Visible = false;

            txtSearch.Text = "";

            if (cmbGenre.Items.Count > 0)
            {
                cmbGenre.SelectedIndex = 0;
            }

            LoadMovies();
        }

        // =====================================================
        // LOAD ALL MOVIES
        // =====================================================

        private void LoadMovies()
        {
            try
            {
                List<Movie> movies =
                    movieService.GetAll();

                DisplayMovies(movies);
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
        // DISPLAY MOVIES
        // =====================================================

        private void DisplayMovies(
            List<Movie> movies)
        {
            flowMovies.Controls.Clear();

            foreach (Movie movie in movies)
            {
                CreateMovieCard(movie);
            }

            flowMovies.Visible = true;
            panelMovieDetails.Visible = false;
            panelProfile.Visible = false;
        }

        // =====================================================
        // SEARCH BUTTON
        // =====================================================

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            SearchMovies();
        }

        // =====================================================
        // SEARCH MOVIES
        // =====================================================

        private void SearchMovies()
        {
            try
            {
                string searchText =
                    txtSearch.Text.Trim();

                string genre =
                    cmbGenre.SelectedItem == null
                    ? "All"
                    : cmbGenre.SelectedItem.ToString();

                List<Movie> movies =
                    movieService.SearchMovies(
                        searchText,
                        genre
                    );

                flowMovies.Controls.Clear();

                foreach (Movie movie in movies)
                {
                    CreateMovieCard(movie);
                }

                flowMovies.Visible = true;
                panelMovieDetails.Visible = false;
                panelProfile.Visible = false;

                if (movies.Count == 0)
                {
                    MessageBox.Show(
                        "No movies found.",
                        "Search Result",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" +
                    ex.Message,
                    "Search Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // GENRE CHANGE
        // =====================================================

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (panelProfile != null &&
                panelProfile.Visible)
            {
                return;
            }

            if (flowMovies != null &&
                flowMovies.Visible)
            {
                SearchMovies();
            }
        }

        // =====================================================
        // CREATE MOVIE CARD
        // =====================================================

        private void CreateMovieCard(
            Movie movie,
            bool isFavorite = false,
            bool isWatchlist = false)
        {
            Panel movieCard =
                new Panel();

            movieCard.Width = 200;
            movieCard.Height = 330;

            movieCard.BorderStyle =
                BorderStyle.FixedSingle;

            movieCard.Margin =
                new Padding(10);

            // =================================================
            // POSTER
            // =================================================

            PictureBox poster =
                new PictureBox();

            poster.Width = 180;
            poster.Height = 200;

            poster.Location =
                new Point(10, 10);

            poster.SizeMode =
                PictureBoxSizeMode.StretchImage;

            poster.BackColor =
                Color.LightGray;

            LoadPoster(
                poster,
                movie.PosterPath
            );

            // =================================================
            // TITLE
            // =================================================

            Label lblMovieTitle =
                new Label();

            lblMovieTitle.Text =
                movie.Title;

            lblMovieTitle.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            lblMovieTitle.AutoSize = false;
            lblMovieTitle.Width = 180;
            lblMovieTitle.Height = 30;

            lblMovieTitle.Location =
                new Point(10, 215);

            // =================================================
            // GENRE + YEAR
            // =================================================

            Label lblMovieInfo =
                new Label();

            lblMovieInfo.Text =
                movie.Genre +
                " • " +
                movie.ReleaseYear;

            lblMovieInfo.AutoSize = false;
            lblMovieInfo.Width = 180;
            lblMovieInfo.Height = 25;

            lblMovieInfo.Location =
                new Point(10, 245);

            // =================================================
            // DETAILS BUTTON
            // =================================================

            Button btnDetails =
                new Button();

            btnDetails.Text =
                "Details";

            btnDetails.Width = 80;
            btnDetails.Height = 35;

            btnDetails.Location =
                new Point(10, 280);

            btnDetails.Tag =
                movie;

            btnDetails.Click +=
                BtnDetails_Click;

            movieCard.Controls.Add(
                btnDetails
            );

            // =================================================
            // REMOVE FAVORITE
            // =================================================

            if (isFavorite)
            {
                Button btnRemoveFavorite =
                    new Button();

                btnRemoveFavorite.Text =
                    "Remove";

                btnRemoveFavorite.Width = 80;
                btnRemoveFavorite.Height = 35;

                btnRemoveFavorite.Location =
                    new Point(100, 280);

                btnRemoveFavorite.Tag =
                    movie;

                btnRemoveFavorite.Click +=
                    BtnRemoveFavorite_Click;

                movieCard.Controls.Add(
                    btnRemoveFavorite
                );
            }

            // =================================================
            // REMOVE WATCHLIST
            // =================================================

            if (isWatchlist)
            {
                Button btnRemoveWatchlist =
                    new Button();

                btnRemoveWatchlist.Text =
                    "Remove";

                btnRemoveWatchlist.Width = 80;
                btnRemoveWatchlist.Height = 35;

                btnRemoveWatchlist.Location =
                    new Point(100, 280);

                btnRemoveWatchlist.Tag =
                    movie;

                btnRemoveWatchlist.Click +=
                    BtnRemoveWatchlist_Click;

                movieCard.Controls.Add(
                    btnRemoveWatchlist
                );
            }

            movieCard.Controls.Add(
                poster
            );

            movieCard.Controls.Add(
                lblMovieTitle
            );

            movieCard.Controls.Add(
                lblMovieInfo
            );

            flowMovies.Controls.Add(
                movieCard
            );
        }

        // =====================================================
        // LOAD POSTER
        // =====================================================

        private void LoadPoster(
            PictureBox pictureBox,
            string posterPath)
        {
            pictureBox.BackColor =
                Color.LightGray;

            pictureBox.Image = null;

            if (string.IsNullOrEmpty(posterPath))
            {
                return;
            }

            string imagePath =
                System.IO.Path.Combine(
                    Application.StartupPath,
                    posterPath
                );

            if (!System.IO.File.Exists(imagePath))
            {
                return;
            }

            try
            {
                using (
                    System.IO.FileStream stream =
                    new System.IO.FileStream(
                        imagePath,
                        System.IO.FileMode.Open,
                        System.IO.FileAccess.Read
                    )
                )
                {
                    pictureBox.Image =
                        new Bitmap(stream);
                }
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        // =====================================================
        // DETAILS BUTTON
        // =====================================================

        private void BtnDetails_Click(
            object sender,
            EventArgs e)
        {
            Button clickedButton =
                sender as Button;

            if (clickedButton == null)
            {
                return;
            }

            Movie movie =
                clickedButton.Tag as Movie;

            if (movie == null)
            {
                MessageBox.Show(
                    "Movie data not found."
                );

                return;
            }

            selectedMovie =
                movie;

            ShowMovieDetails(
                movie
            );
        }

        // =====================================================
        // SHOW MOVIE DETAILS
        // =====================================================

        private void ShowMovieDetails(
            Movie movie)
        {
            if (movie == null)
            {
                return;
            }

            selectedMovie =
                movie;

            panelProfile.Visible =
                false;

            lblSearch.Visible =
                false;

            txtSearch.Visible =
                false;

            btnSearch.Visible =
                false;

            lblGenre.Visible =
                false;

            cmbGenre.Visible =
                false;

            flowMovies.Visible =
                false;

            panelMovieDetails.Visible =
                true;

            panelMovieDetails.Enabled =
                true;

            panelMovieDetails.BringToFront();

            lblDetailTitle.Text =
                movie.Title;

            lblDetailGenre.Text =
                "Genre: " +
                movie.Genre;

            lblDetailYear.Text =
                "Release Year: " +
                movie.ReleaseYear;

            if (string.IsNullOrEmpty(
                movie.Director))
            {
                lblDirector.Text =
                    "Director: Unknown";
            }
            else
            {
                lblDirector.Text =
                    "Director: " +
                    movie.Director;
            }

            if (string.IsNullOrEmpty(
                movie.Description))
            {
                lblDescription.Text =
                    "No description available.";
            }
            else
            {
                lblDescription.Text =
                    movie.Description;
            }

            if (pictureBoxDetails.Image != null)
            {
                pictureBoxDetails.Image.Dispose();

                pictureBoxDetails.Image =
                    null;
            }

            LoadPoster(
                pictureBoxDetails,
                movie.PosterPath
            );

            // Load reviews
            LoadReviews(
                movie.MovieId
            );
        }

        // =====================================================
        // ADD REVIEW BUTTON
        // =====================================================

        private void btnReview_Click(
            object sender,
            EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show(
                    "Please select a movie first."
                );

                return;
            }

            if (Session.UserId <= 0)
            {
                MessageBox.Show(
                    "User session not found. Please login again."
                );

                return;
            }

            ReviewForm reviewForm =
                new ReviewForm(
                    selectedMovie.MovieId,
                    selectedMovie.Title
                );

            reviewForm.ShowDialog();

            if (selectedMovie != null)
            {
                LoadReviews(
                    selectedMovie.MovieId
                );
            }
        }

        // =====================================================
        // LOAD REVIEWS
        // =====================================================

        private void LoadReviews(
            int movieId)
        {
            try
            {
                flowReviews.Controls.Clear();

                List<Review> reviews =
                    reviewService.GetReviewsByMovie(
                        movieId
                    );

                // =================================================
                // NO REVIEWS
                // =================================================

                if (reviews == null ||
                    reviews.Count == 0)
                {
                    lblReviewCount.Text =
                        "Total Reviews: 0";

                    lblAverageRating.Text =
                        "Average Rating: 0 / 5";

                    Label noReview =
                        new Label();

                    noReview.Text =
                        "No reviews yet. Be the first to review this movie!";

                    noReview.AutoSize =
                        true;

                    noReview.Font =
                        new Font(
                            "Segoe UI",
                            9,
                            FontStyle.Italic
                        );

                    noReview.Margin =
                        new Padding(5);

                    flowReviews.Controls.Add(
                        noReview
                    );

                    return;
                }

                // =================================================
                // REVIEW COUNT
                // =================================================

                lblReviewCount.Text =
                    "Total Reviews: " +
                    reviews.Count;

                double totalRating =
                    0;

                // =================================================
                // DISPLAY REVIEWS
                // =================================================

                foreach (Review review in reviews)
                {
                    totalRating +=
                        review.Rating;

                    Panel reviewPanel =
                        new Panel();

                    reviewPanel.Width =
                        650;

                    reviewPanel.Height =
                        review.UserId == Session.UserId
                        ? 115
                        : 80;

                    reviewPanel.BorderStyle =
                        BorderStyle.FixedSingle;

                    reviewPanel.Margin =
                        new Padding(5);

                    // =================================================
                    // USER + RATING
                    // =================================================

                    Label lblUser =
                        new Label();

                    lblUser.AutoSize =
                        true;

                    lblUser.Font =
                        new Font(
                            "Segoe UI",
                            9,
                            FontStyle.Bold
                        );

                    lblUser.Location =
                        new Point(
                            10,
                            8
                        );

                    lblUser.Text =
                        review.UserName +
                        "  |  Rating: " +
                        review.Rating +
                        "/5";

                    // =================================================
                    // COMMENT
                    // =================================================

                    Label lblComment =
                        new Label();

                    lblComment.AutoSize =
                        false;

                    lblComment.Width =
                        620;

                    lblComment.Height =
                        40;

                    lblComment.Location =
                        new Point(
                            10,
                            32
                        );

                    lblComment.Text =
                        string.IsNullOrEmpty(
                            review.Comment)
                        ? "No comment."
                        : review.Comment;

                    reviewPanel.Controls.Add(
                        lblUser
                    );

                    reviewPanel.Controls.Add(
                        lblComment
                    );

                    // =================================================
                    // EDIT + DELETE
                    // ONLY FOR CURRENT USER
                    // =================================================

                    if (review.UserId ==
                        Session.UserId)
                    {
                        Button btnEdit =
                            new Button();

                        btnEdit.Text =
                            "Edit";

                        btnEdit.Width =
                            70;

                        btnEdit.Height =
                            28;

                        btnEdit.Location =
                            new Point(
                                10,
                                75
                            );

                        btnEdit.Tag =
                            review;

                        btnEdit.Click +=
                            BtnEditReview_Click;

                        reviewPanel.Controls.Add(
                            btnEdit
                        );

                        Button btnDelete =
                            new Button();

                        btnDelete.Text =
                            "Delete";

                        btnDelete.Width =
                            70;

                        btnDelete.Height =
                            28;

                        btnDelete.Location =
                            new Point(
                                90,
                                75
                            );

                        btnDelete.Tag =
                            review;

                        btnDelete.Click +=
                            BtnDeleteReview_Click;

                        reviewPanel.Controls.Add(
                            btnDelete
                        );
                    }

                    flowReviews.Controls.Add(
                        reviewPanel
                    );
                }

                // =================================================
                // AVERAGE RATING
                // =================================================

                double average =
                    totalRating /
                    reviews.Count;

                lblAverageRating.Text =
                    "Average Rating: " +
                    average.ToString("0.0") +
                    " / 5";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load reviews.\n\n" +
                    ex.Message,
                    "Review Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // EDIT REVIEW BUTTON
        // =====================================================

        private void BtnEditReview_Click(
            object sender,
            EventArgs e)
        {
            Button clickedButton =
                sender as Button;

            if (clickedButton == null)
            {
                return;
            }

            Review review =
                clickedButton.Tag as Review;

            if (review == null)
            {
                return;
            }

            // Security check
            if (review.UserId !=
                Session.UserId)
            {
                MessageBox.Show(
                    "You can only edit your own review.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            ShowEditReviewForm(
                review
            );
        }

        // =====================================================
        // DELETE REVIEW BUTTON
        // =====================================================

        private void BtnDeleteReview_Click(
            object sender,
            EventArgs e)
        {
            Button clickedButton =
                sender as Button;

            if (clickedButton == null)
            {
                return;
            }

            Review review =
                clickedButton.Tag as Review;

            if (review == null)
            {
                return;
            }

            // Security check
            if (review.UserId !=
                Session.UserId)
            {
                MessageBox.Show(
                    "You can only delete your own review.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete your review?",
                    "Delete Review",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            if (result !=
                DialogResult.Yes)
            {
                return;
            }

            try
            {
                bool deleted =
                    reviewService.DeleteReview(
                        review.ReviewId,
                        Session.UserId
                    );

                if (deleted)
                {
                    MessageBox.Show(
                        "Review deleted successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    if (selectedMovie != null)
                    {
                        LoadReviews(
                            selectedMovie.MovieId
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Review could not be deleted.",
                        "Delete Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to delete review.\n\n" +
                    ex.Message,
                    "Delete Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // EDIT REVIEW FORM
        // =====================================================

        private void ShowEditReviewForm(
            Review review)
        {
            Form editForm =
                new Form();

            editForm.Text =
                "Edit Review";

            editForm.StartPosition =
                FormStartPosition.CenterParent;

            editForm.FormBorderStyle =
                FormBorderStyle.FixedDialog;

            editForm.MaximizeBox =
                false;

            editForm.MinimizeBox =
                false;

            editForm.ClientSize =
                new Size(
                    430,
                    300
                );

            // =================================================
            // TITLE
            // =================================================

            Label lblTitle =
                new Label();

            lblTitle.Text =
                "Edit Your Review";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    16,
                    FontStyle.Bold
                );

            lblTitle.AutoSize =
                true;

            lblTitle.Location =
                new Point(
                    25,
                    20
                );

            // =================================================
            // RATING LABEL
            // =================================================

            Label lblRating =
                new Label();

            lblRating.Text =
                "Rating:";

            lblRating.AutoSize =
                true;

            lblRating.Location =
                new Point(
                    25,
                    75
                );

            lblRating.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            // =================================================
            // RATING COMBOBOX
            // =================================================

            ComboBox cmbRating =
                new ComboBox();

            cmbRating.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbRating.Items.AddRange(
                new object[]
                {
                    "1",
                    "2",
                    "3",
                    "4",
                    "5"
                }
            );

            cmbRating.Location =
                new Point(
                    100,
                    72
                );

            cmbRating.Width =
                100;

            cmbRating.SelectedIndex =
                review.Rating - 1;

            // =================================================
            // COMMENT LABEL
            // =================================================

            Label lblComment =
                new Label();

            lblComment.Text =
                "Comment:";

            lblComment.AutoSize =
                true;

            lblComment.Location =
                new Point(
                    25,
                    115
                );

            lblComment.Font =
                new Font(
                    "Segoe UI",
                    10,
                    FontStyle.Bold
                );

            // =================================================
            // COMMENT TEXTBOX
            // =================================================

            TextBox txtComment =
                new TextBox();

            txtComment.Multiline =
                true;

            txtComment.ScrollBars =
                ScrollBars.Vertical;

            txtComment.Location =
                new Point(
                    100,
                    112
                );

            txtComment.Width =
                290;

            txtComment.Height =
                85;

            txtComment.Text =
                review.Comment ?? "";

            // =================================================
            // SAVE BUTTON
            // =================================================

            Button btnSave =
                new Button();

            btnSave.Text =
                "Save Changes";

            btnSave.Width =
                120;

            btnSave.Height =
                35;

            btnSave.Location =
                new Point(
                    100,
                    225
                );

            btnSave.Click +=
                delegate
                {
                    if (cmbRating.SelectedItem ==
                        null)
                    {
                        MessageBox.Show(
                            "Please select a rating."
                        );

                        return;
                    }

                    int newRating =
                        Convert.ToInt32(
                            cmbRating.SelectedItem
                        );

                    string newComment =
                        txtComment.Text.Trim();

                    try
                    {
                        bool updated =
                            reviewService.UpdateReview(
                                review.ReviewId,
                                Session.UserId,
                                newRating,
                                newComment
                            );

                        if (updated)
                        {
                            MessageBox.Show(
                                "Review updated successfully!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            editForm.Close();

                            if (selectedMovie != null)
                            {
                                LoadReviews(
                                    selectedMovie.MovieId
                                );
                            }
                        }
                        else
                        {
                            MessageBox.Show(
                                "Review could not be updated.",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Failed to update review.\n\n" +
                            ex.Message,
                            "Update Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                };

            // =================================================
            // CANCEL BUTTON
            // =================================================

            Button btnCancel =
                new Button();

            btnCancel.Text =
                "Cancel";

            btnCancel.Width =
                100;

            btnCancel.Height =
                35;

            btnCancel.Location =
                new Point(
                    230,
                    225
                );

            btnCancel.Click +=
                delegate
                {
                    editForm.Close();
                };

            // =================================================
            // ADD CONTROLS
            // =================================================

            editForm.Controls.Add(
                lblTitle
            );

            editForm.Controls.Add(
                lblRating
            );

            editForm.Controls.Add(
                cmbRating
            );

            editForm.Controls.Add(
                lblComment
            );

            editForm.Controls.Add(
                txtComment
            );

            editForm.Controls.Add(
                btnSave
            );

            editForm.Controls.Add(
                btnCancel
            );

            editForm.ShowDialog(
                this
            );
        }

        // =====================================================
        // REVIEW COUNT CLICK
        // =====================================================

        private void lblReviewCount_Click(
            object sender,
            EventArgs e)
        {
        }

        // =====================================================
        // FAVORITE
        // =====================================================

        private void btnFavorite_Click(
            object sender,
            EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show(
                    "Please select a movie first."
                );

                return;
            }

            if (Session.UserId <= 0)
            {
                MessageBox.Show(
                    "User session not found. Please login again."
                );

                return;
            }

            try
            {
                bool added =
                    favoriteService.AddToFavorite(
                        Session.UserId,
                        selectedMovie.MovieId
                    );

                if (added)
                {
                    MessageBox.Show(
                        selectedMovie.Title +
                        " added to favorites!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "This movie is already in your favorites."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to add favorite.\n\n" +
                    ex.Message
                );
            }
        }

        // =====================================================
        // FAVORITES SIDEBAR
        // =====================================================

        private void btnFavorites_Click(
            object sender,
            EventArgs e)
        {
            HideHomeControls();

            LoadFavoriteMovies();
        }

        // =====================================================
        // LOAD FAVORITES
        // =====================================================

        private void LoadFavoriteMovies()
        {
            try
            {
                if (Session.UserId <= 0)
                {
                    MessageBox.Show(
                        "User session not found. Please login again."
                    );

                    return;
                }

                List<Movie> favoriteMovies =
                    favoriteService.GetFavoriteMovies(
                        Session.UserId
                    );

                flowMovies.Controls.Clear();

                foreach (Movie movie in favoriteMovies)
                {
                    CreateMovieCard(
                        movie,
                        true,
                        false
                    );
                }

                flowMovies.Visible =
                    true;

                panelMovieDetails.Visible =
                    false;

                panelProfile.Visible =
                    false;

                if (favoriteMovies.Count == 0)
                {
                    MessageBox.Show(
                        "You haven't added any movies to your favorites yet."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load favorite movies.\n\n" +
                    ex.Message
                );
            }
        }

        // =====================================================
        // REMOVE FAVORITE
        // =====================================================

        private void BtnRemoveFavorite_Click(
            object sender,
            EventArgs e)
        {
            Button clickedButton =
                sender as Button;

            if (clickedButton == null)
            {
                return;
            }

            Movie movie =
                clickedButton.Tag as Movie;

            if (movie == null)
            {
                return;
            }

            try
            {
                bool removed =
                    favoriteService.RemoveFromFavorite(
                        Session.UserId,
                        movie.MovieId
                    );

                if (removed)
                {
                    MessageBox.Show(
                        movie.Title +
                        " removed from favorites."
                    );

                    LoadFavoriteMovies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to remove favorite.\n\n" +
                    ex.Message
                );
            }
        }

        // =====================================================
        // ADD TO WATCHLIST
        // =====================================================

        private void btnAddToWatchlist_Click(
            object sender,
            EventArgs e)
        {
            if (selectedMovie == null)
            {
                MessageBox.Show(
                    "Please select a movie first."
                );

                return;
            }

            if (Session.UserId <= 0)
            {
                MessageBox.Show(
                    "User session not found. Please login again."
                );

                return;
            }

            try
            {
                bool added =
                    watchlistService.AddToWatchlist(
                        Session.UserId,
                        selectedMovie.MovieId
                    );

                if (added)
                {
                    MessageBox.Show(
                        selectedMovie.Title +
                        " added to your watchlist!"
                    );
                }
                else
                {
                    MessageBox.Show(
                        "This movie is already in your watchlist."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to add movie to watchlist.\n\n" +
                    ex.Message,
                    "Watchlist Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // WATCHLIST SIDEBAR
        // =====================================================

        private void btnWatchlist_Click(
            object sender,
            EventArgs e)
        {
            HideHomeControls();

            LoadWatchlistMovies();
        }

        // =====================================================
        // LOAD WATCHLIST
        // =====================================================

        private void LoadWatchlistMovies()
        {
            try
            {
                if (Session.UserId <= 0)
                {
                    MessageBox.Show(
                        "User session not found. Please login again."
                    );

                    return;
                }

                List<Movie> watchlistMovies =
                    watchlistService.GetWatchlistMovies(
                        Session.UserId
                    );

                flowMovies.Controls.Clear();

                foreach (Movie movie in watchlistMovies)
                {
                    CreateMovieCard(
                        movie,
                        false,
                        true
                    );
                }

                flowMovies.Visible =
                    true;

                panelMovieDetails.Visible =
                    false;

                panelProfile.Visible =
                    false;

                if (watchlistMovies.Count == 0)
                {
                    MessageBox.Show(
                        "You haven't added any movies to your watchlist yet."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load watchlist movies.\n\n" +
                    ex.Message,
                    "Watchlist Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // REMOVE WATCHLIST
        // =====================================================

        private void BtnRemoveWatchlist_Click(
            object sender,
            EventArgs e)
        {
            Button clickedButton =
                sender as Button;

            if (clickedButton == null)
            {
                return;
            }

            Movie movie =
                clickedButton.Tag as Movie;

            if (movie == null)
            {
                return;
            }

            try
            {
                bool removed =
                    watchlistService.RemoveFromWatchlist(
                        Session.UserId,
                        movie.MovieId
                    );

                if (removed)
                {
                    MessageBox.Show(
                        movie.Title +
                        " removed from watchlist."
                    );

                    LoadWatchlistMovies();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to remove movie from watchlist.\n\n" +
                    ex.Message,
                    "Watchlist Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // =====================================================
        // PROFILE BUTTON
        // =====================================================

        private void btnProfile_Click(
            object sender,
            EventArgs e)
        {
            ShowProfile();
        }

        // =====================================================
        // SHOW PROFILE
        // =====================================================

        private void ShowProfile()
        {
            selectedMovie =
                null;

            lblSearch.Visible =
                false;

            txtSearch.Visible =
                false;

            btnSearch.Visible =
                false;

            lblGenre.Visible =
                false;

            cmbGenre.Visible =
                false;

            flowMovies.Visible =
                false;

            panelMovieDetails.Visible =
                false;

            panelProfile.Visible =
                true;

            panelProfile.BringToFront();

            lblProfileName.Text =
                "Full Name: " +
                Session.UserName;

            lblProfileEmail.Text =
                "Email: " +
                Session.UserEmail;

            lblProfileRole.Text =
                "Role: User";
        }

        // =====================================================
        // HIDE HOME CONTROLS
        // =====================================================

        private void HideHomeControls()
        {
            lblSearch.Visible =
                false;

            txtSearch.Visible =
                false;

            btnSearch.Visible =
                false;

            lblGenre.Visible =
                false;

            cmbGenre.Visible =
                false;

            panelMovieDetails.Visible =
                false;

            panelProfile.Visible =
                false;
        }

        // =====================================================
        // BACK TO MOVIES
        // =====================================================

        private void btnBackToMovies_Click(
            object sender,
            EventArgs e)
        {
            ShowHomePage();
        }

        private void btnBackToMovies_Click_1(
            object sender,
            EventArgs e)
        {
            btnBackToMovies_Click(
                sender,
                e
            );
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
        // DESIGNER EVENTS
        // =====================================================

        private void lblTitle_Click(
            object sender,
            EventArgs e)
        {
        }

        private void panelContent_Paint(
            object sender,
            PaintEventArgs e)
        {
        }

        private void lblDetailTitle_Click(
            object sender,
            EventArgs e)
        {
        }

        private void pictureBoxDetails_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblDetailYear_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblDirector_Click(
            object sender,
            EventArgs e)
        {
        }

        private void panelSidebar_Paint(
            object sender,
            PaintEventArgs e)
        {
        }
    }
}