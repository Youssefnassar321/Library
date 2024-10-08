using Library_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task.Classes
{
    internal class PasswordClass : IPassword
    {
        Library_TaskEntities db = new Library_TaskEntities();

        public void Change(string username, string oldpass, string newpass, string confirmpass)
        {
            try
            {
                if (newpass == "")
                {
                    MessageBox.Show("Enter The New Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var user = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == oldpass);
                    if (user != null)
                    {
                        user.Password = newpass;

                        if (newpass == confirmpass)
                        {
                            db.SaveChanges();

                            LogInForm form = new LogInForm();
                            form.Show();
                        }
                        else
                        {
                            MessageBox.Show("The Password And Confirm Password Must Be The Same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The User Name Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void create(string username, string pass, string confirmpass)
        {
            try
            {
                if (pass == "" && confirmpass == "")
                {
                    MessageBox.Show("Error: Please Enter All The Data");
                }
                else
                {

                    var user = db.Users.FirstOrDefault(u => u.UserName == username);
                    if (user != null)
                    {
                        user.Password = pass;

                        if (pass == confirmpass)
                        {
                            db.SaveChanges();
                            
                            LogInForm form = new LogInForm();
                            form.Show();

                            MessageBox.Show("The Data Is Added Successfully");
                        }
                        else
                        {
                            MessageBox.Show("The Password And Confirm Password Must Be The Same");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: The User Name Is Not Found");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void Forget(string username, string newpass, string confirmpass)
        {
            try
            {
                if (newpass == "")
                {
                    MessageBox.Show("Error: Please Enter The New Password First");
                }
                else
                {
                    var user = db.Users.FirstOrDefault(u => u.UserName == username);

                    if (user != null)
                    {
                        user.Password = newpass;
                        if (newpass == confirmpass)
                        {
                            db.SaveChanges();
                           
                            LogInForm form = new LogInForm();
                            form.Show();
                            MessageBox.Show("The Password Is Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error: The Password And Confirm Password Must Be The Same");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: Can Not Found The User");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

       
    }
}
