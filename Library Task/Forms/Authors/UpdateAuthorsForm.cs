using Library_Task.Classes;
using MongoDB.Bson;
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

namespace Library_Task
{
    public partial class UpdateAuthorsForm : Form
    {
        private ObjectId _id {  get; set; }

        AuthorClass authorClass = new AuthorClass();

        public UpdateAuthorsForm(string FName, string LName, string Biographay, ObjectId id)
        {
            InitializeComponent();            
            _id = id;
            FNtxt.Text = FName;
            LNtxt.Text = LName;
            BIOtxt.Text = Biographay;            
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

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                authorClass.Delete(_id);

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
                authorClass.Update(_id, FNtxt.Text.Trim(), LNtxt.Text.Trim(), BIOtxt.Text.Trim());

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAuthorsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
