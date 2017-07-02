using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.Infrastructure
{
    public class TestAbstractAndVirtual 
    {
        public string test = "base value";
        public virtual string MyVirtualClass()
        {
            string s1 = string.Empty;
            return s1;
        }
    }

    public class myImplementation: TestAbstractAndVirtual
    {
        public string myNormal()
        {
            return "Normal";
        }
        public override string MyVirtualClass()
        {
            Console.WriteLine("Over Ridden");
            return base.MyVirtualClass();
        }
    }
}
