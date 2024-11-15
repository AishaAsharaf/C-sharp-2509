using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_5
    {
        //    String Manipulations
        //    Assignment 5. Write a C# programs to count vowels, consonants and special characters. 
        
        public void Count(string words)
        {
            
            int vowels = 0;
            int consonents = 0;
            int specialChara = 0;

            foreach (char word in words)
            {
                if(IsVowel(word))
                {
                    vowels++;
                }
                else if (IsConsonent(word))
                {
                    consonents++;
                }
                else
                {
                    specialChara++;
                }

            }
            bool IsVowel(char ch) { 
                ch = char.ToLower(ch);
       
                return "aeiou".IndexOf(ch) >= 0;
            
            }

            bool IsConsonent(char ch)
            {
                ch = char.ToLower(ch);
                return ch >= 'a' && ch <= 'z' && !IsVowel(ch);

            }

            Console.WriteLine("Vowels : " + vowels);
            Console.WriteLine("Consonents : " + consonents);
            Console.WriteLine("Special Chara : " + specialChara);
        }

    }
}
