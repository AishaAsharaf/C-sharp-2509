using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Person9
    {
        //Lab 9. Constructor Chaining
        //Demonstrate how constructors are called in a class hierarchy.

        //Problem:
        //Create a base class Person
       
        public string Name;
        public int Age;

        //with a parameterized constructor.
        public Person9(string name, int age)
        {
            Name = name;
            Age = age;
        }


    }

    //Create a derived class Employee

    public class Employee9 : Person9
    {
        public string ID;
        public string Company;

        public Employee9(string name, int age, string company, string id) : base(name, age) {  //base refers to parent class
            ID = id;
            Company = company;
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name}, Age : {Age}, Company : {Company} , ID : {ID}");
        }
    }
    //that calls the base class constructor.
}
