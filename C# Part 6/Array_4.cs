using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class Array_4
    {
        //Assignment 4. Array Calculations: write C# programs for finding median, mode value,
        //highest, second highest and duplicate elements in an array.

        //Median
        public void Median(int[] numbers)
        {
            double result = 0;
            int length = numbers.Length;
            if (length % 2 != 0)
            {
                result = numbers[((length + 1) / 2) - 1];
                Console.WriteLine("Median : " + result);
            }
            else
            {
                double one_value = length / 2;
                double two_value = (length / 2) + 1;
                result = (one_value + two_value) / 2;
                Console.WriteLine("Median : " + result);
            }
        }

        //Highest and second Highest
        public void Highest(int[] numbers)
        {
            int highest = 0;
            int secondHighest = 0;
            foreach (int number in numbers)
            {

                if (number > highest)
                {
                    secondHighest = highest;
                    highest = number;

                }
                else if (number > secondHighest && secondHighest < highest)
                {
                    {
                        secondHighest = number;
                    }

                }
                

            }
            Console.WriteLine("Highest : " + highest);
            Console.WriteLine("Second Highest : " + secondHighest);
        }

        //Mode and Duplicates
        public void Mode(int[] numbers)
        {
            Dictionary<int,int> frequency = new Dictionary<int,int>();

            foreach (int number in numbers) {
                if (frequency.ContainsKey(number))
                {
                    frequency[number]++;
                }
                else
                {
                    frequency[number] = 1;
                }
            
            }

            int mode = 0;
            int Count = 0;
            foreach (var item in frequency) { 
               if(item.Value > Count)
                {
                    mode = item.Key;
                    Count = item.Value;
                }
            
            }
            //Duplicate
            foreach (var item in frequency)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine("Duplicates are : " + item.Key);
               
                }

            }
            //Mode
            Console.WriteLine("Mode is : " + mode + " Has a count of " + Count);
        }
    }
}
