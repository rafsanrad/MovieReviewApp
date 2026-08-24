using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MovieReviewApp.Models;
using MovieReviewApp.Services;

namespace MovieReviewApp
{
    public partial class HomeForm : Form
    {
        private MovieService movieService = new MovieService();
        private FavoriteService favoriteService = new FavoriteService();
        private WatchlistService watchlistService = new WatchlistService();

        private Movie selectedMovie;

        public HomeForm()
        {
            InitializeComponent();

            if (cmbGenre.Items.Count > 0)
            {
                cmbGenre.SelectedIndex = 0;
            }

            flowMovies.Visible = true;
            panelMovieDetails.Visible = false;
        }

        // =====================================================
        // HOME FORM LOAD
        // =====================================================

        private void HomeForm_Load(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        // =====================================================
        // HOME PAGE
        // =====================================================

        private void ShowHomePage()
        {
            selectedMovie = null;

            panelMovieDetails.Visible = false;
            panelMovieDetails.SendToBack();

            flowMovies.Visible = true;
            flowMovies.BringToFront();

            LoadMovies();
        }

        // =====================================================
        // HOME BUTTON
        // =====================================================

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        // =====================================================
        // LOAD ALL MOVIES
        // =====================================================

        private void LoadMovies()
        {
            try
            {
                List<Movie> movies = movieService.GetAll();

                flowMovies.Controls.Clear();

                foreach (Movie movie in movies)
                {
                    CreateMovieCard(movie);
                }

                flowMovies.Visible = true;
                flowMovies.BringToFront();

                panelMovieDetails.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load movies.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
            Panel movieCard = new Panel();

            movieCard.Width = 200;
            movieCard.Height = 330;
            movieCard.BorderStyle = BorderStyle.FixedSingle;
            movieCard.Margin = new Padding(10);

            // Poster
            PictureBox poster = new PictureBox();

            poster.Width = 180;
            poster.Height = 200;
            poster.Location = new Point(10, 10);
            poster.SizeMode = PictureBoxSizeMode.StretchImage;
            poster.BackColor = Color.LightGray;

            LoadPoster(
                poster,
                movie.PosterPath
            );

            // Title
            Label lblMovieTitle = new Label();

            lblMovieTitle.Text = movie.Title;

            lblMovieTitle.Font =
                new Font(
                    "Segoe UI",
                    11,
                    FontStyle.Bold
                );

            lblMovieTitle.AutoSize = false;
            lblMovieTitle.Width = 180;
            lblMovieTitle.Height = 30;
            lblMovieTitle.Location = new Point(10, 215);

            // Genre + Year
            Label lblMovieInfo = new Label();

            lblMovieInfo.Text =
                movie.Genre +
                " • " +
                movie.ReleaseYear;

            lblMovieInfo.AutoSize = false;
            lblMovieInfo.Width = 180;
            lblMovieInfo.Height = 25;
            lblMovieInfo.Location = new Point(10, 245);

            // Details Button
            Button btnDetails = new Button();

            btnDetails.Text = "Details";
            btnDetails.Width = 80;
            btnDetails.Height = 35;
            btnDetails.Location = new Point(10, 280);
            btnDetails.Tag = movie;

            btnDetails.Click += BtnDetails_Click;

            movieCard.Controls.Add(btnDetails);

            // =================================================
            // REMOVE FAVORITE
            // =================================================

            if (isFavorite)
            {
                Button btnRemoveFavorite = new Button();

                btnRemoveFavorite.Text = "Remove";
                btnRemoveFavorite.Width = 80;
                btnRemoveFavorite.Height = 35;
                btnRemoveFavorite.Location =
                    new Point(100, 280);

                btnRemoveFavorite.Tag = movie;

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
                Button btnRemoveWatchlist = new Button();

                btnRemoveWatchlist.Text = "Remove";
                btnRemoveWatchlist.Width = 80;
                btnRemoveWatchlist.Height = 35;
                btnRemoveWatchlist.Location =
                    new Point(100, 280);

                btnRemoveWatchlist.Tag = movie;

                btnRemoveWatchlist.Click +=
                    BtnRemoveWatchlist_Click;

                movieCard.Controls.Add(
                    btnRemoveWatchlist
                );
            }

            movieCard.Controls.Add(poster);
            movieCard.Controls.Add(lblMovieTitle);
            movieCard.Controls.Add(lblMovieInfo);

            flowMovies.Controls.Add(movieCard);
        }

        // =====================================================
        // LOAD POSTER
        // =====================================================

        private void LoadPoster(
            PictureBox pictureBox,
            string posterPath)
        {
            pictureBox.BackColor = Color.LightGray;

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
                    "Movie data not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            selectedMovie = movie;

            ShowMovieDetails(movie);
        }

        // =====================================================
        // SHOW MOVIE DETAILS
        // =====================================================

        private void ShowMovieDetails(Movie movie)
        {
            if (movie == null)
            {
                return;
            }

            selectedMovie = movie;

            flowMovies.Visible = false;

            panelMovieDetails.Visible = true;
            panelMovieDetails.Enabled = true;
            panelMovieDetails.BringToFront();

            lblDetailTitle.Text =
                movie.Title;

            lblDetailGenre.Text =
                "Genre: " +
                movie.Genre;

            lblDetailYear.Text =
                "Release Year: " +
                movie.ReleaseYear;

            if (string.IsNullOrEmpty(movie.Director))
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

            if (string.IsNullOrEmpty(movie.Description))
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
                pictureBoxDetails.Image = null;
            }

            LoadPoster(
                pictureBoxDetails,
                movie.PosterPath
            );
        }

        // =====================================================
        // ADD TO FAVORITE
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

                panelMovieDetails.Visible = false;

                flowMovies.Visible = true;
                flowMovies.BringToFront();

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

                panelMovieDetails.Visible = false;

                flowMovies.Visible = true;
                flowMovies.BringToFront();

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
        // BACK TO MOVIES
        // =====================================================

        private void btnBackToMovies_Click(
            object sender,
            EventArgs e)
        {
            ShowHomePage();
        }

        // =====================================================
        // DESIGNER MAY USE _1
        // =====================================================

        private void btnBackToMovies_Click_1(
            object sender,
            EventArgs e)
        {
            ShowHomePage();
        }

        // =====================================================
        // MOVIES
        // =====================================================

        private void btnMovies_Click(
            object sender,
            EventArgs e)
        {
            ShowHomePage();
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

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
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