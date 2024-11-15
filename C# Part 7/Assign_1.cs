using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{
    public class Assign_1
    {
        //Assignment 1. Anonymous Types
        //Question:
        //Create an anonymous type to represent a book with properties for Title, Author, and Price.
        //Display the details of the book.

        public void Display(dynamic input)
        {
            Console.WriteLine($"Title : {input.title}, Author : {input.author} ,Price : {input.price}");
        }
    }
}
