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
    public partial class UserProfileForm : Form
    {
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        private string userEmail;
        private UserMainForm _userMainForm;
        public UserProfileForm(UserMainForm userMainForm, string email)
        {
            InitializeComponent();
            _userMainForm = userMainForm;
            userEmail = email;

            DisplayProfilePicture();

            SetLabelTextFromDatabase(userEmail);
        }

        private void imgLogo_Click(object sender, EventArgs e) {}

        private void btnHome_Click(object sender, EventArgs e)
        {
            _userMainForm.Show();
            this.Close();
        }

        private void DisplayProfilePicture()
        {
            byte[] imageBytes = GetImageFromDatabase(userEmail);
            if (imageBytes != null)
            {
                Image image = ByteArrayToImage(imageBytes);
                imgUserProfile.Image = image;
            }
        }

        //function to retrieve image byte array from the database based on user email
        private byte[] GetImageFromDatabase(string userEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT profilePicture FROM USER1 WHERE userEmail = @userEmail";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userEmail", userEmail);
                    byte[] imageBytes = (byte[])command.ExecuteScalar();
                    return imageBytes;
                }
            }
        }

        //function to convert byte array to Image
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void SetLabelTextFromDatabase(string userEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT userName, userEmail, dateOfBirth FROM USER1 WHERE userEmail = @userEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userEmail", userEmail);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblSampleUserName.Text = reader["userName"].ToString();
                        lblSampleEmail.Text = reader["userEmail"].ToString();
                        lblSampleDOB.Text = reader["dateOfBirth"].ToString();
                    }

                    reader.Close();
                }
            }
        }

        private void UserProfileForm_Load(object sender, EventArgs e) {}
    }
}
