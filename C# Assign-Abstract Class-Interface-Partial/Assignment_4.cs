using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{   
    //Abstract class bird
    public abstract class Bird
    {

        //Assignment 4. Interface vs.Abstract Class
        //Write a program that demonstrates the difference between an abstract class and an interface by
        //creating an abstract class Bird with an abstract method Fly(), and an interface ISwim with a
        //method Swim().


        //abstract method fly
        public abstract void Fly();


    }
    //interface ISwim
    interface ISwim
    {
        //interface method swim
        void Swim();
    }
    public class BirdChild : Bird
    {
        //Abstract method def
        public override void Fly()
        {
            Console.WriteLine("Flying in Bird");
        }
    }

    //class SwimChild
    public class SwimChild : ISwim
    {
        //Swim method def
        public void Swim()
        {
            Console.WriteLine("Swim in ISwim");
        }
    }
}
