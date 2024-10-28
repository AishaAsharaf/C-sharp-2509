using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{   
    //abstract class
    public abstract class Lab_8_Shape
    {
        //Assignment 8. Achieving Runtime Polymorphism with Abstract Classes and
        //Interfaces in C#
        //Create a C# program that demonstrates how runtime polymorphism is achieved using abstract
        //classes and interfaces.Define an abstract class Shape and an interface IShape, implementing
        //these in derived classes to showcase polymorphism
        public abstract void Shape();
        
       
    }

    interface IShape
    {
        void Shape();
    }

    public class Derive_1 : IShape { 
          public void Shape()
        {
            Console.WriteLine("Shape in Interface");
        }
    
    }

    public class Derive_2 : Lab_8_Shape {

        public override void Shape()
        {
            Console.WriteLine("Abstract in derived");
        }



    }
}
