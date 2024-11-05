using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppDynamic
{
    public class Employee
    {
        public string Name;
        public string City;
        public int Age;

        public Employee(string name, string city, int age)
        {
            Name = name;
            City = city;
            Age = age;
        }
        



    }
    public class EmployeeList
    {

        static List<Employee> employees = new List<Employee>();
        public void AddEmp(Employee employee)
        {
            employees.Add(employee);
            Console.WriteLine("Employee added");
        }

        public void DisplayAll()
        {
            foreach(var emp in employees)
            {
                Console.WriteLine($"Name:{emp.Name},City:{emp.City},Age:{emp.Age}");
            }
        }
    }
}
