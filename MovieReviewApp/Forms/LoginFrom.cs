using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // Transparent label backgrounds
            lblLogo.BackColor = Color.Transparent;
            lblSubTitle.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblNoAccount.BackColor = Color.Transparent;
        }


        // =====================================================
        // LOGIN
        // =====================================================

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email =
                txtEmail.Text.Trim();

            string password =
                txtPassword.Text;


            // -------------------------------------------------
            // VALIDATION
            // -------------------------------------------------

            if (email == "" || password == "")
            {
                MessageBox.Show(
                    "Please enter email and password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            try
            {
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();


                    // -------------------------------------------------
                    // CHECK LOGIN
                    // -------------------------------------------------

                    string query = @"
                        SELECT
                            UserId,
                            Name,
                            Email,
                            Role
                        FROM Users
                        WHERE Email = @Email
                        AND Password = @Password";


                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
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


                            //user pawa gelo ki na check korar jonno.
                            if (reader.Read())
                            {
                                // -----------------------------------------
                                // SAVE USER INFORMATION
                                // -----------------------------------------

                                Session.UserId =
                                    Convert.ToInt32(
                                        reader["UserId"]
                                    );

                                Session.UserName =
                                    reader["Name"].ToString();

                                Session.UserEmail =
                                    reader["Email"].ToString();


                                string role =
                                    reader["Role"].ToString();


                                // -----------------------------------------
                                // ADMIN
                                // -----------------------------------------

                                if (role == "Admin")
                                {
                                    MessageBox.Show(
                                        "Welcome, Admin!",
                                        "Login Successful",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                    );

                                    AdminPanel adminPanel =
                                        new AdminPanel();

                                    adminPanel.Show();

                                    this.Hide();
                                }


                                // -----------------------------------------
                                // REGULAR USER
                                // -----------------------------------------

                                else
                                {
                                    MessageBox.Show(
                                        "Login Successful!",
                                        "Welcome",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information
                                    );

                                    HomeForm homeForm =
                                        new HomeForm();

                                    homeForm.Show();

                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Invalid email or password.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning
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
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // OPEN REGISTER FORM
        // =====================================================

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm =
                new RegisterForm();

            registerForm.Show();

            this.Hide();
        }


        // =====================================================
        // SHOW / HIDE PASSWORD
        // =====================================================

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                // Show password
                txtPassword.PasswordChar = '\0';
                btnShowPassword.Text = "Hide";
            }
            else
            {
                // Hide password
                txtPassword.PasswordChar = '*';
                btnShowPassword.Text = "Show";
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}