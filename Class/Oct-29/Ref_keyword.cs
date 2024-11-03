using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct_29
{
    public class Ref_keyword
    {
        public virtual void Example(ref int number)
        {
            Console.WriteLine($"{number + 10} is the number");
        }
    }

    public class Child : Ref_keyword
    {
        public override void Example(ref int number)
        {
            Console.WriteLine($"{number + 10} is the number");
        }
    }
 
           
     



    }
