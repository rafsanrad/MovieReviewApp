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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void LoadMovies()
        {
            List<Movie> movies = movieService.GetAll();

            foreach (Movie movie in movies)
            {
                Label movieLabel = new Label();

                movieLabel.Text =
                    movie.Title + "\n" +
                    movie.Genre + "\n" +
                    movie.ReleaseYear;

                movieLabel.Width = 180;
                movieLabel.Height = 100;

                movieLabel.BorderStyle = BorderStyle.FixedSingle;

                movieLabel.Margin = new Padding(10);

                flowMovies.Controls.Add(movieLabel);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Close();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}