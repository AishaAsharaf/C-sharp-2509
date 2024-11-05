using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest_Oct25
{
    public class Inherit
    { 
        public virtual void Print()
        {
            Console.WriteLine("Print A");
        }
    }

    public class Inherit_B : Inherit
    {
        public override void Print()
        {
            Console.WriteLine("Print B");
        }
    }


}
