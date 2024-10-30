using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public class Assignment_12
    {
        //Assignment 12. Attributes
        //Define a custom attribute DeveloperAttribute that takes the name of the developer and the date
        //when the code was last modified.Apply this attribute to a class Calculator and its method Add.
        //Retrieve and display the attribute information at runtime.

        [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
        public class DeveloperAttribute : Attribute
        {
            public string Name;
            public string Date;
            //Class Members
            public DeveloperAttribute(string name, string date)
            {
               Name = name;
               Date = date;
            }
            
        }

        //Calculator Class
        [Developer("Alice", "2024-10-30")]
        public class Calculator
        {   //Calculator method Add
            [Developer("Maxwell", "2022-10-30")]
            public void Add(int number_1, int number_2)
            {   
                Console.WriteLine("The sum is :");
                Console.WriteLine(number_1 + number_2);
            }
        }
    }
}
