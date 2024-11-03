using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] number = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

            //for (int i = 0; i < number.GetLength(0); i++)
            //{
            //    for (int j = 0; j < number.GetLength(1); j++)
            //    {
            //        Console.Write(" " + number[i, j]);
            //    }
            //    Console.WriteLine();

            //}

            int[] numbers = new int[]{ 13, 10, 11, 7, 8, 45, 59, 36, 29, 18, 15 };
            int temp;
            //7,8,10,11,13,15,18,29,36,45,59
            for (int i = 0; i < numbers.Length-1; i++) {
                for (int j = i+1; j < numbers.Length; j++) {
                    
                        if (numbers[i] > numbers[j])
                        {
                            temp = numbers[i];
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                    }
                }
            }
            foreach (int i in numbers) { 
            Console.WriteLine(i);
            }
            Console.WriteLine("Second Largest number is : " + (numbers[numbers.Length-2]));
            Console.ReadLine();
        }
    }
}
