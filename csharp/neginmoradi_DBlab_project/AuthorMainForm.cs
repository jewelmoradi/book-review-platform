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
    public partial class AuthorMainForm : Form
    {
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        private string authorEmail;
        public AuthorMainForm(string email)
        {
            InitializeComponent();

            authorEmail = email;

            DisplayImageForAuthor();

            imgAuthorProfile.Click += imgAuthorProfile_Click;

            SetLabelTextFromDatabase(authorEmail);

            LoadDataIntoDataGridView();
        }

        private void AuthorMainForm_Load(object sender, EventArgs e) {}

        private void DisplayImageForAuthor()
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
                string query = "SELECT authorName FROM AUTHOR WHERE authorEmail = @authorEmail";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@authorEmail", authorEmail);

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

        private void imgAuthorProfile_Click(object sender, EventArgs e)
        {
            AuthorProfileForm authorProfileForm = new AuthorProfileForm(this, authorEmail);
            authorProfileForm.Show();
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

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addBookForm = new AddBookForm(this);
            addBookForm.Show();
            this.Hide();
        }
    }
}
