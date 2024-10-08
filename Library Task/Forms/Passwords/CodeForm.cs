using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task
{    
    public partial class CodeForm : Form
    {
        public string randomcode {  get; set; }
        private string _username {  get; set; }
        public CodeForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void CodeForm_Load(object sender, EventArgs e)
        {

        }

        private void Confirmbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if(randomcode == Codetxt.Text)
                {
                    this.Hide();

                    ForgetForm form = new ForgetForm(_username);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Error: The Code Is Incorect");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string to, from, password, messagebody;

                Random random = new Random();
                randomcode = (random.Next(99999)).ToString();

                MailMessage mail = new MailMessage();
                to = Emailtxt.Text.Trim();
                from = "nnassar737@gmail.com";
                password = "eajg qudy yvyq qqhd";
                messagebody = $"Hello {_username} Your Reset Code Is {randomcode}";

                mail.To.Add(to);
                mail.From = new MailAddress(from);
                mail.Body = messagebody;
                mail.Subject = "Your Password Reset Code";

                SmtpClient smtp = new SmtpClient();
                smtp.EnableSsl = true;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, password);
                try
                {
                    smtp.Send(mail);
                    MessageBox.Show("The Code Sent Successfully");
                }
                catch
                {
                    MessageBox.Show("Error: The Email Is Incorrect");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

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
    }
}
