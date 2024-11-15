using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Sring_Part_6
{
    public class Array_1
    {
        // Assignment 1. Write C# programs on Matrix addition, Matrix Multiplication and Matrix
        //Transpose.


        public int[,] Multipy(int[,] matrixOne, int[,]matrixTwo) {

            int r1 = matrixOne.GetLength(0);
            int c1 = matrixTwo.GetLength(1);
            int r2 = matrixOne.GetLength(0);
            int c2 = matrixTwo.GetLength(1);

            int[,] arrayMultiply = new int[r1, c2];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        arrayMultiply[i, j] += matrixOne[i, k] * matrixTwo[k, j];
                    }
                }
            }
            return arrayMultiply;

        }


        public int[,] AddMatrix(int[,] matrixOne, int[,] matrixTwo)
        {

            int r1 = matrixOne.GetLength(0);
            int c1 = matrixTwo.GetLength(1);
            int r2 = matrixOne.GetLength(0);
            int c2 = matrixTwo.GetLength(1);

            int[,] arrayAdded = new int[r1, c2];


            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                        arrayAdded[i, j] = matrixOne[i, j] + matrixTwo[i, j];
                 
                }
            }
            return arrayAdded;

        }

        public int[,] TransposeMatrix(int[,] matrixOne)
        {

            int r1 = matrixOne.GetLength(0);
            int c1 = matrixOne.GetLength(1);
           

            int[,] arrayTranspose = new int[c1, r1];


            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    arrayTranspose[i, j] = matrixOne[j, i];

                }
            }
            return arrayTranspose;

        }


    }
}
