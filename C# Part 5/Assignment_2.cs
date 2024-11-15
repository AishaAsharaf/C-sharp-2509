using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignments_SolutionsPart_5
{
    //Movie class
    public class Movie
    {
        //Assignment 2. Identify the need for an array of objects
        //Question: Define a Movie class with properties like Title and Year.Create a MovieLibrary class
        //that stores an array of Movie objects and displays each movie’s information.


        //Property Movie and Year
        public string Title { get; set; }
        public string Year { get; set; }

        public Movie(string title,string year)
        {
            Title = title;
            Year = year;
        }

    }

    public class MovieLibrary 
    {

        // Array to store Movie 
        private Movie[] movies;
        private int count; // To keep track of the number of movies added

        // Constructor to initialize the MovieLibrary with a specified capacity
        public MovieLibrary(int capacity)
        {
            movies = new Movie[capacity]; // Create an array of Movie objects with the given capacity
            count = 0; // Start with no movies in the library
        }
        public void AddMovie(Movie movie)
        {
            // Check if there's room in the array for a new movie
            if (count < movies.Length)
            {
                movies[count] = movie; // Add the movie to the next available spot
                count++; // Increment the count of movies
            }
            else
            {
                Console.WriteLine("Movie library is full. Cannot add more movies.");
            }
        }

        // Method to display all movies in the library
        public void DisplayMovies()
        {
            Console.WriteLine("Movies in the Library:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Title: {movies[i].Title}, Year: {movies[i].Year}"); // Print each movie's title and year
            }
        }

    }
}
