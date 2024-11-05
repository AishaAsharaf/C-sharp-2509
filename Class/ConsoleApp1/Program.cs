using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int Number = Convert.ToInt32(Console.ReadLine());

            switch (Number)
            {
                case 0:
                    Console.WriteLine("Case 0");
                    break;
                case 1:
                    Console.WriteLine("Case 1");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
