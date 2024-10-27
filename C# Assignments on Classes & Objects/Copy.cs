using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleAppAssign2
{
    public class Copy
    {
        //Assignment15: Implementing and Understanding Copy Constructor
        //Problem Statement:
        //Write a C# program that implements a copy constructor. The program should:
        //1. Create a class with several fields.
        //2. Provide a constructor to initialize those fields.
        //3. Provide a copy constructor that allows the creation of a new object from an existing
        //object.
        //4. Demonstrate how the copy constructor works by comparing objects created using it with
        //objects created via direct assignment(which just copies references).

        public string Student_Name;
        public string Student_ID;
        public int Student_Grade;
        public string Section;
        public int Age;

        public Copy(string name, string id, int grade, string section, int age)
        {
            Student_Name = name;
            Student_ID = id;
            Student_Grade = grade;
            Section = section;
            Age = age;
        }

        public Copy(Copy copy) { 
            this.Student_Name = copy.Student_Name;
            this.Student_ID = copy.Student_ID;
            this .Student_Grade = copy.Student_Grade;
            this.Section = copy.Section;
            this.Age = copy.Age;
        }

        public void DisplayAll()
        {
            Console.WriteLine($"Name : {Student_Name}, ID : {Student_ID},Grade: {Student_Grade},Section : {Section},Age: {Age}");
        }
        
        


    }
}
