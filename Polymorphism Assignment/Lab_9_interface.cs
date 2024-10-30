using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Lab_9_interface
    {

        //Assignment 9. Demonstrating the Need for Multiple Inheritance of Interfaces
        //Create a C# program that demonstrates the concept of multiple inheritance through interfaces.
        //The program will define two interfaces, IMovable and IDrawable, and implement them in a class
        //Car that showcases how a class can inherit from multiple interfaces

        interface IMovable
        {
            void Move();
        }
        interface IDrawable
        {
            void Draw();
        }
        public class Car : IMovable/*, IDrawable*/
        {
            public void Draw() {
                Console.WriteLine("Drawing Interface in child");
            }

            public void Move()
            {
                Console.WriteLine("Moving Interface in child");
            }
        }
    }
}
