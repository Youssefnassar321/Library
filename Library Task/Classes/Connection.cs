using Library_Task.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Task.Classes
{
    internal class Connection
    {
        private IMongoDatabase _database;
        public void Connect() 
        {
            var dbclient = new MongoClient("mongodb://localhost:27017/");
            _database = dbclient.GetDatabase("Library");
        }

        public IMongoCollection<Books> GetBooks() 
        {
            Connect();
            return _database.GetCollection<Books>("Books");
        }
        public IMongoCollection<Authors> GetAuthors() 
        {
            Connect();
            return _database.GetCollection<Authors>("Authors");
        }

    }
}
