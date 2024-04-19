using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }

    private void button6_Click(object sender, EventArgs e)
    {
        if (usernames.Contains(textBox4.Text))
        {
            MessageBox.Show("User already exist, try logging in instead!");
        }
        else if (textBox4.Text != String.Empty && textBox5.Text != String.Empty)
        {

        }
    }

    string hashPassword(string password)
    {
        SHA256 hashAlgorithm = SHA256.Create();
        var bytes = Encoding.Default.GetBytes(password);
        var hash = hashAlgorithm.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }

    private void button7_Click(object sender, EventArgs e)
    {
        string password = textBox5.Text;
        string Pattern = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%_&*?])[A-Za-z0-9!@#$%_&*?]{8,}$";
        if (Regex.IsMatch(password, Pattern))
        {
            string salt = "";
            {
                salt = DateTime.Now.ToString();
            }

            string password = textBox5.Text;

            hashPassword($"{password}{salt}");
            MessageBox.Show(hashPassword(password));
            usernames.Add(textBox4.Text);
            passwords.Add(hashPassword(textBox5.Text));
        }
        else
        {
            MessageBox.Show("Invalid");
        }
    }
}
