using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
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
    }
}
