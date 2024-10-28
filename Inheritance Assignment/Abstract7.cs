using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{

            //Lab 7. Abstract Classes
            //Create an abstract class and demonstrate inheritance with abstract methods.

            //Problem:
            //Create an abstract class Vehicle with an abstract method Drive(). 
        public abstract class Vehicle7
        {
            public abstract void Drive();         //can have access modifiers

            public void Print_Second()
            {
                Console.WriteLine("Non Abstract method");
            }

        }
        //Create two derived classes Car
        //and Bike that implement the Drive() method
        public class Car7 : Vehicle7
        {
            public override void Drive()
            {
                Console.WriteLine("Driving a Car");
                Print_Second();
            }


        }

        public class Bike7 : Vehicle7
        {
            public override void Drive()
            {
                Console.WriteLine("Driving a Bike");
                Print_Second();
            }


        }
  
}
