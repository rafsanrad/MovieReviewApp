using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MovieReviewApp.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            //Designer.cs theke sob components initialize kora hoyeche, tai ekhane InitializeComponent() call kora hoyeche.
            InitializeComponent();
            ActiveControl = txtFullName;
            lblLogo.BackColor = Color.Transparent;
            lblSubTitle.BackColor = Color.Transparent;
            lblName.BackColor = Color.Transparent;
            lblEmail.BackColor = Color.Transparent;
            lblPassword.BackColor = Color.Transparent;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblNoAccount.BackColor = Color.Transparent; 
        }


        // =====================================================
        // REGISTER
        // =====================================================

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name =
                txtFullName.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            string password =
                txtPassword.Text;

            string confirmPassword =
                txtConfirmPassword.Text;


            // -------------------------------------------------
            // VALIDATION
            // -------------------------------------------------

            if (name == "" ||
                email == "" ||
                password == "" ||
                confirmPassword == "")
            {
                MessageBox.Show(
                    "Please fill in all fields.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }


            // -------------------------------------------------
            // PASSWORD MATCH
            // -------------------------------------------------

            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Registration",
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
                    // CREATE USER
                    // -------------------------------------------------

                    string query = @"
                        INSERT INTO Users
                        (
                            Name,
                            Email,
                            Password,
                            Role
                        )
                        VALUES
                        (
                            @Name,
                            @Email,
                            @Password,
                            'User'
                        )";


                    using (SqlCommand command =
                           new SqlCommand(
                               query,
                               connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Name",
                            name
                        );

                        command.Parameters.AddWithValue(
                            "@Email",
                            email
                        );

                        command.Parameters.AddWithValue(
                            "@Password",
                            password
                        );


                        command.ExecuteNonQuery();
                    }
                }


                // -------------------------------------------------
                // REGISTRATION CONFIRMATION
                // -------------------------------------------------

                MessageBox.Show(
                    "Registration confirmed!",
                    "Registration Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );


                // -------------------------------------------------
                // GO TO LOGIN
                // -------------------------------------------------

                LoginForm loginForm =
                    new LoginForm();

                loginForm.Show();

                this.Hide();
            }
            catch (SqlException ex)
            {
                // -------------------------------------------------
                // DUPLICATE EMAIL
                // -------------------------------------------------

                if (ex.Number == 2627 ||
                    ex.Number == 2601)
                {
                    MessageBox.Show(
                        "This email is already registered.",
                        "Registration Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Registration Failed!\n\n" +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration Failed!\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // BACK TO LOGIN
        // =====================================================

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm =
                new LoginForm();

            loginForm.Show();

            this.Hide();
        }

        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}