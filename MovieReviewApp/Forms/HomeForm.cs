using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieReviewApp.Models;
using MovieReviewApp.Services;

namespace MovieReviewApp
{
    public partial class HomeForm : Form
    {
        private MovieService movieService = new MovieService();

        public HomeForm()
        {
            InitializeComponent();

            cmbGenre.SelectedIndex = 0;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            List<Movie> movies = movieService.GetAll();

            flowMovies.Controls.Clear();

            foreach (Movie movie in movies)
            {
                // =========================
                // MOVIE CARD
                // =========================

                Panel movieCard = new Panel();

                movieCard.Width = 200;
                movieCard.Height = 330;
                movieCard.BorderStyle = BorderStyle.FixedSingle;
                movieCard.Margin = new Padding(10);


                // =========================
                // POSTER
                // =========================

                PictureBox poster = new PictureBox();

                poster.Width = 180;
                poster.Height = 200;

                poster.Location = new Point(10, 10);

                poster.SizeMode = PictureBoxSizeMode.StretchImage;

                // Load poster
                if (!string.IsNullOrEmpty(movie.PosterPath))
                {
                    string imagePath = System.IO.Path.Combine(
                        Application.StartupPath,
                        movie.PosterPath
                    );

                    if (System.IO.File.Exists(imagePath))
                    {
                        try
                        {
                            using (var stream = new System.IO.FileStream(
                                imagePath,
                                System.IO.FileMode.Open,
                                System.IO.FileAccess.Read))
                            {
                                poster.Image = new Bitmap(stream);
                            }
                        }
                        catch
                        {
                            poster.BackColor = Color.LightGray;
                        }
                    }
                    else
                    {
                        poster.BackColor = Color.LightGray;
                    }
                }
                else
                {
                    poster.BackColor = Color.LightGray;
                }


                // =========================
                // MOVIE TITLE
                // =========================

                Label lblMovieTitle = new Label();

                lblMovieTitle.Text = movie.Title;

                lblMovieTitle.Font =
                    new Font("Segoe UI", 11, FontStyle.Bold);

                lblMovieTitle.AutoSize = false;

                lblMovieTitle.Width = 180;
                lblMovieTitle.Height = 30;

                lblMovieTitle.Location =
                    new Point(10, 215);


                // =========================
                // GENRE + YEAR
                // =========================

                Label lblMovieInfo = new Label();

                lblMovieInfo.Text =
                    movie.Genre + " • " + movie.ReleaseYear;

                lblMovieInfo.AutoSize = false;

                lblMovieInfo.Width = 180;
                lblMovieInfo.Height = 25;

                lblMovieInfo.Location =
                    new Point(10, 245);


                // =========================
                // DETAILS BUTTON
                // =========================

                Button btnDetails = new Button();

                btnDetails.Text = "Details";

                btnDetails.Width = 100;
                btnDetails.Height = 35;

                btnDetails.Location =
                    new Point(10, 280);


                // =========================
                // ADD CONTROLS TO CARD
                // =========================

                movieCard.Controls.Add(poster);

                movieCard.Controls.Add(lblMovieTitle);

                movieCard.Controls.Add(lblMovieInfo);

                movieCard.Controls.Add(btnDetails);


                // =========================
                // ADD CARD TO FLOW PANEL
                // =========================

                flowMovies.Controls.Add(movieCard);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();

            loginForm.Show();

            this.Close();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            HomeForm movieForm = new HomeForm();

            movieForm.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}