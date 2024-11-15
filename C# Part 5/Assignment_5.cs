using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    public class RefExample
    {
        //Assignment 5. Identify the need for pass by reference using ref keyword
        //Question: Create a method IncreaseScore that takes a ref integer parameter representing a
        //player’s score and increases it by 10. 
        public void IncreaseScore(ref int score)
        {
            score += 10;
            Console.WriteLine("The score is " + score);
        }
    }
}
