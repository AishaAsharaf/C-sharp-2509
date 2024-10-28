using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Animal_11
    {

        //Lab 11. IS-A Relationship(Inheritance)

        //Problem:

        //Create a base class Animal


        //with properties like Name and methods like Eat()

        public string Name;

        // Constructor
        public Animal_11(string name)
        {
            Name = name;
        }

        public void Eat()
        {
            Console.WriteLine("Eat Method");
        }
    }
    // Derive a class Dog that inherits Animal
    public class Dog_11 : Animal_11
    {
        public Dog_11(string name) : base(name)
        {
        }

        //Add a method Bark().
        public void Bark()
        {
            Console.WriteLine(Name + " is Barking");
        }
    }
}

