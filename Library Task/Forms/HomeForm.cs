using Library_Task.Forms;
using Library_Task.Forms.Users;
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
    public partial class HomeForm : Form
    {       
        private string _username {  get; set; }

        public HomeForm(string username, bool data, bool books, bool Authors, bool users, bool genere)
        {
            InitializeComponent();                         
            Booksbutton.Visible = books;
            Authorsbutton.Visible = Authors;
            Usersbutton.Visible = users;
            Databutton.Visible = data;
            Generebutton.Visible = genere;
            _username = username;
            Hellolabel.Text = $"Hello {username}";          
        }

        private void CloseButton_Click(object sender, EventArgs e)
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

        private void Homebutton_Click(object sender, EventArgs e)
        {

        }

        private void Booksbutton_Click(object sender, EventArgs e)
        {
            try
            {
                AddBooksForm form = new AddBooksForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Authorsbutton_Click(object sender, EventArgs e)
        {
            try
            {                
                AddAuthorsForm form = new AddAuthorsForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Usersbutton_Click(object sender, EventArgs e)
        {
            try
            {
                AddUsersForm form = new AddUsersForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            try
            {
                //ViewForm form = new ViewForm();
                //form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Passwordbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ChangePassForm form = new ChangePassForm(_username);
                form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AvilableForm form = new AvilableForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataForm form = new DataForm();
            form.Show();
        }

        private void Generebutton_Click(object sender, EventArgs e)
        {
            try
            {
                AddGenereForm form = new AddGenereForm();
                form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
