using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1 will be");
            string num1 = Console.ReadLine();
            int numOne = Convert.ToInt32(num1);

            Console.WriteLine("num2 will be");
            string num2 = Console.ReadLine();
            int numTwo = Convert.ToInt32(num2);

            Console.WriteLine("num3 will be");
            string num3 = Console.ReadLine();
            int numThree = Convert.ToInt32(num3);


            if ((numOne > numTwo) && (numThree < numTwo))
            {
                Console.WriteLine(" 2nd Largest num is " + numTwo);


            }
            else if ((numTwo > numOne) && (numOne > numThree))
            {
                Console.WriteLine("2nd Largest num is " + numOne);


            }
            else
            {
                Console.WriteLine("2nd Largest num is " + numThree);
            }

            Console.ReadLine();
        }
        
        
            
        
    }
}
