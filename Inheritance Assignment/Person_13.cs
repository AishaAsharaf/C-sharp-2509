using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //Lab 13. Calling Base Class Method Using base
    //Problem:
    //Create a base class Person with a method DisplayInfo(). Derive a class Employee that overrides
    //DisplayInfo() but still calls the base class's DisplayInfo() using base.

    public class Person_13
    {
        public string Name;
        public int Age;

        // Constructor
        public Person_13(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Method to display basic info
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Derived class Employee
    public class Employee : Person_13
    {
        public string Position;

        // Constructor
        public Employee(string name, int age, string position) : base(name, age)
        {
            Position = position;
        }

        // Override DisplayInfo() method
        public override void DisplayInfo()
        {
            // Call base class's DisplayInfo()
            base.DisplayInfo();

            // Additional info
            Console.WriteLine($"Position: {Position}");
        }
    }

}
