using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class Program
    {
        static void Main(string[] args)
        {//Assigment 1
         //Array-1

            //int[,] matrix_1 = { { 1, 1 },
            //              { 2, 2 } };
            //int[,] matrix_2 = { { 1, 1 },
            //                { 2, 2 } };

            //Array_1 array = new Array_1();
            //int[,] answer = array.Multipy(matrix_1, matrix_2);
            //Console.WriteLine("The result after multiplying the matrix is;");
            //for (int i = 0; i < answer.GetLength(0); i++)
            //{
            //    for (int j = 0; j < answer.GetLength(1); j++)
            //    {
            //        Console.Write(answer[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Array_1 array1 = new Array_1();
            //int[,] answer1 = array1.AddMatrix(matrix_1, matrix_2);
            //Console.WriteLine("The result after adding the matrix is;");
            //for (int i = 0; i < answer1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < answer1.GetLength(1); j++)
            //    {
            //        Console.Write(answer1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Array_1 array2 = new Array_1();
            //int[,] answer2 = array2.TransposeMatrix(matrix_1);
            //Console.WriteLine("The result after transposing the matrix is;");

            //for (int i = 0; i < answer2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < answer2.GetLength(1); j++)
            //    {
            //        Console.Write(answer2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}


            //Console.ReadLine();

            //-----------------------------------------------------------------------
            //Array - 2

            //Bubble sort

            //Array_2.Bubble(Array_2.array1);

            ////Insertion sort
            //Array_2.Bubble(Array_2.array2);
            //Console.ReadLine();


            //-----------------------------------------------------------------------
            //Array - 3

            //Linear Search

            //Array_3 array_3 = new Array_3();
            //array_3.Linear();

            //Binary search
            //int[] numbers = { 1, 2, 3, 9, 10, 34, 21, 4 };

            //array_3.Binary(numbers, 10);
            //Console.ReadLine();

            //-----------------------------------------------------------------------
            //Array - 4

            //Array_4 array_4 = new Array_4();
            //int[] example4 = {1, 2, 3, 4, 5, 6, 7, 8, 9};
            //int[] example5 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,9,4,9,0,9};
            //Median
            //array_4.Median(example4);

            //Highest and secondHighest
            //array_4.Highest(example4);

            //Mode and Duplicates
            //array_4.Mode(example5);


            //Console.ReadLine();

            //-----------------------------------------------------------------------
            //String -5
            //String_5 example = new String_5();
            //string words = "agsvgvswdwbjiswu %";
            //example.Count(words);

            //Console.ReadLine();
            //---------------------------------------------------------------------
            //String -6
            //String_6 example = new String_6();
            //string name = "aisha";
            //Console.WriteLine("The reverse of this string is :");
            //example.Reverse(name);

            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String - 7

            //String_7 example = new String_7();
            //string main = "sccobydoooo";
            //string sub = "oo";
            //example.FindSubString(main, sub);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  8
            //String_8 example = new String_8();
            //string name = "apple";

            //example.Lower(name);
            //example.Upper(name);
            //example.Title(name);

            //Console.ReadLine();
            //---------------------------------------------------------------------
            //String -  9

            //String_9 example = new String_9();
            //string value = "    sdis     ";
            //example.Space(value);

            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  10

            //String_10 example = new String_10();
            //string main = "Once upon a time once oneDollar";
            //string sub = "once";
            //string replace = "hello";
            //example.Replace(main, sub, replace);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  11

            //String_11 example = new String_11();
            //string sentence = "Once upon a time in the kingdom of Spade";
            //example.LongesTWord(sentence);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  12
            //String_12 example = new String_12();
            //string sentence = "Once upon a time in the kingdom of Spade";
            //example.CountWord(sentence);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  13

            //String_13 example = new String_13();
            //string duplicate = "ddrrffhhdx";
            //example.RemoveDuplicate(duplicate);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  14
            //String_14 example = new String_14();
            //string one = "asdfg";
            //string two = "gdfsa";
            //example.CheckAnagram(one, two);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  15
            //String_15 example = new String_15();
            //string name = "aaaderrggwqu";
            //example.FrequencyOfChar(name);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  16

            //String_16 example = new String_16();
            //string name = "aaaderrggwqu";
            //example.NonRepeatChar(name);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  17

            //String_17 words = new String_17();
            //string sentence = "Once upon a time in clover kingdom";
            //words.ReverseWords(sentence);
            //Console.ReadLine();

            //---------------------------------------------------------------------
            //String -  18

            String_18 words = new String_18();
            string sentence = "988728";
            string sentence1 = "988728dsjd";
            words.OnlyDigits(sentence);
            words.OnlyDigits(sentence1);
            Console.ReadLine();

        }

    }
}
