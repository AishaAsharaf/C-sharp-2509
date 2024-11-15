using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    public class Age_Exception
    {
        //Assignment 11. Difference between throw and throws

        //Question: Explain the purpose of the throw keyword in C#. Create a method ValidateAge that
        //throws an exception if the age is below 18, and handle it in the calling method.

        public int Age;
       
    }

    public class Below18 : Exception  //inherited xeception class
    {
        public Below18()
        {
            Console.WriteLine("Error  : Age Below 18");

        }
    }
}
