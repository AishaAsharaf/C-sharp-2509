using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class MathOperations
    {
        //Assignment 13: Initializing Constants with Static Block
        //Problem Statement: Create a class MathOperations that initializes a static field representing the
        //value of Pi.Write a static constructor to assign this value.

        public static double Pi;
        static MathOperations() {
            Pi = 3.14;
        }
    }
}
