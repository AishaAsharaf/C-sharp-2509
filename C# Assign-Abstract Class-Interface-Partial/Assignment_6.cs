using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public class Assignment_6
    {
        //Assignment 6. Extension Methods
        //Create an extension method IsEven() for the int type that returns true if the number is even and
        //false if it is odd.
        public int number_1;
        public int Number(int a)
        {
            Console.WriteLine("The number is " + a);
            return number_1 = a;
            
        }
        
    }
    //static class
    static class Child
    {   // static method and variable
        public static int number_2;
        public static bool IsEven(this Assignment_6 number) //binding
        {
            //check condition
            if (number.number_1 % 2 == 0) {
                Console.WriteLine("true, it is even");
                return true;

            }
            else {
                Console.WriteLine("false, it is odd");
                return false;
            }
            
        }




    }
}
