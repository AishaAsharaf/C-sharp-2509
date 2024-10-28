using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee_6
    {

        //Assignment 6. Polymorphism with Arrays as Properties in a Class

        //Create a C# program demonstrating polymorphism using a base class Employee and derived

        //classes Manager and Developer.In this program, each employee should have a collection of

        //tasks (stored in an array) assigned to them.Use arrays as properties in the class to handle this
        //data, and demonstrate how polymorphism and arrays work together in the solution.

        public String[] Tasks;
        public string Name;
        
        //Initialising task and name
        public Employee_6(string name, string[] tasks) { 
           Name = name;
           Tasks = tasks;
 
        }

        //Display both name and task
        public virtual void DisplayTask()
        {
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Tasks: ");
            foreach (var task in Tasks)
            {
                Console.WriteLine("- " + task);
            }
        }

        
    }

    public class Manager_6 : Employee_6
    {
        //using base, no field here as they are init in base class
        public Manager_6(string name, string[] tasks):base(name,tasks)
        {
           
        }
        //displaying manager tasks
        public override void DisplayTask()
        {
            Console.WriteLine("Manager Name : " + base.Name );
            base.DisplayTask();

        }

    }
    //Derived class
    public class Developer_6 : Employee_6
    {
        //using base, no field here as they are init in base class
        public Developer_6(string name, string[] tasks) : base(name, tasks)
        {
          
        }
        //Display
        public override void DisplayTask()
        {
            Console.WriteLine("Developer Name : " + base.Name );
            base.DisplayTask();
            
        }
    }
}
