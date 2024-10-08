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
    public partial class ChangePassForm : Form
    {
        private string _username {  get; set; }

        PasswordClass passwordClass = new PasswordClass();
        public ChangePassForm(string username)
        {
            InitializeComponent();            
            _username = username;            
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Can Not Close The Page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                passwordClass.Change(_username, Oldpasstxt.Text.Trim(), Newpasstxt.Text.Trim(), confirmpasswordtxt.Text.Trim());
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassForm_Load(object sender, EventArgs e)
        {
           
        }

        private void Showpic_Click(object sender, EventArgs e)
        {
            try
            {
                Showpic.Hide();
                Hidepic.Show();
                Oldpasstxt.UseSystemPasswordChar = false;
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
                Oldpasstxt.UseSystemPasswordChar = true;
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
                Newpasstxt.UseSystemPasswordChar = false;
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
                Newpasstxt.UseSystemPasswordChar = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Showpic3_Click(object sender, EventArgs e)
        {
            try
            {
                Showpic3.Hide();
                Hidepic3.Show();
                confirmpasswordtxt.UseSystemPasswordChar = false;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Hidepic3_Click(object sender, EventArgs e)
        {
            try
            {
                Hidepic3.Hide();
                Showpic3.Show();
                confirmpasswordtxt.UseSystemPasswordChar = true;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
