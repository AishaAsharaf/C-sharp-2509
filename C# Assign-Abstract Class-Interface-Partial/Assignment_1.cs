using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    
        //Assignment 1. Abstract Class
        //Create an abstract class Vehicle that has an abstract method StartEngine() and a concrete method
        //StopEngine(). Create derived classes Car and Motorcycle that implement the StartEngine()
        //method and override it to show specific behavior for each type of vehicle.

        public abstract class Vehicle
        {
            public abstract  void StartEngine();

            public void StopEngine()
            {
                Console.WriteLine("Stoping the Engine");
            }
        }

        public class Car : Vehicle 
        {
            public  override void StartEngine()
            {
                Console.WriteLine("Starting the Engine in Car");
            }
        }

        public class Motorcycle : Vehicle
        {
            public override void StartEngine()
            {
                Console.WriteLine("Starting the Engine in Motorcycle");
            }
        }

    
}
