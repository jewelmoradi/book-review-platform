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
    public partial class AuthorProfileForm : Form
    {
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        private string authorEmail;
        private AuthorMainForm _authorMainForm;
        public AuthorProfileForm(AuthorMainForm authorMainForm, string email)
        {
            InitializeComponent();
            _authorMainForm = authorMainForm;
            authorEmail = email;

            DisplayProfilePicture();

            SetLabelTextFromDatabase(authorEmail);
        }

        private void AuthorProfileForm_Load(object sender, EventArgs e) {}

        private void DisplayProfilePicture()
        {
            byte[] imageBytes = GetImageFromDatabase(authorEmail);
            if (imageBytes != null)
            {
                Image image = ByteArrayToImage(imageBytes);
                imgAuthorProfile.Image = image;
            }
        }

        //function to retrieve image byte array from the database based on author email
        private byte[] GetImageFromDatabase(string authorEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT profilePicture FROM AUTHOR WHERE authorEmail = @authorEmail";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@authorEmail", authorEmail);
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

        private void SetLabelTextFromDatabase(string authorEmail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT authorName, authorEmail, dateOfBirth FROM AUTHOR WHERE authorEmail = @authorEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@authorEmail", authorEmail);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblSampleUserName.Text = reader["authorName"].ToString();
                        lblSampleEmail.Text = reader["authorEmail"].ToString();
                        lblSampleDOB.Text = reader["dateOfBirth"].ToString();
                    }

                    reader.Close();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _authorMainForm.Show();
            this.Close();
        }
    }
}
