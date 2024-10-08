using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task.Forms.Users
{
    public partial class AvilableForm : Form
    {
        Library_TaskEntities db = new Library_TaskEntities();
        public AvilableForm()
        {
            InitializeComponent();
        }

        private void AvilableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet13.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter1.Fill(this.library_TaskDataSet13.Books);
            // TODO: This line of code loads data into the 'library_TaskDataSet12.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.library_TaskDataSet12.Books);

        }

        private void BooksdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = BooksdataGridView.Rows[e.RowIndex];
                BorrowForm form = new BorrowForm(row.Cells[0].Value.ToString() ,Convert.ToInt32(row.Cells[3].Value));
                form.Show();

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
                MessageBox.Show("Can Not Close The Page", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var list = db.Books.Where(b => b.Title.Contains(Searchtxt.Text.Trim())).ToList();
                BooksdataGridView.DataSource = list;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var list = db.Books.Where(b => b.Status == "Available").ToList();
                BooksdataGridView.DataSource = list;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
