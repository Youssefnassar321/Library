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
    public partial class AddUsersForm : Form
    {
        public static AddUsersForm instance;
        public DataGridView view;
        public DataGridView _view;
        UserClass userClass = new UserClass();
        public AddUsersForm()
        {
            InitializeComponent();           
            instance = this;
            view = UsersdataGridView; 
            _view = RoledataGridView;
        }     
        private void AddUsersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_TaskDataSet21.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.library_TaskDataSet21.Role);
            // TODO: This line of code loads data into the 'library_TaskDataSet19.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.library_TaskDataSet19.Users);
            // TODO: This line of code loads data into the 'library_TaskDataSet2.Users' table. You can move, or remove it, as needed.
            // this.usersTableAdapter.Fill(this.library_TaskDataSet2.Users);
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

        private void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                userClass.Search(Searchtxt.Text.Trim());

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
                userClass.Refresh();
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
                userClass.Add(UserNametxt.Text.Trim() , RolecomboBox.Text.Trim());

                UserNametxt.Clear();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userClass.Click(e.RowIndex);

                UserNametxt.Clear();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsersdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
