using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Task.Interfaces
{
    internal interface IUser
    {
        void Add(string username , string role);
        void Update(int id , string username, string role);
        void Delete(int id);
        void Refresh();
        void Search(string txt);
        void Borrow(int bookId , int nationalId , string title);
        void Click(int index);
    }
}
