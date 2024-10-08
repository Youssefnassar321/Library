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
    public partial class AvailableForm : Form
    {
        public AvailableForm()
        {
            InitializeComponent();
        }

        private void AvailableForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet9.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.library_TaskDataSet9.Books);

        }

        private void AuthorsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void AuthorsdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = BooksdataGridView.Rows[e.RowIndex];                               
            }
            catch
            {
                MessageBox.Show("Error: Can Not Close The Page");
            }
        }
    }
}
