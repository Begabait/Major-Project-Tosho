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
        SqlConnection con = new SqlConnection(@"Data Source=LAB108PC07\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand comd = new SqlCommand("SELECT Email FROM Users", con);
            string email = "SELECT * FROM Users WHERE Email = @Email";
            using (SqlCommand checkEmail = new SqlCommand(email, con))
            {
                string date = DateTime.Now.ToString();
                MessageBox.Show(date);
                checkEmail.Parameters.AddWithValue("@Email", emailTextBox.Text);

                SqlDataAdapter adapter = new SqlDataAdapter(checkEmail);
                DataTable table = new DataTable();
                adapter.Fill(table);


                if (table.Rows.Count > 0)
                {
                    string password = (string)table.Rows[0]["Password"];
                    //MessageBox.Show(emailTextBox.Text + " is already taken", "Email Taken", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (password == passwordTextBox.Text)
                    {
                        MessageBox.Show("password yesss");
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

            con.Close();
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