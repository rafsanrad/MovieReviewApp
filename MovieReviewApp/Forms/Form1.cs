using MovieReviewApp.Forms;
using System;
using System.Data.SqlClient;
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


        // =====================================================
        // DATABASE INITIALIZATION
        // =====================================================

        private void InitializeApplication()
        {
            try
            {
                DatabaseHelper db =
                    new DatabaseHelper();

                db.InitializeDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database initialization failed.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // FORM LOAD
        // =====================================================

        private void Form1_Load(
            object sender,
            EventArgs e)
        {

        }


        // =====================================================
        // PASSWORD TEXT CHANGED
        // =====================================================

        private void txtPassword_TextChanged(
            object sender,
            EventArgs e)
        {

        }


        // =====================================================
        // TEST DATABASE CONNECTION
        // =====================================================

        private void btnTestConnection_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                DatabaseHelper db =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       db.GetConnection())
                {
                    connection.Open();

                    MessageBox.Show(
                        "Database Connected Successfully!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Connection Failed!\n\n" +
                    ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        // =====================================================
        // LOGIN
        // =====================================================

        private void btnLogin_Click(
            object sender,
            EventArgs e)
        {
            string email =
                txtEmail.Text.Trim();

            string password =
                txtPassword.Text;


            // =================================================
            // VALIDATION
            // =================================================

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


                    // =================================================
                    // GET USER INFORMATION + ROLE
                    // =================================================

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
                            // =================================================
                            // LOGIN SUCCESSFUL
                            // =================================================

                            if (reader.Read())
                            {
                                // =============================================
                                // SAVE USER INFORMATION IN SESSION
                                // =============================================

                                Session.UserId =
                                    Convert.ToInt32(
                                        reader["UserId"]
                                    );

                                Session.UserName =
                                    reader["Name"].ToString();

                                Session.UserEmail =
                                    reader["Email"].ToString();


                                // =============================================
                                // GET ROLE
                                // =============================================

                                string role =
                                    reader["Role"].ToString();


                                // =============================================
                                // ADMIN LOGIN
                                // =============================================

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


                                // =============================================
                                // REGULAR USER LOGIN
                                // =============================================

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


                            // =================================================
                            // LOGIN FAILED
                            // =================================================

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
        // REGISTER
        // =====================================================

        private void btnRegister_Click(
            object sender,
            EventArgs e)
        {
            string name =
                txtName.Text.Trim();

            string email =
                txtEmail.Text.Trim();

            string password =
                txtPassword.Text;


            // =================================================
            // VALIDATION
            // =================================================

            if (name == "" ||
                email == "" ||
                password == "")
            {
                MessageBox.Show(
                    "Please fill in all fields.",
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


                    // =================================================
                    // NEW USERS ARE ALWAYS REGULAR USERS
                    // =================================================

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


                        // =============================================
                        // REGISTRATION SUCCESS
                        // =============================================

                        MessageBox.Show(
                            "Registration Successful!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );


                        // =============================================
                        // CLEAR FIELDS
                        // =============================================

                        txtName.Clear();
                        txtEmail.Clear();
                        txtPassword.Clear();
                    }
                }
            }


            // =================================================
            // DUPLICATE EMAIL
            // =================================================

            catch (SqlException ex)
            {
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


            // =================================================
            // OTHER ERROR
            // =================================================

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
        // TITLE CLICK
        // =====================================================

        private void lblTitle_Click(
            object sender,
            EventArgs e)
        {

        }
    }
}