using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_16
    {
        //Assignment 16. Write a C# program to find the first non-repeating character in a string
        public void NonRepeatChar(string main)
        {
            if (main.Length == 0)
            {
                Console.WriteLine("Null or 0 characters");

            }

            Dictionary<char, int> Pairs = new Dictionary<char, int>();
            foreach (char ch in main)
            {
                if (Pairs.ContainsKey(ch))
                {
                    Pairs[ch]++;
                }
                else
                {
                    Pairs[ch] = 1;
                }

            }

            foreach (var ch in Pairs)
            {
                if (ch.Value == 1)
                {
                    Console.WriteLine($"{ch.Key} : {ch} and frequency is {ch.Value} ");
                    break;
                }
            }
        }
    }
}
