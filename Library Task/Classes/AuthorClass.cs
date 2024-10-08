using Library_Task.Interfaces;
using Library_Task.Model;
using MongoDB.Bson;
using MongoDB.Driver;
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
    internal class AuthorClass : IAuthor
    {
        //Library_TaskEntities db = new Library_TaskEntities();
        Connection db = new Connection();
        public void Add(string FName, string LName, string Biography)
        {
            try
            {
                Authors authors = new Authors();
                authors.FirstName = FName;
                authors.LastName = LName;
                authors.Biography = Biography;

                if (Biography == "" || FName == "" || LName == "")
                {
                    MessageBox.Show("Please Enter All The Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Regex.IsMatch(FName, "[a-zA-Z]") && Regex.IsMatch(LName, "[a-zA-Z]"))
                    {
                        try
                        {
                            db.Connect();
                            db.GetAuthors().InsertOne(authors);

                            Refresh();

                            MessageBox.Show("The Data Is Added Successfully");
                        }
                        catch
                        {
                            MessageBox.Show("The Data Is Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The First Name & Last Name Must Contains Letters Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void click(int index)
        {
            try
            {
                DataGridViewRow row = AddAuthorsForm.instance.view.Rows[index];

                UpdateAuthorsForm form = new UpdateAuthorsForm(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(),
                    ObjectId.Parse(row.Cells[3].Value.ToString()));

                form.Show();
            }
            catch
            {
                MessageBox.Show("The Page Is Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(ObjectId id)
        {
            try
            {
                var author = db.GetAuthors().Find(a => a.AuthorId == id).FirstOrDefault();
                var filter = Builders<Authors>.Filter.Eq(a => a.AuthorId, author.AuthorId);
                db.GetAuthors().DeleteOne(filter);
                

                Refresh();
            }
            catch
            {
                MessageBox.Show("Error: There Is No Data To Delete");
            }
        }

        public void Refresh()
        {
            try
            {
                var list = db.GetAuthors().Find(FilterDefinition<Authors>.Empty).ToList();
                AddAuthorsForm.instance.view.DataSource = list;
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
                var list = db.GetAuthors().Find(a => a.FirstName.Contains(txt)).ToList();
                AddAuthorsForm.instance.view.DataSource = list;
            }
            catch
            {
                MessageBox.Show("There Is No Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(ObjectId id, string FName, string LName, string Biography)
        {
            try
            {
                if (Biography == "" || FName == "" || LName == "")
                {
                    MessageBox.Show("Error: Please Enter All The Data");
                }
                else
                {
                    if (Regex.IsMatch(FName, "[a-zA-Z]") && Regex.IsMatch(LName, "[a-zA-Z]"))
                    {
                        var author = db.GetAuthors().Find(a => a.AuthorId == id).FirstOrDefault();
                        author.FirstName = FName;
                        author.LastName = LName;
                        author.Biography = Biography;

                        if (author != null)
                        {
                            var update = Builders<Authors>.Update
                                .Set(a => a.FirstName, author.FirstName)
                                .Set(a => a.LastName, author.LastName)
                                .Set(a => a.Biography, author.Biography);

                            var filter = Builders<Authors>.Filter.Eq(a => a.AuthorId, author.AuthorId);

                            db.GetAuthors().UpdateOne(filter , update );

                            Refresh();

                            MessageBox.Show("Error: The Data Is Updated Successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error: There Is No Data To Update");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: The First Name & Last Name Must Contains Letters Only");
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
