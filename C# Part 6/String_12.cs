using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_12
    {
        //Assignment 12. Write a C# program to count words in a sentence.

        public void CountWord(string sentence)
        {
            string[] seperated = sentence.Split(' ');  //single quotes

            int count = 0;
            if(sentence == null)
            {
                Console.WriteLine("Null");
            }

            for (int i = 0; i < seperated.Length ; i++)
            {
                count++;
            }
            Console.WriteLine("The number of words in the sentence is : " + count);
        }
    }
}
