using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
namespace CM.Infrastructure
{
    public class GradesHomeWork
    {
        IMongoDatabase dbContext;
        public GradesHomeWork()
        {
            MongoClient mongoC = new MongoClient();
            dbContext = mongoC.GetDatabase("students");
        }

        public List<Student> GetGrades()
        {
           
            try
            {
                var col = dbContext.GetCollection<Student>("grades");
                var filter = new BsonDocument("type", new BsonDocument("$ne", "homework"));
              

                var iems = col.Find(new BsonDocument()).Sort(Builders<Student>.Sort.Ascending("student_id").Ascending("score")).ToList();
                iems = col.Find(new BsonDocument()).ToList();
                return iems;
              
            }
            catch (Exception ex)
            {
                throw ;
            }
            return null;
           
        }
    }
}
