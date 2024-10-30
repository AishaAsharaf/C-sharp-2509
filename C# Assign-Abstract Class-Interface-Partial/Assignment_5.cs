using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{  
    //static class
    public static class MathOperations
    {
        //Assignment 5. Static Class
        //Create a static class MathOperations with a static method Add() and Multiply(). Demonstrate
        //calling these methods without creating an instance of the class.

        //static method add
        public static int Add(int a, int b)
        {
            return a+b;
        }

        //static method multiply
        public static int Multipy(int a, int b)
        {
            return a * b;
        }
    }
}
