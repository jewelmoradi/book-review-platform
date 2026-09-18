using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neginmoradi_DBlab_project
{
    public partial class SignUpForm : Form
    {
        string selectedImagePath = "";
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e) {}

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                imgProfilePicture.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (checkBoxAuthor.Checked)
            {
                signUpAuthor();
            }
            else
            {
                signUpUser();
            }
        }

        private void signUpUser()
        {
            string inputName = txtName.Text;
            string inputEmail = txtEmail.Text;
            string inputPassword = txtPassword.Text;
            string inputDOB = txtDOB.Text;

            //saving input datas in database
            if (!string.IsNullOrEmpty(selectedImagePath)) //case: user has sellected an image
            {
                byte[] imageData = File.ReadAllBytes(selectedImagePath);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO USER1 (userName, userEmail, passwordd, profilePicture, dateOfBirth) VALUES (@inputName, @inputEmail, @inputPassword, @profilePicture, @inputDOB)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inputName", inputName);
                        command.Parameters.AddWithValue("@inputEmail", inputEmail);
                        command.Parameters.AddWithValue("@inputPassword", inputPassword);
                        command.Parameters.AddWithValue("@profilePicture", imageData);
                        command.Parameters.AddWithValue("@inputDOB", inputDOB);
                        command.ExecuteNonQuery();
                    }

                }
            }
            else //case: user does not have a profile image (default profile image)
            {
                Image defaultProfileImage = Properties.Resources.default_profile; //load the default profile picture from resources

                //convert the Image to a byte array
                byte[] defaultProfileImageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    defaultProfileImage.Save(ms, defaultProfileImage.RawFormat);
                    defaultProfileImageBytes = ms.ToArray();
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO USER1 (userName, userEmail, passwordd, profilePicture, dateOfBirth) VALUES (@inputName, @inputEmail, @inputPassword, @profilePicture, @inputDOB)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inputName", inputName);
                        command.Parameters.AddWithValue("@inputEmail", inputEmail);
                        command.Parameters.AddWithValue("@inputPassword", inputPassword);
                        command.Parameters.AddWithValue("@profilePicture", defaultProfileImageBytes);
                        command.Parameters.AddWithValue("@inputDOB", inputDOB);
                        command.ExecuteNonQuery();
                    }

                }
            }

            MessageBox.Show("Your registration was successful.");

            UserMainForm userMainForm = new UserMainForm(inputEmail);
            userMainForm.Show();
            this.Hide();
        }

        private void signUpAuthor()
        {
            string inputName = txtName.Text;
            string inputEmail = txtEmail.Text;
            string inputPassword = txtPassword.Text;
            string inputDOB = txtDOB.Text;

            //saving input datas in database
            if (!string.IsNullOrEmpty(selectedImagePath)) //case: user has sellected an image
            {
                byte[] imageData = File.ReadAllBytes(selectedImagePath);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO AUTHOR (authorEmail, authorName, profilePicture, passwordd, dateOfBirth) VALUES (@inputEmail, @inputName, @profilePicture, @inputPassword, @inputDOB)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inputEmail", inputEmail);
                        command.Parameters.AddWithValue("@inputName", inputName);
                        command.Parameters.AddWithValue("@profilePicture", imageData);
                        command.Parameters.AddWithValue("@inputPassword", inputPassword);
                        command.Parameters.AddWithValue("@inputDOB", inputDOB);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else //case: author does not have a profile image (default profile image)
            {
                Image defaultProfileImage = Properties.Resources.default_profile; //load the default profile picture from resources

                //convert the Image to a byte array
                byte[] defaultProfileImageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    defaultProfileImage.Save(ms, defaultProfileImage.RawFormat);
                    defaultProfileImageBytes = ms.ToArray();
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO AUTHOR (authorEmail, authorName, profilePicture, passwordd, dateOfBirth) VALUES (@inputEmail, @inputName, @profilePicture, @inputPassword, @inputDOB)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inputEmail", inputEmail);
                        command.Parameters.AddWithValue("@inputName", inputName);
                        command.Parameters.AddWithValue("@profilePicture", defaultProfileImageBytes);
                        command.Parameters.AddWithValue("@inputPassword", inputPassword);
                        command.Parameters.AddWithValue("@inputDOB", inputDOB);
                        command.ExecuteNonQuery();
                    }
                }
            }
            
            MessageBox.Show("Your registration was successful.");

            AuthorMainForm authorMainForm = new AuthorMainForm(inputEmail);
            authorMainForm.Show();
            this.Hide();
        }

    }
}
