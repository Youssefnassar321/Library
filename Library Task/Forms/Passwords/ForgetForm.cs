using Library_Task.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task
{
    public partial class ForgetForm : Form
    {
        private string _username {  get; set; }

        PasswordClass passwordClass = new PasswordClass();

        public ForgetForm(string username)
        {
            InitializeComponent();            
            _username = username;            
        }

        private void ForgetForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                passwordClass.Forget(_username, Newpasstxt.Text.Trim(), confirmpasswordtxt.Text.Trim());
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error: Can Not Close The Page");
            }
        }

        private void Showpic_Click(object sender, EventArgs e)
        {
            try
            {
                Showpic.Hide();
                Hidepic.Show();
                Newpasstxt.UseSystemPasswordChar = false;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Hidepic_Click(object sender, EventArgs e)
        {
            try
            {
                Hidepic.Hide();
                Showpic.Show();
                Newpasstxt.UseSystemPasswordChar = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Showpic2_Click(object sender, EventArgs e)
        {
            try
            {
                Showpic2.Hide();
                Hidepic2.Show();
                confirmpasswordtxt.UseSystemPasswordChar = false;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Hidepic2_Click(object sender, EventArgs e)
        {
            try
            {
                Hidepic2.Hide();
                Showpic2.Show();
                confirmpasswordtxt.UseSystemPasswordChar = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
