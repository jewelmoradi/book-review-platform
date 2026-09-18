using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection.Emit;

namespace neginmoradi_DBlab_project
{
    public partial class UserMainForm : Form
    {
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        private string userEmail;
        public UserMainForm(string email)
        {
            InitializeComponent();

            userEmail = email;

            DisplayImageForUser();

            imgUserProfile.Click += imgUserProfile_Click;

            SetLabelTextFromDatabase(userEmail);

            LoadDataIntoDataGridView();
        }

        private void Form2_Load(object sender, EventArgs e) {}

        private void label1_Click(object sender, EventArgs e) {}

        private void DisplayImageForUser()
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
                string query = "SELECT userName FROM USER1 WHERE userEmail = @userEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userEmail", userEmail);

                    string columnValue = command.ExecuteScalar()?.ToString();

                    lblSampleUserName.Text = columnValue;
                }
            }
        }

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT title, ISBN, genre, publicationDate FROM BOOK";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewBooks.DataSource = dataTable;
                    }
                }
            }
        }

        private void imgUserProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm userProfileForm = new UserProfileForm(this, userEmail);
            userProfileForm.Show();
            this.Hide();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            FriendsForm friendsForm = new FriendsForm(this, userEmail);
            friendsForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;

            DataTable searchResults = PerformSearch(searchText);

            if (searchResults.Rows.Count > 0) //check if searchResults has any rows (book(s) found)
            {
                BookViewForm bookViewForm = new BookViewForm(searchResults);
                bookViewForm.Show();
                this.Hide();
            }
        }

        private DataTable PerformSearch(string searchText)
        {
            string query = $"SELECT * FROM BOOK WHERE ISBN = @searchText OR title LIKE '%' + @searchText + '%'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);

                    DataTable searchResults = new DataTable();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(searchResults);
                    }

                    return searchResults;
                }
            }
        }
    }
}
