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
    public partial class BookViewForm : Form
    {
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        private DataTable bookData;
        public BookViewForm(DataTable data)
        {
            InitializeComponent();
            bookData = data;
            DisplayBookDetails();
        }

        private void BookViewForm_Load(object sender, EventArgs e)
        {

        }

        private void DisplayBookDetails()
        {
            if (bookData != null && bookData.Rows.Count > 0)
            {
                string bookName = bookData.Rows[0]["title"].ToString();
                string isbn = bookData.Rows[0]["ISBN"].ToString();
                string genre = bookData.Rows[0]["genre"].ToString();
                string publicationDate = bookData.Rows[0]["publicationDate"].ToString();
                byte[] coverImage = (byte[])bookData.Rows[0]["CoverImage"];
                string author = GetAuthorByISBN(isbn);

                lblSampleBookName.Text = bookName;
                lblSampleISBN.Text = isbn;
                lblSampleGenre .Text = genre;
                lblSamplePublicationDate.Text = publicationDate;
                lblSampleAuthorName.Text = author;

                MemoryStream ms = new MemoryStream(coverImage);
                imgBookCover.Image = Image.FromStream(ms);
            }
        }

        private string GetAuthorByISBN(string isbn)
        {
            string authorName = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT AUTHOR.authorName " +
                               "FROM AUTHOR " +
                               "INNER JOIN BOOK ON AUTHOR.bookID = BOOK.ISBN " +
                               "WHERE BOOK.ISBN = @ISBN";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        authorName = reader["authorName"].ToString();
                    }

                    reader.Close();
                }
            }

            return authorName;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
