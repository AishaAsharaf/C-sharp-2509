using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_17
    {
        //Assignment 17. Write a C# program to reverse words in a sentence.

        public void ReverseWords(string sentence)
        {
            string[] breakSentence = sentence.Split(' ');

            for(int i = breakSentence.Length-1; i >= 0; i--)
            {
                Console.Write(" " + breakSentence[i]);
            }
        }
    }
}
