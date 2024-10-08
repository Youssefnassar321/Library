using Library_Task.Classes;
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
    public partial class AddAuthorsForm : Form
    {
        public static AddAuthorsForm instance;
        public DataGridView view;
        AuthorClass authorClass = new AuthorClass();

        public AddAuthorsForm()
        {
            InitializeComponent();          
            instance = this;
            view = AuthorsdataGridView;           
        }

        private void clear()
        {
            try
            {
                FNtxt.Clear();
                LNtxt.Clear();
                BIOtxt.Clear();
                Searchtxt.Clear();
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
                authorClass.Refresh();

                clear();
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
                authorClass.Search(Searchtxt.Text.Trim());

                clear();
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
                authorClass.Add(FNtxt.Text.Trim(), LNtxt.Text.Trim(), BIOtxt.Text.Trim());

                clear();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddAuthorsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet1.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.library_TaskDataSet1.Authors);

        }

        private void AuthorsdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                authorClass.click(e.RowIndex);

                clear();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void AuthorsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

