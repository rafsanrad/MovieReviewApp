using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void panelMovieCard_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelMovieCard.Width - 1,
                    panelMovieCard.Height - 1
                );
            }
        }

        private void panelUserCard_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelUserCard.Width - 1,
                    panelUserCard.Height - 1
                );
            }
        }

        private void panelReviewCard_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelReviewCard.Width - 1,
                    panelReviewCard.Height - 1
                );
            }
        }

        private void panelQuickAction_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    0,
                    0,
                    panelQuickAction.Width - 1,
                    panelQuickAction.Height - 1
                );
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear current admin session
            Session.Clear();

            // Open Login Form
            Form1 loginForm = new Form1();
            loginForm.Show();

            // Close Admin Panel
            this.Close();
        }
    }
}
