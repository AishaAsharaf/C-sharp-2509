using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Interface_Partial
{
    public partial class Assign_7
    {

        //Assignment 7. Partial Class
        //Create a partial class Person that is defined in two files.One file should have the property Name,
        //and the other file should have the method ShowDetails()

        public void ShowDetails()
        {
            Console.WriteLine($"Name : {Name}, Id : {Id}");
            Console.WriteLine($"School : {School}, College : {College}");
            Console.WriteLine("Company : " + Company);
        }
    }
}
