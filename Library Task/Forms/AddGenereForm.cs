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
    public partial class AddGenereForm : Form
    {
        Library_TaskEntities db = new Library_TaskEntities();
        public AddGenereForm()
        {
            InitializeComponent();
        }

        private void AddGenereForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet23.Genere' table. You can move, or remove it, as needed.
            this.genereTableAdapter.Fill(this.library_TaskDataSet23.Genere);

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

        private void Addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Generetxt.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter The Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Genere genere = new Genere();
                    genere.Genere1 = Generetxt.Text.Trim();
                    db.Generes.Add(genere);
                    db.SaveChanges();

                    var list = db.Generes.ToList();
                    GeneredataGridView.DataSource = list;

                    Generetxt.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Can Not Add", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
