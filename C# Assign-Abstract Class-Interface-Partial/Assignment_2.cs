using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public class Animal
    {
        //Assignment 2. Virtual Functions
        //Create a base class Animal with a virtual method MakeSound(). Derive classes Dog and Cat that
        //override the MakeSound() method to provide their specific implementation.

        public virtual void MakeSound()
        {
            Console.WriteLine("Animals make sounds");
        }

    }

    public class Cat : Animal {

        public override void MakeSound()
        {
            Console.WriteLine("Cats Meow");
        }


    }

    public class Dog : Animal
    {

        public override void MakeSound()
        {
            Console.WriteLine("Dogs Bark");
        }


    }
}
