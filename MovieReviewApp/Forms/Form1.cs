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

            InitializeApplication();
        }

        private void InitializeApplication()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                db.InitializeDatabase();

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database initialization failed.\n\n" + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
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
                SELECT UserId, Name, Email
                FROM Users
                WHERE Email = @Email
                AND Password = @Password";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Email",
                            email
                        );

                        command.Parameters.AddWithValue(
                            "@Password",
                            password
                        );

                        using (SqlDataReader reader =
                               command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // =================================
                                // SAVE LOGGED-IN USER INFORMATION
                                // =================================

                                Session.UserId =
                                    Convert.ToInt32(
                                        reader["UserId"]
                                    );

                                Session.UserName =
                                    reader["Name"].ToString();

                                Session.UserEmail =
                                    reader["Email"].ToString();


                                MessageBox.Show(
                                    "Login Successful!"
                                );


                                // =================================
                                // OPEN HOME FORM
                                // =================================

                                HomeForm homeForm =
                                    new HomeForm();

                                homeForm.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid email or password."
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login Failed!\n\n" +
                    ex.Message
                );
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (name == "" || email == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                DatabaseHelper db = new DatabaseHelper();

                using (SqlConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = @"
                INSERT INTO Users (Name, Email, Password)
                VALUES (@Name, @Email, @Password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful!");

                        txtName.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("This email is already registered.");
                }
                else
                {
                    MessageBox.Show("Registration Failed!\n\n" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Failed!\n\n" + ex.Message);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}