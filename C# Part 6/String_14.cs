using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_14
    {
        //Assignment 14. Write a C# program to check if two strings are anagrams.

        public void CheckAnagram(string first, string second)
        {
            char[] one = first.ToCharArray();
            char[] two = second.ToCharArray();
            Array.Sort(one);
            Array.Sort(two);

            if (one.SequenceEqual(two)) {  //== check - referenc ,to check order and lenght we use Sequence Equal
                Console.WriteLine("Its a anagram");

            }
            else
            {
                Console.WriteLine("Not an anagram");
            }
        }
    }
}
