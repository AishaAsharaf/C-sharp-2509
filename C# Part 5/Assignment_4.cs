using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    
        //Assignment 4. Identify the need for value types and reference types
        //Question: Create a Circle struct to represent a circle as a value type, and a Shape class to
        //represent a reference type.Show how changing values affects each.

        public struct Circle
        {
            public int X;
        private int v;

        public Circle(int v) : this()
        {
            this.v = v;
        }

        public void Point(int x)
            {
                X = x;
               
            }
        }

        public class Shape
        {
            public string Name;
           

            public Shape(string name)
            {
                Name = name;
              
            }
        }

    
}
