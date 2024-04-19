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
        public string email;
        public Form1()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT town_id,town_name from TOWNS", con);
            SqlCommand cmd2 = new SqlCommand("SELECT country_id,country_name from COUNTRIES", con);

            SqlCommand comd = new SqlCommand("SELECT Email FROM Users", con);
            email = cmd1.Parameters[0].ToString();

            SqlDataAdapter adapter1 = new SqlDataAdapter();
            SqlDataAdapter adapter2 = new SqlDataAdapter();

            adapter1.SelectCommand = cmd1;
            adapter2.SelectCommand = cmd2;

            DataTable townsTable = new DataTable();
            DataTable countriesTable = new DataTable();


            if (emailTextBox.Text != email)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email is already taken!");
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