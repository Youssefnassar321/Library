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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
            
        }

        private void ViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet8.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.library_TaskDataSet8.Books);
            // TODO: This line of code loads data into the 'library_TaskDataSet7.Buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.library_TaskDataSet7.Buy);
            // TODO: This line of code loads data into the 'library_TaskDataSet4.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.library_TaskDataSet4.Authors);
            // TODO: This line of code loads data into the 'library_TaskDataSet3.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.library_TaskDataSet3.Books);

        }

        private void Refbookbtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (Library_TaskEntities db = new Library_TaskEntities())
                {
                   var list = db.Books.ToList();
                   BooksdataGridView.DataSource = list;
                }
            }
            catch
            {
                MessageBox.Show("Error: Can Not Refresh The Book Data Grid");
            }
        }

        private void RefAuthorBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (Library_TaskEntities db = new Library_TaskEntities())
                {
                    var list = db.Authors.ToList();
                    AuthorsdataGridView.DataSource = list;
                }
            }
            catch
            {
                MessageBox.Show("Error: Can Not Refresh The Author Data Grid");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (Library_TaskEntities db = new Library_TaskEntities())
                {
                    var list = db.Authors.Where(a => a.FirstName.Contains(SearchAuthorstxt.Text.Trim())).ToList();
                    AuthorsdataGridView.DataSource = list;
                }
            }
            catch
            {
                MessageBox.Show("Error: There Is No Data");
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (Library_TaskEntities db = new Library_TaskEntities())
                {
                    var list = db.Books.Where(b => b.Title.Contains(SearchBookstxt.Text.Trim())).ToList();
                    BooksdataGridView.DataSource = list;
                }
            }
            catch
            {
                MessageBox.Show("Error: There Is No Data");
            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void BooksdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
