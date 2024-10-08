using Library_Task.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MongoDB.Driver;
using MongoDB.Bson;
using Library_Task.Model;

namespace Library_Task
{
    public partial class UpdateBooksForm : Form
    {
        private ObjectId _id { get; set; }

        BookClass bookClass = new BookClass();
        Connection db = new Connection();

        public UpdateBooksForm(string title,string year, string genere, string isbn, string status, ObjectId id)
        {
            InitializeComponent();                        
            _id = id;
            titletxt.Text = title;
            //AuthorcomboBox.Text = authorId;
            yeartxt.Text = year;
            generecomboBox.Text = genere;
            isbntxt.Text = isbn;
            statuscomboBox.Text = status;
            
            var list = db.GetAuthors().Find(FilterDefinition<Authors>.Empty).ToList();
            AuthorcomboBox.DataSource = list;
            AuthorcomboBox.DisplayMember = "FirstName";
            AuthorcomboBox.ValueMember = "AuthorId";
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                bookClass.Update(_id, titletxt.Text.Trim(), (ObjectId)AuthorcomboBox.SelectedValue, Convert.ToInt32(yeartxt.Text.Trim())
                    , generecomboBox.Text.Trim(), isbntxt.Text.Trim(), statuscomboBox.Text.Trim());

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                bookClass.Delete(_id);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet16.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter3.Fill(this.library_TaskDataSet16.Authors);
            // TODO: This line of code loads data into the 'library_TaskDataSet11.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter2.Fill(this.library_TaskDataSet11.Authors);
            // TODO: This line of code loads data into the 'library_TaskDataSet10.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter1.Fill(this.library_TaskDataSet10.Authors);
            // TODO: This line of code loads data into the 'library_TaskDataSet6.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.library_TaskDataSet6.Authors);

        }
    }
}
