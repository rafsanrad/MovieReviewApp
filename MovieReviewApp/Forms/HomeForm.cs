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
        // =====================================================
        // SERVICES
        // =====================================================

        private MovieService movieService =
            new MovieService();

        private FavoriteService favoriteService =
            new FavoriteService();

        private WatchlistService watchlistService =
            new WatchlistService();


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

            // Genre dropdown
            if (cmbGenre.Items.Count > 0)
            {
                cmbGenre.SelectedIndex = 0;
            }

            // Initially show movies
            flowMovies.Visible = true;

            // Initially hide movie details
            panelMovieDetails.Visible = false;
        }


        // =====================================================
        // FORM LOAD
        // =====================================================

        private void HomeForm_Load(
            object sender,
            EventArgs e)
        {
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

                flowMovies.Controls.Clear();

                foreach (Movie movie in movies)
                {
                    CreateMovieCard(
                        movie,
                        false
                    );
                }

                flowMovies.Visible = true;

                panelMovieDetails.Visible = false;
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
        // CREATE MOVIE CARD
        // =====================================================

        private void CreateMovieCard(
            Movie movie,
            bool isFavorite = false)
        {
            // =================================================
            // MOVIE CARD
            // =================================================

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

            LoadPoster(
                poster,
                movie.PosterPath
            );


            // =================================================
            // MOVIE TITLE
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

            lblMovieTitle.AutoSize =
                false;

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

            lblMovieInfo.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Regular
                );

            lblMovieInfo.AutoSize =
                false;

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

            btnDetails.Font =
                new Font(
                    "Segoe UI",
                    9,
                    FontStyle.Regular
                );

            btnDetails.Width = 80;
            btnDetails.Height = 35;

            btnDetails.Location =
                new Point(10, 280);

            // Store movie
            btnDetails.Tag =
                movie;

            // Click event
            btnDetails.Click +=
                BtnDetails_Click;


            // Add Details button
            movieCard.Controls.Add(
                btnDetails
            );


            // =================================================
            // REMOVE FAVORITE BUTTON
            // =================================================

            if (isFavorite)
            {
                Button btnRemove =
                    new Button();

                btnRemove.Text =
                    "Remove";

                btnRemove.Font =
                    new Font(
                        "Segoe UI",
                        9,
                        FontStyle.Regular
                    );

                btnRemove.Width = 80;
                btnRemove.Height = 35;

                btnRemove.Location =
                    new Point(100, 280);

                // Firebrick background
                btnRemove.BackColor =
                    Color.Firebrick;

                // Black text
                btnRemove.ForeColor =
                    Color.Black;

                // Store movie
                btnRemove.Tag =
                    movie;

                // Click event
                btnRemove.Click +=
                    BtnRemoveFavorite_Click;


                movieCard.Controls.Add(
                    btnRemove
                );
            }


            // =================================================
            // ADD OTHER CONTROLS
            // =================================================

            movieCard.Controls.Add(
                poster
            );

            movieCard.Controls.Add(
                lblMovieTitle
            );

            movieCard.Controls.Add(
                lblMovieInfo
            );


            // =================================================
            // ADD CARD TO FLOWMOVIES
            // =================================================

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

            if (string.IsNullOrEmpty(
                posterPath))
            {
                return;
            }

            string imagePath =
                System.IO.Path.Combine(
                    Application.StartupPath,
                    posterPath
                );

            if (!System.IO.File.Exists(
                imagePath))
            {
                return;
            }

            try
            {
                using (
                    var stream =
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
        // DETAILS BUTTON CLICK
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
                return;
            }

            ShowMovieDetails(movie);
        }


        // =====================================================
        // SHOW MOVIE DETAILS
        // =====================================================

        private void ShowMovieDetails(
            Movie movie)
        {
            selectedMovie =
                movie;


            // Hide movies
            flowMovies.Visible =
                false;


            // Show details
            panelMovieDetails.Visible =
                true;


            // =================================================
            // TITLE
            // =================================================

            lblDetailTitle.Text =
                movie.Title;


            // =================================================
            // GENRE
            // =================================================

            lblDetailGenre.Text =
                "Genre: " +
                movie.Genre;


            // =================================================
            // YEAR
            // =================================================

            lblDetailYear.Text =
                "Release Year: " +
                movie.ReleaseYear;


            // =================================================
            // DIRECTOR
            // =================================================

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


            // =================================================
            // DESCRIPTION
            // =================================================

            if (string.IsNullOrEmpty(
                movie.Description))
            {
                lblDescriptiontitle.Text =
                    "No description available.";
            }
            else
            {
                lblDescriptiontitle.Text =
                    movie.Description;
            }


            // =================================================
            // DETAILS POSTER
            // =================================================

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
                    "User session not found. " +
                    "Please login again."
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
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // FAVORITES BUTTON
        // =====================================================

        private void btnFavorites_Click(
            object sender,
            EventArgs e)
        {
            LoadFavoriteMovies();
        }


        // =====================================================
        // LOAD FAVORITE MOVIES
        // =====================================================

        private void LoadFavoriteMovies()
        {
            try
            {
                if (Session.UserId <= 0)
                {
                    MessageBox.Show(
                        "User session not found. " +
                        "Please login again."
                    );

                    return;
                }


                List<Movie> favoriteMovies =
                    favoriteService.GetFavoriteMovies(
                        Session.UserId
                    );


                // Clear current cards
                flowMovies.Controls.Clear();


                // Add favorite cards
                foreach (Movie movie in favoriteMovies)
                {
                    CreateMovieCard(
                        movie,
                        true
                    );
                }


                // Show movies
                flowMovies.Visible =
                    true;


                // Hide details
                panelMovieDetails.Visible =
                    false;


                // No favorites
                if (favoriteMovies.Count == 0)
                {
                    MessageBox.Show(
                        "You haven't added any movies " +
                        "to your favorites yet."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to load favorite movies.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
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


            if (Session.UserId <= 0)
            {
                MessageBox.Show(
                    "User session not found. " +
                    "Please login again."
                );

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


                    // Refresh favorites
                    LoadFavoriteMovies();
                }
                else
                {
                    MessageBox.Show(
                        "Movie was not found in your favorites."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to remove favorite.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
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
                    "User session not found. " +
                    "Please login again."
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
                    "Error",
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
            panelMovieDetails.Visible =
                false;

            flowMovies.Visible =
                true;

            selectedMovie =
                null;

            LoadMovies();
        }


        // =====================================================
        // BACK TO MOVIES - SECOND EVENT
        // =====================================================

        private void btnBackToMovies_Click_1(
            object sender,
            EventArgs e)
        {
            panelMovieDetails.Visible =
                false;

            flowMovies.Visible =
                true;

            selectedMovie =
                null;

            LoadMovies();
        }


        // =====================================================
        // MOVIES SIDEBAR BUTTON
        // =====================================================

        private void btnMovies_Click(
            object sender,
            EventArgs e)
        {
            selectedMovie =
                null;

            panelMovieDetails.Visible =
                false;

            flowMovies.Visible =
                true;

            LoadMovies();
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
        // TITLE CLICK
        // =====================================================

        private void lblTitle_Click(
            object sender,
            EventArgs e)
        {
        }


        // =====================================================
        // CONTENT PANEL PAINT
        // =====================================================

        private void panelContent_Paint(
            object sender,
            PaintEventArgs e)
        {
        }


        // =====================================================
        // GENRE COMBOBOX
        // =====================================================

        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        // =====================================================
        // DETAIL TITLE CLICK
        // =====================================================

        private void lblDetailTitle_Click(
            object sender,
            EventArgs e)
        {
        }


        // =====================================================
        // DETAIL POSTER CLICK
        // =====================================================

        private void pictureBoxDetails_Click(
            object sender,
            EventArgs e)
        {
        }


        // =====================================================
        // DETAIL YEAR CLICK
        // =====================================================

        private void lblDetailYear_Click(
            object sender,
            EventArgs e)
        {
        }


        // =====================================================
        // DIRECTOR CLICK
        // =====================================================

        private void lblDirector_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}