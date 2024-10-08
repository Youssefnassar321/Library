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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_Task
{
    public partial class LogInForm : Form
    {
        
        public LogInForm()
        {
            InitializeComponent();            
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                LoginClass loginClass = new LoginClass();
                loginClass.Login(UserNametxt.Text.Trim() , passwordtxt.Text.Trim());

                this.Hide();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserNametxt.Text.Trim() == "")
                {
                    MessageBox.Show("Error: Please Enter The User Name First");
                }
                else
                {
                    this.Hide();                    
                    CodeForm form = new CodeForm(UserNametxt.Text.Trim());
                    form.Show();
                }
            }
            catch
            {
                MessageBox.Show("Error: Can Not Open This Page");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
         
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UserNametxt_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Showpic_Click_1(object sender, EventArgs e)
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

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
