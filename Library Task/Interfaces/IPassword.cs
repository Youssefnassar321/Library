using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Task.Interfaces
{
    internal interface IPassword
    {
        void create(string username , string pass , string confirmpass);
        void Change(string username , string oldpass , string newpass , string confirmpass);        
        void Forget(string username , string newpass , string confirmpass);     
    }
}
