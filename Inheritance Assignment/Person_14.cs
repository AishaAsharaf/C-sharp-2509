using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceAssignments
{
    //Lab 14. Accessing Base Class Variable Using base
    //Problem:
    //Create a base class Person with a property Name.In the derived class Student, hide the Name
    //property using the new keyword and use base to access the base class's Name property.

    public class Person_14
    {

        public string Name;

        // Constructor
        public Person_14(string name)
        {
            Name = name;
        }

        // Method to display base class name
        public void DisplayBaseName()
        {
            Console.WriteLine($"Base class Name: {Name}");
        }
    }

    
    public class Student_14 : Person_14
    {
        // Derived class property hiding base class property
        public new string Name;

        // Constructor
        public Student_14(string baseName, string studentName) : base(baseName)
        {
            Name = studentName;
        }

        // Method to display both base and derived class names
        public void DisplayNames()
        {
            Console.WriteLine($"Derived class Name: {Name}");

            
            Console.WriteLine($"Base class Name: {base.Name}");
        }
    }
}
