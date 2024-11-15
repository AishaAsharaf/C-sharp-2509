using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Array_Sring_Part_6
{
     public class Array_3
    {
        //Assignment 3. Write C# programs to search an array using linear search and binary
        //search.

        public int[] values = {1,2,3,9,10,34,21,4};
        public int target = 10;
        public int count = 0;

        //public void Linear()
        //{
        //    foreach (int i in values)
        //    {
        //        if (i != target)
        //        {
        //            count++;
        //            continue;

        //        }
        //        else if (i == target)
        //        {
        //            Console.WriteLine($"Target value  {target} at  {count}th  Index");
        //            break;

        //        }
        //        else
        //        {
        //            Console.WriteLine("Value not present");
        //        }

        //    }
        //}


        //Binary sort

        public void Binary(int[] example,int target)
        {   
            int lenght = example.Length;
            int left = 0;
            int right = example.Length - 1;

            while (left <= right) {
                int mid = (left + right) / 2;
                if (target > example[mid])
                {
                    left = mid + 1;

                }
                else if (target < example[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    Console.WriteLine("Target found at " + mid);
                    break;
                }
            
            }
            
        }
    }
}
