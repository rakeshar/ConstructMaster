using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.Infrastructure;
using MongoDB.Bson;
using MongoDB.Driver;
namespace MyTestAPp
{
    class Program
    {
        static void Main(string[] args)
        {
            GradesHomeWork gw = new GradesHomeWork();
            var test= gw.GetGrades();
            
            
            Console.ReadLine();
         
        }
    }
}
