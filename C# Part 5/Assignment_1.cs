using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    public class Library
    {
        //Assignment 1.Identify the need for single and multidimensional arrays as
        //properties of a class

        //Question : Create a Library class to store and manage books in a single-dimensional array where

        //each element represents a book title.Also, use a two-dimensional array in a Classroom class

        //where each element represents the seat of a student based on rows and columns.

        public string[] Books;  // "[]" to denote its 1D array
        public Library(string[] books)
        {
            Books = books;
        }

        public void DisplayBooks()
        {
            foreach (var book in Books)
            {
                Console.WriteLine(" " + book);

            }
        }
    }
    public class Classroom
    {
        public int[,] Seats;   //" [,] "to denote its 2D array

        public Classroom(int[,] seats)
        {
            Seats = seats;
        }

        public void DisplaySeats() {
            for(int i = 0; i < Seats.GetLength(0); i++) {
                
                for (int j = 0; j < Seats.GetLength(1); j++)
                {

                    Console.Write($" Seat[{i},{j}]: {Seats[i, j]}  ");

                }
                Console.WriteLine();
            }
        
        }
    }

}
