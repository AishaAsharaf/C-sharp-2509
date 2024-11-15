using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_9
    {
        //Assignment 9. Write a C# program to remove whitespace from a string.

        public void Space(string word)
        {
            if (word == null) {
                Console.WriteLine("Null value");

            }
            
            else
            {
                string neword = word.Trim();
                Console.WriteLine(neword);
            }
        }
    }
}
