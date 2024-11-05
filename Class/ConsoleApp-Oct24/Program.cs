using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp_Oct24.Class_A;

namespace ConsoleApp_Oct24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Abstract_B example = new Abstract_B();
            example.Print_Second();
            example.Print();
            Console.ReadLine();

            Console.WriteLine("------");


            //C obj = new C();

            //// Call the methods
            //obj.Print1(); // Output: a
            //obj.Print2(); // Output: b

            //Extension example = new Extension();

            //example.CarCompany("Toyota"); //From extension class(1st Class)

            //example.CarOwner("Sam");// From Owner class(2nd Class)

            //Console.ReadLine();


        }
    }
}
