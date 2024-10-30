using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public class Car_11
    {
        //Assignment 11. Enum
        //Create an enum CarType with values Sedan, SUV, Truck, and Coupe.Write a Car class with a
        //property Type of type CarType.Write a method that takes a CarType value and displays a
        //message specific to that type of car.

        public CarType Type { get; set; }  

        //Method to display 
        public void DisplayEnum(CarType value)
            {
            switch (value)
            {
                case CarType.Sedan:
                    Console.WriteLine("The Sedan");
                    break;
                case CarType.SUV:
                    Console.WriteLine("The SUV");
                    break;
                case CarType.Sports:
                    Console.WriteLine("The Sports car");
                    break;
                case CarType.Truck:
                    Console.WriteLine("The Truck ");
                    break;
                case CarType.Coupe:
                    Console.WriteLine("The Coupe");
                    break;
                default:
                    Console.WriteLine("Unknown car type.");
                    break;
            }

        }

        //enum constants
        public enum CarType
        {
            Sedan, //0
            SUV,   //1
            Sports, //2
            Truck,  //3
            Coupe   //4
        }
    }
}
