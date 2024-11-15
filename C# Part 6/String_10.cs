using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class String_10
    {
        //Assignment 10. Write a C# program to replace all occurrences of a substring.

        public void Replace(string mainString,string subString, string replace)
        {   
            string main = mainString.ToLower();

            if(main == null)
            {
                Console.WriteLine("Null string");
            }

            int index = 0;
            while (index <= main.Length - subString.Length) { 
                  if(main.Substring(index, subString.Length)== subString)
                  {
                    main = main.Replace(subString, replace);
                    index =+ subString.Length;
                    index++;

                  }
                  else
                  {
                    index++;
                  }
            
            
            }
            Console.WriteLine("The final string is ::  " + main);

        }
    }
}
