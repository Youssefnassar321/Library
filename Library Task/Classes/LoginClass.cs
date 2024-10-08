using Library_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task.Classes
{
    internal class LoginClass
    {
        Library_TaskEntities db = new Library_TaskEntities();
        public void Login(string username , string password) 
        {
            try
            {                
                if (username == "")
                {
                    MessageBox.Show("Error: Please Enter The User Name");
                }
                else
                {
                    var pass = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == null);
                    if (pass != null)
                    {
                        LogInForm logInForm = new LogInForm();
                        logInForm.Hide();

                        PasswordForm form = new PasswordForm(username);
                        form.Show();
                    }
                    else
                    {
                        var user = db.Users.FirstOrDefault(u => u.UserName == username && u.Password == password);
                        if (user != null)
                        {
                            var admin = db.Roles.FirstOrDefault(r => r.UserId == user.UserId && r.Role1 == "Admin");
                            var librarian = db.Roles.FirstOrDefault(r => r.UserId == user.UserId && r.Role1 == "Librarian");
                            var guest = db.Roles.FirstOrDefault(r => r.UserId == user.UserId && r.Role1 == "Guest");

                            if (admin != null)
                            {
                                LogInForm logInForm = new LogInForm();
                                logInForm.Hide();

                                HomeForm form = new HomeForm(username, true, true, true, true, true);
                                form.Show();
                            }
                            else if (librarian != null)
                            {
                                LogInForm logInForm = new LogInForm();
                                logInForm.Hide();

                                HomeForm form = new HomeForm(username, true, false, false, false, false);
                                form.Show();
                            }
                            else if (guest != null)
                            {
                                HomeForm form = new HomeForm(username, false, false, false, false, false);
                                form.Show();
                            }
                            else
                            {
                                MessageBox.Show("Can Not Found The Role");
                            }
                        }
                        else
                        {
                            MessageBox.Show("The User Name or Password Is Incorrect");
                        }
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
