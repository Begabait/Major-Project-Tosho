using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Major_Project_Tosho
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=BEGABAIT\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string email = "SELECT * FROM Users WHERE Email = @Email";
                using (SqlCommand checkEmail = new SqlCommand(email, con))
                {
                    checkEmail.Parameters.AddWithValue("@Email", emailTextBox.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(checkEmail);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        string password = (string)table.Rows[0]["Password"];
                        if (password == hashPassword(passwordTextBox.Text))
                        {
                            this.Hide();
                            Form3 form3 = new((bool)table.Rows[0]["Admin"], (string)table.Rows[0]["Email"]);
                            form3.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password!", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        this.Hide();
                        Form2 form2 = new();
                        form2.ShowDialog();
                        this.Show();
                    }
                }
            }
            finally { con.Close(); }
        }

        string hashPassword(string password)
        {
            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(password);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}