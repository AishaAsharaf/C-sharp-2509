using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Vehicle_3
    {
        //Assignment 3. Method Overriding
        //Write a program demonstrating method overriding by creating a base class Vehicle and a derived
        //class Car that overrides the Drive() method.

        //Drive() method
        public virtual void Drive()
        {
            Console.WriteLine("I am Driving");
        }
    }
    //Derived Car class
    public class Car_3 : Vehicle_3
    {
        //Drive() method
        public override void Drive()
        {
            Console.WriteLine("I am Driving a Car");
        }
    }
}
