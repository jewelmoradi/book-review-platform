using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace neginmoradi_DBlab_project
{
    public partial class AddBookForm : Form
    {
        string selectedImagePath = "";
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        private AuthorMainForm _authorMainForm;
        public AddBookForm(AuthorMainForm authorMainForm)
        {
            InitializeComponent();
            _authorMainForm = authorMainForm;
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //saving isbn in database
            string inputISBN = txtISBN.Text;
            string inputTitle = txtTitle.Text;
            string inputGenre = txtGenre.Text;
            string inputPublicationDate = txtPublicationDate.Text;

            if (!string.IsNullOrEmpty(selectedImagePath)) //case: author has sellected a cover
            {
                byte[] imageData = File.ReadAllBytes(selectedImagePath);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO BOOK (ISBN, title, genre, publicationDate, coverImage) VALUES (@inputISBN, @inputTitle, @inputGenre, @inputPublicationDate, @coverImage)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inputISBN", inputISBN);
                        command.Parameters.AddWithValue("@inputTitle", inputTitle);
                        command.Parameters.AddWithValue("@inputGenre", inputGenre);
                        command.Parameters.AddWithValue("@inputPublicationDate", inputPublicationDate);
                        command.Parameters.AddWithValue("@coverImage", imageData);
                        command.ExecuteNonQuery();
                    }
                }
            }
            else //case: book does not have a cover image (default cover image)
            {
                Image defaultCoverImage = Properties.Resources.default_cover; //load the default cover picture from resources

                //convert the Image to a byte array
                byte[] defaultCoverImageBytes;
                using (MemoryStream ms = new MemoryStream())
                {
                    defaultCoverImage.Save(ms, defaultCoverImage.RawFormat);
                    defaultCoverImageBytes = ms.ToArray();
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO BOOK (ISBN, title, genre, publicationDate, coverImage) VALUES (@inputISBN, @inputTitle, @inputGenre, @inputPublicationDate, @coverImage)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@inputISBN", inputISBN);
                        command.Parameters.AddWithValue("@inputTitle", inputTitle);
                        command.Parameters.AddWithValue("@inputGenre", inputGenre);
                        command.Parameters.AddWithValue("@inputPublicationDate", inputPublicationDate);
                        command.Parameters.AddWithValue("@coverImage", defaultCoverImageBytes);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btnCoverPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _authorMainForm.Show();
            this.Close();
        }
    }
}
