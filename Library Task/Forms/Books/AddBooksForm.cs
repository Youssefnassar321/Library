using Library_Task.Classes;
using Library_Task.Model;
using MongoDB.Bson;
using MongoDB.Driver;
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


namespace Library_Task
{
    public partial class AddBooksForm : Form
    {
        public static AddBooksForm instance;
        public DataGridView view;
        BookClass bookClass = new BookClass();
        Connection db = new Connection();
        public AddBooksForm()
        {
            InitializeComponent();           
            instance = this;
            view = BooksdataGridView;

            var list = db.GetAuthors().Find(FilterDefinition<Authors>.Empty).ToList();
            AuthorcomboBox.DataSource = list;
            AuthorcomboBox.DisplayMember = "FirstName";
            AuthorcomboBox.ValueMember = "AuthorId";
        }
        private void clear()
        {
            try
            {
                titletxt.Clear();
                yeartxt.Clear();
                isbntxt.Clear();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBooksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet22.Genere' table. You can move, or remove it, as needed.
            this.genereTableAdapter.Fill(this.library_TaskDataSet22.Genere);
            // TODO: This line of code loads data into the 'library_TaskDataSet15.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter1.Fill(this.library_TaskDataSet15.Authors);
            // TODO: This line of code loads data into the 'library_TaskDataSet5.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.library_TaskDataSet5.Authors);
            // TODO: This line of code loads data into the 'library_TaskDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.library_TaskDataSet.Books);

        }

        private void CloseButton_Click(object sender, EventArgs e)
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

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            try
            {
                bookClass.Refresh();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bookClass.Search(Searchtxt.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                bookClass.Add(titletxt.Text.Trim(),(ObjectId)AuthorcomboBox.SelectedValue, int.Parse(yeartxt.Text.Trim())
                    , generecomboBox.Text.Trim(), isbntxt.Text.Trim(), statuscomboBox.Text.Trim());

                clear();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BooksdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bookClass.click(e.RowIndex);
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BooksdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AuthorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
