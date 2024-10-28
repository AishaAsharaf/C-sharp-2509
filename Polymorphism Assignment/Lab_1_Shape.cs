using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape_1
    {
        //Assignment 1: To demonstrate Polymorphism and its Advantages

        //Create a C# program demonstrating polymorphism by using a base class Shape
        //A method Draw()
        public virtual void Draw_1()
        {
            Console.WriteLine("Drawing a shape");
        }
    }


    //And derived classes Circle and Rectangle.Each derived class should implement a method Draw().
    public class Circle_1: Shape_1
    {
        public override void Draw_1()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }

    public class Rectangle_1 : Shape_1
    {
        public override void Draw_1()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }
    //Show how polymorphism helps in calling the correct method based on the object type.
}
