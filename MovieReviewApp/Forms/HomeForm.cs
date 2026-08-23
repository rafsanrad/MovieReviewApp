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
        // MOVIE SERVICE
        // =====================================================

        private MovieService movieService =
            new MovieService();


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

            // Initially show movie cards
            flowMovies.Visible = true;

            // Initially hide movie details
            panelMovieDetails.Visible = false;
        }


        // =====================================================
        // HOME FORM LOAD
        // =====================================================

        private void HomeForm_Load(
            object sender,
            EventArgs e)
        {
            LoadMovies();
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

                flowMovies.Controls.Clear();

                foreach (Movie movie in movies)
                {
                    CreateMovieCard(movie);
                }
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

        private void CreateMovieCard(Movie movie)
        {
            // Movie Card
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

            btnDetails.Width = 100;
            btnDetails.Height = 35;

            btnDetails.Location =
                new Point(10, 280);

            // Store movie object
            btnDetails.Tag =
                movie;

            // Click event
            btnDetails.Click +=
                BtnDetails_Click;


            // =================================================
            // ADD CONTROLS TO CARD
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

            movieCard.Controls.Add(
                btnDetails
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

            Movie selectedMovie =
                clickedButton.Tag as Movie;

            if (selectedMovie == null)
            {
                return;
            }

            ShowMovieDetails(
                selectedMovie
            );
        }


        // =====================================================
        // SHOW MOVIE DETAILS
        // =====================================================

        private void ShowMovieDetails(
            Movie movie)
        {
            // Hide movie cards
            flowMovies.Visible =
                false;

            // Show details panel
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
            // RELEASE YEAR
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
                lblMovieDescription.Text =
                    "No description available.";
            }
            else
            {
                lblMovieDescription.Text =
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
        // BACK TO MOVIES
        // =====================================================

        private void btnBackToMovies_Click(
            object sender,
            EventArgs e)
        {
            // Hide details
            panelMovieDetails.Visible =
                false;

            // Show movie cards
            flowMovies.Visible =
                true;
        }


        // =====================================================
        // LOGOUT
        // =====================================================

        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            Form1 loginForm =
                new Form1();

            loginForm.Show();

            this.Close();
        }


        // =====================================================
        // MOVIES SIDEBAR BUTTON
        // =====================================================

        private void btnMovies_Click(
            object sender,
            EventArgs e)
        {
            // Hide details
            panelMovieDetails.Visible =
                false;

            // Show movie cards
            flowMovies.Visible =
                true;
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