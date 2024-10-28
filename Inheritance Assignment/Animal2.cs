using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{   //Lab 2. Multilevel Inheritance
    //In Multilevel Inheritance, a class is derived from another derived class.
    public class Animal2
    {
        
        //Problem:
        //Create a base class Animal with a method Eat()
        
        

        public void Eat()
        {
            Console.WriteLine("Eat Method");
        }
    }
    // Derive a class Dog that inherits Animal
    public class Dog : Animal2 {

        
        //Add a method Bark().
        public void Bark()
        {
            Console.WriteLine("Bark method");
        }   
    }
    //Further derive a class Puppy from Dog
    public class Puppy : Dog
    {   //and add a method Weep()
        public void Weep()
        {
            Console.WriteLine("Weep method");
        }
    }
}
