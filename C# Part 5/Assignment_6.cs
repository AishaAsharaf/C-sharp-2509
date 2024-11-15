using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    public class OutParameter
    {
        //Assignment 6. Identify the need for out parameters
        //Question: Create a method Divide that takes two integers, calculates their quotient and
        //remainder, and returns both values using the out keyword.
        


        //out can also return multiple values
        public void Divide(int divisor, int dividend, out int remainder, out int quotient)
        {
            if (divisor == 0)
            {
                quotient = 0;
                remainder = 0;
            }
            else
            {
                quotient = dividend/divisor;
                remainder = dividend%divisor;
            }
        }
    }
}
