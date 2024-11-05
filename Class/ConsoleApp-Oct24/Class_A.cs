using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Oct24
{

    public class Class_A
    {
        interface A
        {
            void Print1();
        }

        interface B   //Cannot have access modifiers
        {
            void Print2();
        }

        public class C : A, B
        {


             public void Print1()
            {
                Console.WriteLine("a");
            }

           

             public void Print2()
            {
                Console.WriteLine("b");
            }

           
        }
    }
}
