using Library_Task.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task
{
    public partial class PasswordForm : Form
    {
        private string _username {  get; set; }

        PasswordClass passwordClass = new PasswordClass();
        public PasswordForm(string username)
        {
            InitializeComponent();
            _username = username;
           
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                LogInForm form = new LogInForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("Error: Can Not Close The Page");
            }
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                passwordClass.create(_username , passwordtxt.Text.Trim() , confirmpasswordtxt.Text.Trim());
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void Showpic_Click(object sender, EventArgs e)
        {
            try
            {
                Showpic.Hide();
                Hidepic.Show();
                passwordtxt.UseSystemPasswordChar = false;
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
                passwordtxt.UseSystemPasswordChar = true;
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
