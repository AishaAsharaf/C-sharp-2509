using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Engine_12
    {
        //Lab 12.HAS-A Relationship(Composition)
        //Problem:
        //Create a class Engine with properties like HorsePower.
        public int horsePower;

        public Engine_12(int horsepower){
            this.horsePower = horsepower;
            }
        public void Display()
        {
            Console.WriteLine(horsePower + "hp is the horse power");
        }

        
        //of Engine and shows the HAS-A relationship.Demonstrate how the Car can use its Engine to show
        //engine-related details.
    }
    //Create a class Car that contains an instance
    public class Car_12
    {
        public Engine_12 carEngine;

        public Car_12(int horsepower)
        {
            carEngine = new Engine_12(horsepower);
        }

        public void CarDetails() {
            Console.WriteLine("Car details");
            carEngine.Display();
        }
    }
}
