using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Project_Tosho
{
    public partial class Form3 : Form
    {
        private string email;
        private bool admin;
        public Form3(bool a, string e)
        {
            InitializeComponent();
            if (a == true)
            {
                adminButton.Enabled = true;
                admin = true;
            }
            else
            {
                admin = false;
            }
            email = e;
        }

        private void majorsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new(email, admin);
            form4.ShowDialog();
            this.Show();
        }

        private void subjectsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new(email, admin);
            form5.ShowDialog();
            this.Show();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new(email);
            form6.ShowDialog();
            this.Show();
        }
    }
}
