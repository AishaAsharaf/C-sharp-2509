using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_8
    {
        //Assignment 8. Write a C# program to convert string to uppercase, lowercase, and title case.

        public void Upper(string upper)
        {
            Console.WriteLine(upper.ToUpper());
        }

        public void Lower(string lower)
        {
            Console.WriteLine(lower.ToLower());
        }

        public void Title(string title)
        {
            foreach(var ch in title)
            {
                if(title.IndexOf(ch) == 0)
                {
                    Console.Write(char.ToUpper(ch));
                }
                else
                {
                    Console.Write(ch);
                }
            }
        }
    }
}
