using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Major_Project_Tosho
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if ((!(AdminRadioButton.Checked) && !(StudentRadioButton.Checked)) || fnameTextBox.Text == String.Empty || snameTextBox.Text == String.Empty || emailTextBox.Text == String.Empty || passwordTextBox.Text == String.Empty || rpasswordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Incomplete registration form!");
            }
            else
            {
                string password = passwordTextBox.Text;
                string Pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&*?])[A-Za-z0-9!@#$%_&*?]{8,}$";

                if (Regex.IsMatch(password, Pattern))
                {
                    if (passwordTextBox.Text != rpasswordTextBox.Text)
                    {
                        MessageBox.Show("Passwords Do Not Match!", "Passwords Do Not Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string query1 = "SELECT* FROM Users WHERE Email = @Email";
                        string connection_string = @"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True";

                        using (SqlConnection connection1 = new SqlConnection(connection_string))
                        {
                            using (SqlCommand command1 = new SqlCommand(query1, connection1))
                            {
                                command1.Parameters.AddWithValue("@Email", emailTextBox.Text);

                                try
                                {
                                    connection1.Open();

                                    SqlDataAdapter adapter = new SqlDataAdapter(command1);
                                    DataTable table = new DataTable();
                                    adapter.Fill(table);

                                    if (table.Rows.Count > 0)
                                    {
                                        MessageBox.Show("Email Already In Use!", "Email Already In Use", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        string fname = fnameTextBox.Text;
                                        string sname = snameTextBox.Text;
                                        string email = emailTextBox.Text;
                                        string password_to_save = HashPassword(passwordTextBox.Text);
                                        bool admin;

                                        if (StudentRadioButton.Checked)
                                        {
                                            admin = false;
                                        }
                                        else
                                        {
                                            admin = true;
                                        }

                                        string query2 = "INSERT INTO Users (First_name, Last_name, [Password], Email, [Admin]) VALUES (@FName, @SName, @Pass, @Email, @Admin)";

                                        using (SqlConnection connection2 = new SqlConnection(connection_string))
                                        {
                                            using (SqlCommand command2 = new SqlCommand(query2, connection2))
                                            {
                                                command2.Parameters.AddWithValue("@FName", fname);
                                                command2.Parameters.AddWithValue("@SName", sname);
                                                command2.Parameters.AddWithValue("@Pass", password_to_save);
                                                command2.Parameters.AddWithValue("@Email", email);
                                                command2.Parameters.AddWithValue("@Admin", admin);

                                                try
                                                {
                                                    connection2.Open();

                                                    int rowsAffected = command2.ExecuteNonQuery();

                                                    if (rowsAffected > 0)
                                                    {
                                                        MessageBox.Show("Record added successfully!");
                                                        this.Close();
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Failed to add record!");
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
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (passwordTextBox.Text != rpasswordTextBox.Text)
                    {
                        MessageBox.Show("Passwords Do Not Match! Password Is Invalid!", "Passwords Do Not Match and Password Is Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Password Is Invalid!", "Password Is Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private string HashPassword(string password)
        {
            SHA256 hashalgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashalgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}