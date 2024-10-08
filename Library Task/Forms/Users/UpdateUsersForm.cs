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
    public partial class UpdateUsersForm : Form
    {
        private int _id;
        Library_TaskEntities db = new Library_TaskEntities();
        public UpdateUsersForm(string txt1 , int id )
        {
            InitializeComponent();                   
            _id = id;
            UserNametxt.Text = txt1;                                  
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

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            try
            {
                UserClass userClass = new UserClass();
                userClass.Update(_id , UserNametxt.Text.Trim() , RolecomboBox.Text.Trim());

                UserNametxt.Clear();
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
                UserClass userClass = new UserClass();
                userClass.Delete(_id);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUsersForm_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
}
