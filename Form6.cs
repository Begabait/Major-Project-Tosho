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
    public partial class Form6 : Form
    {
        private DataTable resultTable;
        private string email;
        public Form6(string e)
        {
            InitializeComponent();
            email = e;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            string connection_string = @"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connection_string))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                    dataGridView1.RowTemplate.Height = 200;
                    dataGridView1.DataSource = resultTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"SQL error occured. Please try again. {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unknown error occured. Please try again. {ex.Message}");
                }
            }
        }

        private void columnComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fieldComboBox.Items.Clear();
            fieldComboBox.SelectedItem = null;
            populateFilterBox2(columnComboBox.SelectedItem.ToString());
        }

        private void populateFilterBox2(string s)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True"))
                {
                    if (s == "First_name")
                    {
                        string query = $"SELECT DISTINCT First_name FROM Users";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                fieldComboBox.Items.Add(reader["First_name"].ToString());
                            }
                            reader.Close();
                        }
                    }
                    else if (s == "Last_name")
                    {
                        string query = $"SELECT DISTINCT Last_name FROM Users";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                fieldComboBox.Items.Add(reader["Last_name"].ToString());
                            }
                            reader.Close();
                        }
                    }
                    else if (s == "Email")
                    {
                        string query = $"SELECT DISTINCT Email FROM Users";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                fieldComboBox.Items.Add(reader["Email"].ToString());
                            }
                            reader.Close();
                        }
                    }
                    else if (s == "Admin")
                    {
                        string query = $"SELECT DISTINCT Admin FROM Users";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                fieldComboBox.Items.Add(reader["Admin"].ToString());
                            }
                            reader.Close();
                        }
                    }
                    else if (s == "Majors")
                    {
                        string query = $"SELECT DISTINCT Majors FROM Users";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                fieldComboBox.Items.Add(reader["Majors"].ToString());
                            }
                            reader.Close();
                        }
                    }
                    else if (s == "Main_Subject")
                    {
                        string query = $"SELECT DISTINCT Main_Subject FROM Users";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();
                            while (reader.Read())
                            {
                                fieldComboBox.Items.Add(reader["Main_Subject"].ToString());
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error with the SQL Server! Please try again!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error! Please try again!");
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True");
                con.Open();
                if (columnComboBox.SelectedItem.ToString() == "First_name")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE First_name = @fname", con);
                    cmd.Parameters.AddWithValue("@fname", fieldComboBox.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                else if (columnComboBox.SelectedItem.ToString() == "Last_name")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Last_name = @lname", con);
                    cmd.Parameters.AddWithValue("@lname", fieldComboBox.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                else if (columnComboBox.SelectedItem.ToString() == "Email")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = @email", con);
                    cmd.Parameters.AddWithValue("@email", fieldComboBox.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                else if (columnComboBox.SelectedItem.ToString() == "Admin")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Admin = @admin", con);
                    cmd.Parameters.AddWithValue("@admin", fieldComboBox.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                else if (columnComboBox.SelectedItem.ToString() == "Majors")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Majors = @majors", con);
                    cmd.Parameters.AddWithValue("@majors", fieldComboBox.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                else if (columnComboBox.SelectedItem.ToString() == "Main_Subject")
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Main_Subject = @subject", con);
                    cmd.Parameters.AddWithValue("@subject", fieldComboBox.SelectedItem.ToString());
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    resultTable = new DataTable();
                    adapter.Fill(resultTable);
                }
                dataGridView1.RowTemplate.Height = 200;
                dataGridView1.DataSource = resultTable;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error with the SQL Server! Please try again!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error! Please try again!");
            }
        }
    }
}
