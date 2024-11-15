using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_11
    {
        //Assignment 11. Write a C# program to find the longest word in a sentence
        public void LongesTWord(string sentence)
        {
            string[] seperated = sentence.Split(' ');  //single quotes

            string largest = "" ;

            for(int i = 0; i < seperated.Length - 2 ; i++)
            {
                if (seperated[i].Length > seperated[i + 1].Length)
                {
                    largest = seperated[i];
                }
                else
                {
                    largest = seperated[i+1];
                }
            }
            Console.WriteLine("Largest word is: " +  largest);
        }
    }
}
