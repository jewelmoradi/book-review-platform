using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace neginmoradi_DBlab_project
{
    public partial class FriendsForm : Form
    {
        string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=neginmoradi_DBlab_project;Integrated Security=True";
        private string userEmail;
        private UserMainForm _userMainForm;
        public FriendsForm(UserMainForm userMainForm, string email)
        {
            InitializeComponent();
            _userMainForm = userMainForm;
            userEmail = email;

            LoadDataIntoDataGridView();
        }

        private void FriendsForm_Load(object sender, EventArgs e) {}

        private void LoadDataIntoDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT userName, dateOfBirth FROM USER1";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewFriends.DataSource = dataTable;
                    }
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            _userMainForm.Show();
            this.Close();
        }
    }
}
