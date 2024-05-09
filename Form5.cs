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

namespace Major_Project_Tosho
{
    public partial class Form5 : Form
    {
        private string email;
        private bool admin;
        public Form5(string e, bool a)
        {
            InitializeComponent();
            email = e;
            admin = a;

            if (admin)
            {
                submitButton.Enabled = false;
                subjectsComboBox.Enabled = false;
            }

            SqlConnection con = new SqlConnection(@"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT Subjects.Subject_name FROM Subjects JOIN Majors_Subjects ON Subjects.Subject_id = Majors_Subjects.Subjects_id JOIN majors ON Majors_Subjects.Majors_id = Majors.Major_id WHERE majors.major_name = 'Electrical Engineering';", con);

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = cmd;

            DataTable majorsTable = new DataTable();

            adapter.Fill(majorsTable);
            subjectsComboBox.DataSource = majorsTable;
            subjectsComboBox.DisplayMember = "Subject_name";

            con.Close();

            subjectsComboBox.Text = String.Empty;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string subject = subjectsComboBox.Text;

            string connection_string = @"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True";
            string query = "UPDATE Users SET Main_Subject = @Subject WHERE Email = @Email;";

            using (SqlConnection connection = new SqlConnection(connection_string))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Subject", subject);
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
