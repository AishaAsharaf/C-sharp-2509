using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Print

    {

        //Assignment 8: Print Class
        //Problem Statement: Design a Print class that contains overloaded methods to print different
        //types of data: a string, an integer, and an array of integers

        //return string
        public string Return(string name)
        {
            return name;
        }

        //return number
        public int Return(int number)
        {
            return number;
        }

        //return array

        
        public void Return(int[] array)
        {   foreach(var i in array)
            {
                Console.Write(i);
            }
            
            Console.WriteLine();
        
        }
    }
}
