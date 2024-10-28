using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    //Lab 15. Calling Base Class Constructor Using base
    //This assignment demonstrates how to use the base keyword to call the base class constructor
    //from the derived class constructor.
    //Problem:
    //Create a base class Vehicle with a constructor that accepts brand.Derive a class Car that passes
    //values to the base class constructor using base.

    public class Vehicle_15
    {
        // Property
        public string Brand { get; set; }

        // Base class constructor
        public Vehicle_15(string brand)
        {
            Brand = brand;
            
        }
        public void DisplayInfo() {
            Console.WriteLine($"Vehicle Constructor: Brand is {Brand}");
        }
    }

   
    public class Car_15 : Vehicle_15
    {
        
        public string Model;

        //constructor
        public Car_15(string brand, string model) : base(brand)
        {
            Model = model;
            
        }

        // Method to display
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Details: Brand = {Brand}, Model = {Model}");
        }
    }

}
