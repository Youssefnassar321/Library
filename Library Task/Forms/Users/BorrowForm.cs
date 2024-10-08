using Library_Task.Classes;
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
    public partial class BorrowForm : Form
    {        
        private int _id;
        public BorrowForm(string title , int id)
        {
            InitializeComponent();            
            _id = id;
            titletxt.Text = title;
            
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
                UserClass userClass = new UserClass();
                userClass.Borrow(_id , Convert.ToInt32(Idtxt.Text.Trim()) , titletxt.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BorrowForm_Load(object sender, EventArgs e)
        {

        }
    }
}
