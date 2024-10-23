using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    internal class Class1
    {
        interface A {

            int add(int a, int b);
            void test();
        }

        interface B {
            int sub(int a, int b);        
        }

        class C : A, B
        {
            public int sub(int a, int b)
            {
                return a - b;
            }

            public int add(int a, int b)
            {
                return a + b;
            }

            void A.test()
            {
                throw new NotImplementedException();
            }

            public int add1(int a, int b)
            {
                return a + b;
            }
        }
    }
}
