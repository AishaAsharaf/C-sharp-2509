using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Lab_7_example
    {
        public class Printer
        {
            // Early Binding - Method Overloading
            public void Print(string message)
            {
                Console.WriteLine("Printing text: " + message);
            }

            public void Print(int number)
            {
                Console.WriteLine("Printing number: " + number);
            }
        }

        public class Animal
        {
            // Late Binding - Virtual Method for Runtime Polymorphism
            public virtual void Speak()
            {
                Console.WriteLine("The animal makes a sound.");
            }
        }

        public class Dog : Animal
        {
            // Overriding 
            public override void Speak()
            {
                Console.WriteLine("The dog barks.");
            }
        }

        

    }
}
