using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_6
    {
        //Assignment 6. Write a C# program to reverse a string.

        public void Reverse(string word)
        {
            if (word == null)
            {
                Console.WriteLine("The word is null");

            } else{
                
                int length = word.Length;
                for(int i = word.Length-1; i >= 0;i--) {
                    Console.Write(word[i]);
       
                }
            }
        }
    }
}
