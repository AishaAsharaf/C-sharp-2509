using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Car2
    {
        //Assignment 16: Identifying the Need for Chained Constructors
        //Tasks:
        //1. Create a class named Car with the following:
        //o Fields for make, model, year, and price.
        //o Multiple constructors:
        // A constructor that initializes only the make.
        // A constructor that initializes make and model.
        // A constructor that initializes make, model, and year.
        // A constructor that initializes all fields: make, model, year, and price.
        //o Use constructor chaining to avoid duplicating the logic for initializing fields.
        //2. In the Main() method:
        //o Create several Car objects using different constructors.
        //o Display the details of each car to verify that all fields are initialized correctly.

        public string Made ;
        public string Model ;
        public int Year ;
        public double Price ;

        public Car2(string made){
            this.Made = made;
            this.Model = "Unknown";
            this.Year = 0;
            this.Price = 0;

    }
        public Car2(string made,string model):this(made)
        {
            
            this.Model = model;
            

        }
        public Car2(string made, string model,int year) : this(made,model)
        {
            
            this.Year = year;
           
            

        }

        public Car2(string made, string model, int year,double price) : this(made, model,year)
        {
            
            this.Price = price;

        }

        public void DisplayAll()
        {
            Console.WriteLine($"Made : {Made}, Model : {Model}, Year : {Year}, Price : {Price}");
        }
    }
}
