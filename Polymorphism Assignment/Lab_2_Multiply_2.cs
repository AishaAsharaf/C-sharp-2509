using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Multiply_2
    {
        //Assignment 2. Method Overloading and its uses
        //Create a C# program to show method overloading by implementing a Multiply method with
        //different parameter types, numbers and order.
        public void Multiply(int a)
        {
            Console.WriteLine($"{a}* {1} = {a * 1},where a is int");
        }
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"{a}* {b} = {a * b},where a and b are int");
        }

        public void Multiply(int a, double b, double c)
        {
            Console.WriteLine($"{a} * {b} * {c} = {a * b * c}, where a is int and b,c are double");
        }
        public void Multiply(double c,int a, double b)
        {
            Console.WriteLine($"{a} * {b} * {c} = {a * b *c}, where a is int and b,c are double,order change");
        }
    }
}
