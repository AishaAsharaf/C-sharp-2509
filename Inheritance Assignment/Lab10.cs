using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Lab10
    {
        //Lab 10. Interface Inheritance
        //Demonstrate that one interface can inherit from another.

        //Problem:

        //Create an interface IDriveable with a method Drive().
        interface IDriveable
        {
            void Drive();
        }

        //Create another interface IRaceable that
        //inherits from IDriveable and adds a method Race().

        interface IRaceable : IDriveable
        {
            void Race();
        }

        public class Test10: IRaceable
        {
            public void Drive()
            {
                Console.WriteLine("I Drive");
            }
            public void Race() { 
                 Console.WriteLine("A raceable Tesla");
            }
        }
    }
}
