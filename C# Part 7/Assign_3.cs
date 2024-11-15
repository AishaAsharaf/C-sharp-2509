using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{
    public class Assign_3
    {
        //Assignment 3. Delegates
        //Question:
        //Create a simple calculator using delegates. Define a delegate OperationDelegate that can
        //represent different arithmetic operations (addition, subtraction, multiplication, division).
        //Implement methods for each operation and allow the user to select an operation to perform on
        //two input numbers.

        //Requirements:
        //1. Define a delegate called OperationDelegate that takes two double parameters and returns
        //a double result.
        //2. Implement methods for addition, subtraction, multiplication, and division.
        //3. Use the delegate to call the selected method.
        //4. Allow the user to input two numbers and choose an operation.
        //5. Display the result of the operation

        public double Add(double a, double b)
        {
            Console.WriteLine("Sum : " + (a+b));
            return a + b;
        }
        public double Sub(double a, double b)
        {
            Console.WriteLine("Subtract : " + (a-b));
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            Console.WriteLine("Multiply : " + (a * b));
            return a * b;
        }
        public double Division(double a, double b)
        {
            if (b == 0) {
                Console.WriteLine("Divide by zero");
                return 0; 
            }
            Console.WriteLine("Divide : " + (a / b));
            return a / b;
        }
    }
}
