using Library_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Task.Classes
{
    internal class UserClass : IUser
    {
        Library_TaskEntities db = new Library_TaskEntities();
        public void Add(string username, string role)
        {
            try
            {                
                User user = new User();
                user.UserName = username;

                Role r = new Role();
                r.UserId = user.UserId;
                r.Role1 = role;


                if (username == "" || role == "")
                {
                    MessageBox.Show("Error: Please Enter All The Data");
                }
                else
                {
                    try
                    {
                        var check = db.Users.FirstOrDefault(x => x.UserName == user.UserName);

                        if (check != null)
                        {
                            MessageBox.Show("Error: This User Name Is Already Taken");
                        }
                        else
                        {                            
                            db.Users.Add(user);
                            db.Roles.Add(r);
                            db.SaveChanges();

                            Refresh();

                            MessageBox.Show("The Data Is Added Successfully");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error: The Data Is Not Added");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void Borrow(int bookId, int nationalId, string title)
        {
            try
            {
                NationalId Id = new NationalId();
                Id.NationalId1 = nationalId;
                Id.title = title;
                Id.BookId = bookId;

                db.NationalIds.Add(Id);

                var book = db.Books.FirstOrDefault(b => b.BookId == bookId);
                if (book != null)
                {
                    book.Status = "Unavilable";
                    db.SaveChanges();
                    MessageBox.Show("The Book Is Borrowed");
                   
                }
                else
                {
                    MessageBox.Show("The Book Is Not Found");
                }
            }
            catch
            {
                MessageBox.Show("Error : Please Enter The National Id");
            }
        }

        public void Click(int index)
        {
            try
            {
                DataGridViewRow row = AddUsersForm.instance.view.Rows[index];
                UpdateUsersForm form = new UpdateUsersForm(row.Cells[0].Value.ToString(), Convert.ToInt32(row.Cells[2].Value.ToString()));
                form.Show();
            }
            catch
            {
                MessageBox.Show("Error: The Page Is Not Found");
            }
        }

        public void Delete(int id)
        {
            try
            {
                var user = db.Users.FirstOrDefault(a => a.UserId == id);

                if (user != null)
                {
                    var check = user.Roles.FirstOrDefault(r => r.UserId == id);
                    if (check != null)
                    {
                        db.Roles.Remove(check);
                        db.Users.Remove(user);
                        db.SaveChanges();

                        Refresh();

                        MessageBox.Show("The Data Is Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error : There Is No User To Delete");
                    }
                }
                else
                {
                    MessageBox.Show("Error : There Is No User To Delete");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void Refresh()
        {
            try
            {
                var list = db.Users.ToList();
                AddUsersForm.instance.view.DataSource = list;

                var _list = db.Roles.ToList();
                AddUsersForm.instance._view.DataSource = _list;

            }
            catch
            {
                MessageBox.Show("Can not Load The Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Search(string txt)
        {
            try
            {
                var list = db.Users.Where(u => u.UserName.Contains(txt)).ToList();
                AddUsersForm.instance.view.DataSource = list;
            }
            catch
            {
                MessageBox.Show("Error: There Is No Data ");
            }
        }

        public void Update(int id, string username, string role)
        {
            try
            {
                if (username == "" || role == "")
                {
                    MessageBox.Show("Error: Please Enter All The Data");
                }
                else
                {
                    var user = db.Users.FirstOrDefault(U => U.UserId == id);

                    if (user != null)
                    {
                        var change = db.Roles.FirstOrDefault(r => r.UserId == id);
                        if (change != null)
                        {
                            change.Role1 = role;
                            db.SaveChanges();

                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Error : Can Not Update The Role");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error : There Is No User To Update");
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
