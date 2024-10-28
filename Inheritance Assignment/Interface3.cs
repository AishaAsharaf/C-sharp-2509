using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Interface3
    {
        /*Lab 3. Multiple Inheritance (via Interfaces)
        C# does not support multiple inheritance directly, but it can be achieved using interfaces.*/

        //Problem:

        //Create two interfaces IPrintable 
        interface IPrintable
        {
            void Print();
        }


        //and IScannable with 
        interface IScannable
        {
            void Scan();
        }

        //respective methods Print() 
        //and Scan().


        //Implement both interfaces in a class PrinterScanner.
        public class PrinterScanner : IPrintable, IScannable
        {
            public void Print()
            {
                Console.WriteLine("Print");
            }
            public void Scan()
            {
                Console.WriteLine("Scan");
            }
        }
    }
}
