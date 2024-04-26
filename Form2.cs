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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                    MessageBox.Show("Valid");
                    SqlCommand cmd = new SqlCommand("Insert Into [Password] from Users, @\"Data Source=LAB108PC07\\SQLEXPRESS;Initial Catalog=Tulane_Tech;Integrated Security=True\"");
                }
                else
                {
                    MessageBox.Show("Invalid");
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
        private void button1_Click(object sender, EventArgs e)
        {
            string salt = "";
            {
                salt = DateTime.Now.ToString();
            }
            string password = passwordTextBox.Text;
            HashPassword($"{password}{salt}");
            MessageBox.Show(HashPassword(password));
        }
    }
    //aideeeeeee
}