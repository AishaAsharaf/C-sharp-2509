using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAssignments
{
    public class Shape4
    {
        //Lab 4. Hierarchical Inheritance
        //In Hierarchical Inheritance, multiple derived classes inherit from a single base class.

        //Problem:

        //Create a base class Shape with a method Draw().
        public virtual void Draw() {
            Console.WriteLine("Drawing a shape");
        }

        
    }
    //Create two derived classes Circle and

    public class Circle4 : Shape4
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");

        }
    }
    //Rectangle, both inheriting from Shape, and override the Draw() method to show specific
    public class Rectangle4 : Shape4
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");

        }
    }
    //behavior.
}
