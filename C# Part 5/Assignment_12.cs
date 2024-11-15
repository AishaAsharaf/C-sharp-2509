using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    public class NegativeCheck
    {
        //Assignment 12. Custom Exception
        //Question: Create a custom exception class NegativeNumberException to handle negative inputs.
        //Write a method CheckNumber that throws this exception if the number is negative.

        public int number;   //number field

        
    }
    public class NegativeNumberException : Exception   //exception inherited
    {
        public NegativeNumberException() {
            Console.WriteLine("Error : The number is negative");
        
        }
    }
}
