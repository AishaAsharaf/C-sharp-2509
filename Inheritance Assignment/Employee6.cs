using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Employee6
    {
            // Lab 6. Overriding Methods in Inheritance
            //Demonstrate method overriding where a base class method is overridden in the derived class.

            //Problem:
            //Create a class Employee with a method Work().

            public virtual void Work()
        {
            Console.WriteLine("Work done by employeee");
        }
           
    }
    //Derive a class Manager that overrides the
    public class Manager6 : Employee6
    {
        public override void Work()
        {
            Console.WriteLine("Work done by Mangaer");
        }
    }
    //Work() method to show a different implementation.
}
