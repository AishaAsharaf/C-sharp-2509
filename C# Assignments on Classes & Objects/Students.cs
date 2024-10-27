using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Students
    {
        //Assignment 5: Student Management System
        //Problem Statement: Develop a student management system that stores student details.Each
        //student has a name, ID, and a list of grades.Implement methods to add a grade and calculate the
        //average grade

        public string Name;
        public int ID;
        public List<double> grades = new List<double>();

        public Students(string name, int id)
        {
            Name = name;
            ID = id;
            


        }
        

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
                Console.WriteLine("New grade addded " + grade);
            }
            else
            {
                Console.WriteLine("Not between 0-100");
            }
        }



        public void Average()
        {
            if (grades.Count == 0)
            {
                Console.WriteLine("No grades added");
               
            }

            double sum = 0.0;

            foreach (double grade in grades)
            {
                sum += grade;
            }
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The average is " + (sum / grades.Count));
            

        }

    }
}
