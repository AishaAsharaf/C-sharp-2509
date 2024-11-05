using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Oct24
{
    public abstract class Abstract_A
    {
        public abstract void Print();         //can have access modifiers

        public void Print_Second()
        {
            Console.WriteLine("Non Abstract method");
        }
       
    }

    public class Abstract_B : Abstract_A
    {
        public override void Print()
        {
            Console.WriteLine("Absract method");
            Print_Second();
        }


    }
}
