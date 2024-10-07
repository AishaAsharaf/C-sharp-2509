using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //to print 1-3-5-7-9-11
            //for(int i = 0; i <= 11; i++)
            //{
            //    if(i %2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //Console.WriteLine("The number of rows?");
            //int Rows = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= Rows; i++)
            //{
            //    for(int j=1; j<= i; j++)
            //    {
            //        Console.Write("*"); //To write in same line
            //    }
            //    Console.WriteLine();
            //}

            //While Loop
            //int i = 0;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //Do while

            //Sum of first 5 natural numbers
            //int i =0;
            //int sum = 0;
            //while (i <= 5)
            //{
            //    sum = sum+ i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //1
            //23
            //456
            //78910

            int k = 1;
            

            for (int i = 1; i <= 4; i++)
            {
                for (int m = 5; m > i; m--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {

                    Console.Write($" {k++}");


                }
                
                
                Console.WriteLine(" ");
            }
            Console.ReadLine();

            //-----

            //10,30,50-200


            //for(int ans = 1; ans<=20; ans++)
            //{
            //    if(ans%2 == 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(ans * 10);
            //    }
            //}
            //Console.ReadLine();

            //int [] num = {1,2,3,4,5};

            //string[] days = { "mon", "sun", "sat", "fri"};

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}


            //Console.ReadLine();
        }
    }
}
