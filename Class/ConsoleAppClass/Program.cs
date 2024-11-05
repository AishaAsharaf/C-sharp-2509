using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClass
{
    internal class Program
    {
        static void Main(string[] args) //function
        {
            //Employee emp1 = new Employee();
            //emp1.Name = "Aisha";

            ////Object creation(emp1,emp2)
            ////Both have diff memory locations

            //Console.WriteLine(emp1.Name);

            //Console.ReadLine();

            //int multiply;
            //int add;
            //Employee emp1 = new Employee();
            //int Add = emp1.add();
            //int Multiply = emp1.multiply();
            //Console.WriteLine("Adding is " + Add);
            //Console.WriteLine("Multiplying is "+ Multiply);
            //Console.ReadLine();

            Employee employee1 = new Employee("Suresh", 67, "delhi",4,"Full-Time",49,30);
            decimal FullTimeSalary = employee1.SalaryFullTime();
            Console.WriteLine("Full time salary " + FullTimeSalary);

            Employee employee2 = new Employee("Sam", 45, "noida", 6, "Part-Time", 15, 60);
            decimal PartTimeSalary = employee1.SalaryPartTime();
            Console.WriteLine("Part time salary "+ PartTimeSalary);

            Console.WriteLine(employee1.LeaveTaken());

            Console.WriteLine(employee2.LeaveTaken());

            Console.WriteLine(employee1.OfficeExp());



            



            //Employee employee2 = new Employee("Suresh",89);
            //Console.WriteLine(employee2.Number);
            Console.ReadLine();




        }
    }
}
