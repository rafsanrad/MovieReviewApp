using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieReviewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show("Database Connected Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed!\n\n" + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter email and password.");
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                SELECT COUNT(*)
                FROM Users
                WHERE Email = @Email
                AND Password = @Password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!");
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed!\n\n" + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }
    }
}