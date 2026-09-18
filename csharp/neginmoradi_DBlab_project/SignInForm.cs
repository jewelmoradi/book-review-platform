using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace neginmoradi_DBlab_project
{
    public partial class SignInForm : Form
    {
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void pictureBox1_Click(object sender, EventArgs e) {}

        private void imgLogo_Click(object sender, EventArgs e) {}

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (checkBoxAuthor.Checked)
            {
                signInAuthor();
            }
            else
            {
                signInUser();
            }
        }

        private void signInUser()
        {
            string inputEmail = txtEmail.Text;
            string inputPassword = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM USER1 WHERE inputEmail = @userEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userEmail", inputEmail);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["passwordd"].ToString();

                            if (inputPassword == storedPassword)
                            {
                                //passwords match, successful sign-in
                                UserMainForm mainPage = new UserMainForm(inputEmail);
                                mainPage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User with this email does not exist.");
                        }
                    }
                }
            }
        }


        private void signInAuthor()
        {
            string inputEmail = txtEmail.Text;
            string inputPassword = txtPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM AUTHOR WHERE inputEmail = @userEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@authorEmail", inputEmail);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedPassword = reader["passwordd"].ToString();

                            if (inputPassword == storedPassword)
                            {
                                //passwords match, successful sign-in
                                AuthorMainForm mainPage = new AuthorMainForm(inputEmail);
                                mainPage.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid email or password. Please try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User with this email does not exist.");
                        }
                    }
                }
            }
        }
    }
}

