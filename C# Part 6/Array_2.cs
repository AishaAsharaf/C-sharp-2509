using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class Array_2
    {
        //Assignment 2. Write C# programs to sort an array using bubble sort and insertion sort.
        //Bubble sort
        public static int[] array1 = { 2, 5, 11, 45, 23, 1 };
        public static void Bubble(int[] array1)
        {
            int lenght = array1.Length;
            int temp;
            for (int i = 0; i < lenght - 1; i++)
            {
                for (int j = 0; j < lenght - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        temp = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp;
                    }
                }

            }

            foreach (var i in array1)
            {
                Console.WriteLine(i);
            }
        }

        //Insertion Sort
        public static int[] array2 = { 2, 5, 11, 45, 23, 1 };

        public void Insertion(int[] array2)
        {

            for (int i = 1; i < array2.Length ; i++)
                
            {
                //int key = array2[i];
                int j = i;
                while(j > 0 && array2[j - 1 ] > array2[j])
                {
                    array2 [j] = array2[j-1];
                    j--;
                }
            }

            foreach (int i in array2) { 
            Console.WriteLine(i);
             
            }
        }

    }
}
