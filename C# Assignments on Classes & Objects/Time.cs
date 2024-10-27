using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Time
    {
        public int Hours;
        public int Minutes;
        public int Seconds;

        public void SetTime(int hours,int minutes)
        {
            if ((0 <= hours && hours <= 24) && (0 <= minutes && minutes <= 60)) { 
               this.Hours = hours;
               this.Minutes = minutes;
                this.Seconds = 0;

            }
            else
            {
                Console.WriteLine("Invalid input time");
            }
        }

        public void SetTime(int seconds)
        {
            if (seconds >= 0 && seconds < 86400) {
                this.Hours = seconds / 3600;
                this.Minutes = (seconds % 3600) / 60;
                this.Seconds = seconds % 60;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        public void DisplayTime()
        {
            Console.WriteLine($"Time is : {Hours}:{Minutes}:{Seconds}");
        }
    }
}
