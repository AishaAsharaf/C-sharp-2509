using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static ConsoleAppAssign2.University.Department;

namespace ConsoleAppAssign2
{
    internal class University
    {
        //Assignment 22: University System
        //Problem Statement:
        //You need to create a University class that holds a list of Department objects.Each Department
        //can have multiple Course objects (nested class). Implement methods to add departments, add
        //courses, and display course information.
        //Tasks:
        //1. Create a University class with :
        //o A list of Department objects.
        //o Methods to add departments and courses, and to display course details.
        //2. Create a nested Department class with properties for Name and a list of courses.
        //3. Create a nested Course class with properties for CourseName, CourseCode, and Credits.
        //4. Demonstrate the functionality in the Main() method.

        public static List<Department> departments = new List<Department>();

        public void AddDepartment(Department department)
        {
            departments.Add(department);
            Console.WriteLine("Department Added");
        }

        public void AddCourses_Main(Department department, string coursename, string id)
        {
            department.AddCourse(new Courses(coursename, id));
            Console.WriteLine($"Course Name: {coursename}, Id : {id}");
            Console.WriteLine("Course added");
        }

        public void DisplayAll()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("The total list is");
            foreach (var department in departments)
            {
                Console.WriteLine($"Name:{department.departmentName}");
                foreach (var course in department.courses)
                {
                    Console.WriteLine($"Course : {course.courseName},Id : {course.courseId}");
                }
            }
        }



        public class Department
        {
            public string departmentName;
            public List<Courses> courses;

            public Department(string name)
            {
                this.departmentName = name;
                this.courses = new List<Courses>();
            }
            public void AddCourse(Courses course)
            {
                courses.Add(course);
            }
            public class Courses
            {
                public string courseName;

                public string courseId;
                public Courses(string name, string id)
                {  
                   this.courseName = name; 
                   this.courseId = id;

                }

            }
        }
    }
}
