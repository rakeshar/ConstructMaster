using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Infrastructure
{
    public class LearningClass
    {
        int[] simple = new int[] { 10, 12, 14, 16, 18 };
      public void testM()
        {
            int[] hello = new int[15];
            Array.Copy(simple,hello, 0);
            hello[2] = 13;
            foreach(int i in hello)
            {
                Console.WriteLine("Cloned Value");
                Console.WriteLine(i.ToString());
            }
            foreach (int i in simple)
            {
                Console.WriteLine("Original Value");
                Console.WriteLine(i.ToString());
            }
        }
       
    }

    public sealed class TESTSEALED
    {
        public string ReturnThis()
        {
            return "This Is coming from a Sealed Class Non sealed member";
        }
    }

}

