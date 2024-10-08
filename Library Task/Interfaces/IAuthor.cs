using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Task.Interfaces
{
    internal interface IAuthor
    {
        void Add(string FName , string LName , string Biography);
        void Update(ObjectId id , string FName, string LName, string Biography);
        void Delete(ObjectId id);
        void Refresh();
        void Search(string txt);
        void click(int index);
    }
}
