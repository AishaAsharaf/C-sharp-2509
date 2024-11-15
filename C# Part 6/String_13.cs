using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_13
    {
        //Assignment 13. Write a C# program to remove duplicate characters from a string.

        public void RemoveDuplicate(string word)
        {
            if (word == null) {
                Console.WriteLine("Null value");
            }

            Dictionary<char,bool> duplicates = new Dictionary<char,bool>();

            string result = "";
            foreach (char c in word)
            {
                if (!duplicates.ContainsKey(c))
                {
                    duplicates[c] = true;
                    result += c;

                }
                else
                {
                    duplicates[c] = false;
                }
                
            }

            Console.WriteLine($"The new string is : " + result);


        }
    }
}
