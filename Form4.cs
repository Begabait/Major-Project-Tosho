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
using System.Xml.Linq;

namespace Major_Project_Tosho
{
    public partial class Form4 : Form
    {
        private string email;
        private bool admin;
        public Form4(string e, bool a)
        {
            InitializeComponent();

            email = e;
            admin = a;

            if (admin)
            {
                submitButton.Enabled = false;
                majorsComboBox.Enabled = false;
            }

            SqlConnection con = new SqlConnection(@"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT Major_id, Major_name from Majors", con);

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            DataTable majorsTable = new DataTable();

            adapter.Fill(majorsTable);
            majorsComboBox.DataSource = majorsTable;
            majorsComboBox.DisplayMember = "Major_name";
            majorsComboBox.ValueMember = "Major_id";

            con.Close();

            majorsComboBox.Text = String.Empty;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string major = majorsComboBox.Text;

            string connection_string = @"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True";
            string query = "UPDATE Users SET Majors = @Major WHERE Email = @Email;";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Major", major);
                    command.Parameters.AddWithValue("@Email", email);

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record altered successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to alter record!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
