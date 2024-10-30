using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public class Assignment_10
    {
        //Assignment 10. Exception Handling
        //Write a method Divide that takes two integers as input and returns their division.If a division by
        //zero occurs, catch the exception and display a custom error message.Demonstrate exception
        //handling with a try-catch-finally block

        public void Divide(int a, int b)
        {
            if (b != 0)
            {
                double result = a / b;
                Console.WriteLine(result);
            }
            else
            {
                throw new ArgumentException("Denominater is 0");
            }
        }
    }
}
