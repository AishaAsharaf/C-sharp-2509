using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee_5
    {
        //Assignment 5. Polymorphism with Static Data and Methods.

        //Create a C# program that demonstrates polymorphism using a base class Employee and derived

        //classes Manager and Developer. Include a static field to keep track of the total No of employees

        public static int numberOfEmployees;
        
        static Employee_5()
        {
            numberOfEmployees = 0;
        }
        
        //A static method to display the total count.Use method overriding to demonstrate
        public static void NumberOfEmployees() {
            Console.WriteLine(numberOfEmployees + " is the no. of employees");
        }

        public virtual void DisplayInfo_5()
        {
            
            Console.WriteLine("The number of employees is " + numberOfEmployees);
        }
      
    }
    //Derived class
    public class Manager_5 : Employee_5 {
        public int numberOfManagers;
        public Manager_5(int number) {
                numberOfManagers = number;
                numberOfEmployees += numberOfManagers;
        }

        public override void DisplayInfo_5()
        {
            Console.WriteLine("The number of managers is " + numberOfManagers);
            
        }
    }
    //Derived class
    public class Developer_5 : Employee_5
    {
        public int numberOfDevelopers;
        public Developer_5(int number)
        {
            numberOfDevelopers = number;
            numberOfEmployees += numberOfDevelopers;
        }

        public override void DisplayInfo_5()
        {
            Console.WriteLine("The number of developers is " + numberOfDevelopers);
            
        }

    }
}
