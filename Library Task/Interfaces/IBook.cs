using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Library_Task.Interfaces
{
    internal interface IBook
    {
        void Add(string title, ObjectId authorId, int year, string genere, string isbn, string status);
        void Update(ObjectId id, string title, ObjectId authorId, int year, string genere, string isbn, string status);
        void Delete(ObjectId id);
        void Refresh();
        void Search(string txt);
        void click(int index);
    }
}
