using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Person1
    {
        /*Lab 1. Single Inheritance
         In Single Inheritance, a derived class inherits from a single base class.
         Problem:

         Create a base class Person with 

         properties like Name and Age. 

         Derive a class Student from

         Person and add a property Grade.

         Create objects and display the data */

        public string Name;
        public int Age;
        public Person1(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Student : Person1 {

        public string Grade;

        public Student(string name, int age,string grade) : base(name,age)
        {
            Grade = grade;
        }

        public void DisplayAll()
        {
            Console.WriteLine($"Name : {Name}, Age  : {Age}, Grade : {Grade}");
        }

    
    
    }
}
