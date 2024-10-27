using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Car
    {

        //Assignment 12: Counting Objects with Static and Instance Fields
        //Problem Statement: Create a class Car that counts how many instances of Car have been
        //created using a static counter.Initialize this counter using a static constructor.

        string CarName;
        public static int Counter;

        static  Car()
        {
            Counter = 0;
          
        }

        public  Car(string carName)
        {
            CarName = carName;
            Counter++;
        }



    }
}
