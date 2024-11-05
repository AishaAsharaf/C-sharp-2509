using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppClass
{
    public class Employee
    {
        //private string name;
        //public string Name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}

        //int a = 2;
        //const int b = 0;
        //static int c = 2;

        //public int multiply()
        //{
        //    a = a * 3;

        //    return a;
        //}

        //private int add()
        //{

        //    c = c + 1;
        //    return c;
        //}

        public string Name;
        public int Age;
        public string Location;
        public int Leave;
        const int HourSalary = 30;
        public string Time;
        public int Hours;
        public int OfficeLocationExpense;


        public decimal SalaryFullTime()
        {   
            if (Time == "Full-Time")
            {
                return HourSalary * Hours;

            }
            else
            {
                return 0;
            }
           
           
        }

        public decimal SalaryPartTime() {

            if (Time == "Part-Time")
            {
                return HourSalary * Hours;

            }
            else
            {
                return 0;
            }


        }

        public int LeaveTaken()
        {
            if (Time == "Full-Time")
            {
                return Leave;

            }
            else
            {
                return 0;
            }
        }

        public decimal OfficeExp()
        {
            return OfficeLocationExpense;
        }

        public Employee(string name, int age, string location, int leave, string time, int hours, int officeLocationExpense) 
        {
            Name = name;
            Age = age;
            Location = location;
            Leave = leave;
           
            Time = time;
            Hours = hours;
            OfficeLocationExpense = officeLocationExpense;
        }
    
        //public Employee(string Name1, int HourSalary1, string Time1, int Hours1)
        //{
        //    this.Name = Name1;
        //    this.HourSalary = HourSalary1;
        //    this.Time = Time1;
        //    this.Hours = Hours1;
           
        //}

        //public Employee(string Name2, int Leave2 , string Time2)
        //{
        //    this.Name = Name2;
        //    this.Leave = Leave2;
        //    this.Time = Time2;
        //    Console.WriteLine("The leave taken is " + Leave);

        //}

        //public Employee(string Location)
        //{
        //    Console.WriteLine("The expense of this location is" + OfficeLocationExpense);
        //}
    }
}
