using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Library_Task.Model
{
    internal class Books
    {
        [BsonId]
        public ObjectId BookId { get; set; }
        public string Title { get; set; }

        [ForeignKey("Authors")]
        public ObjectId AuthorId { get; set; }
        public int PublishedYear { get; set; }
        public string Genere { get; set; }
        public string ISBN { get; set; }
        public string ArchiveStatus { get; set; }
        public string Status { get; set; }

    }
}
