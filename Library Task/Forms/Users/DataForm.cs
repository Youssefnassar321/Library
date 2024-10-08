using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task.Forms
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet14.NationalId' table. You can move, or remove it, as needed.
            this.nationalIdTableAdapter.Fill(this.library_TaskDataSet14.NationalId);

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
