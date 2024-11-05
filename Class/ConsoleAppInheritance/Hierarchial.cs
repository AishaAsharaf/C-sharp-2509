using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    public class A_Hierarchial
    {
        public void A()
        {
            Console.WriteLine("A");
        }
    }

    public class B_Class : A_Hierarchial
    {
        public void B()
        {
            Console.WriteLine("B");
            A();
        }
    }

    public class C_Class : A_Hierarchial
    {
        public void C()
        {
            Console.WriteLine("C");
            A();
        }
    }
}
