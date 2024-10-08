using Library_Task.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using Library_Task.Model;

namespace Library_Task.Classes
{
    internal class BookClass : IBook
    {
        //Library_TaskEntities db = new Library_TaskEntities();
        Connection db = new Connection();

        public void Add(string title, ObjectId authorId, int year, string genere, string isbn, string status)
        {
            try
            {
                Books books = new Books()
                {
                    Title = title,
                    AuthorId = authorId,
                    PublishedYear = year,
                    Genere = genere,
                    ISBN = isbn,
                    ArchiveStatus = status
                };

                if (isbn == "" || status == "" || genere == "")
                {
                    MessageBox.Show("Please Enter All The Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Regex.IsMatch(title, "[a-zA-Z]"))
                    {
                        if (Regex.IsMatch(year.ToString(), @"^(18[0-9]{2}|19[0-9]{2}|20[0-1][0-9]|202[0-4])$"))
                        {
                            try
                            {
                               
                                db.GetBooks().InsertOne(books);


                                Refresh();

                                MessageBox.Show("The Data Is Added Successfully", "Done", MessageBoxButtons.OK);

                            }
                            catch
                            {
                                MessageBox.Show("The Data Is Not Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unvalid Year", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Title Must Contains Letters Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DataGridViewRow row = AddBooksForm.instance.view.Rows[index];
                UpdateBooksForm form = new UpdateBooksForm(row.Cells[0].Value.ToString(), row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(), row.Cells[4].Value.ToString(), row.Cells[5].Value.ToString()
                    , ObjectId.Parse(row.Cells["BookId"].Value.ToString()));
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
                var book = db.GetBooks().Find(b => b.BookId == id).FirstOrDefault();
                var filter = Builders<Books>.Filter.Eq(b => b.BookId, book.BookId);

                if (book != null)
                {
                    db.GetBooks().DeleteOne(filter);

                    Refresh();

                    MessageBox.Show("The Data Is Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Error : There Is No Book To Delete");
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
                var list = db.GetBooks().Find(FilterDefinition<Books>.Empty).ToList();
                AddBooksForm.instance.view.DataSource = list;
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
                var list = db.GetBooks().Find(b => b.Title.Contains(txt)).ToList();
                AddBooksForm.instance.view.DataSource = list;
            }
            catch
            {
                MessageBox.Show("There Is No Data ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(ObjectId id, string title, ObjectId authorId, int year, string genere, string isbn, string status)
        {
            try
            {
                if (isbn == "" || genere == "" || status == "")
                {
                    MessageBox.Show("Error: Please Enter All The Data");
                }
                else
                {
                    if (Regex.IsMatch(title, "[a-zA-Z]"))
                    {
                        if (Regex.IsMatch(year.ToString(), @"^(18[0-9]{2}|19[0-9]{2}|20[0-1][0-9]|202[0-4])$"))
                        {
                            var book = db.GetBooks().Find(b => b.BookId == id).FirstOrDefault();
                            book.Title = title;
                            book.AuthorId = authorId;
                            book.PublishedYear = year;
                            book.Genere = genere;
                            book.ISBN = isbn;
                            book.ArchiveStatus = status;

                            if (book != null)
                            {
                                var update = Builders<Books>.Update
                                    .Set(b => b.Title, book.Title)
                                    .Set(b => b.AuthorId, book.AuthorId)
                                    .Set(b => b.PublishedYear, book.PublishedYear)
                                    .Set(b => b.Genere, book.Genere)
                                    .Set(b => b.ISBN, book.ISBN)
                                    .Set(b => b.ArchiveStatus, book.ArchiveStatus);

                                    var filter = Builders<Books>.Filter.Eq(b => b.BookId , book.BookId);


                                db.GetBooks().UpdateOne(filter , update);
                                MessageBox.Show("The Data Is Updated Successfully");

                                Refresh();
                            }
                            else
                            {
                                MessageBox.Show("Error : There Is No Book To Update");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error: Unvalid Year");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error: The Title Must Contains Letters Only");
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
