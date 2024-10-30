using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{   public class Assignment_3 {

        //Assignment 3. Interface
        //Create an interface IDrive with a method Drive(). Implement this interface in a Car and Truck
        //class, with each class having its own implementation of Drive()

        //interface
        interface IDrive
        {
            void Drive();
        }

        //interface inherited in car class
        public class Car_3 : IDrive
        {
            public void Drive()
            {
                Console.WriteLine("Driving a Car");
            }
        }
        //interface inherited in truck class
        public class Truck_3 : IDrive
        {
            public void Drive()
            {
                Console.WriteLine("Driving a Truck");
            }
        }



    }

}
