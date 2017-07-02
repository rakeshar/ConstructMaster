using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;

namespace CM.Infrastructure
{
    public class Student
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
        [BsonElement("student_id")]
        public int Student_Id { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
        [BsonElement("score")]
        [BsonRepresentation(BsonType.Double, AllowTruncation = true)]
        public float Score { get; set; }
    }
}
