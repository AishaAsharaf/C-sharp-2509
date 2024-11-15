using C_Assignments_SolutionsPart_5;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using static System.Net.Mime.MediaTypeNames;

namespace C_Assignments_SolutionsPart_5
{
    //Assignment 15. Explain the Difference between Exception(Checked Exceptions)
    //and RuntimeException(Unchecked Exceptions)
    //Objective:
    // Understand how to handle runtime exceptions(DivideByZeroException,
    //FileNotFoundException).
    // Learn to create and use custom exceptions for specific scenarios.
    public class FileProcessor
    {


        //Tasks:
        //1. File Reading with Exception Handling:

        //o Create a class FileProcessor with a method ReadFileContent(string filePath).
        //o In this method, attempt to read content from the file located at filePath using
        //StreamReader.
        //o Handle FileNotFoundException by printing a message that says "File not found:
        //<filePath>".

        public void ReadFileContent(string filePath)
        {

            try
            {

                StreamReader reader = new StreamReader(filePath); // Open the file   //given the file path above
                string content = reader.ReadToEnd(); // Read the contents of the file
                Console.WriteLine(content); // Display the content

            }
            catch (FileNotFoundException)  //exception
            {

                Console.WriteLine("File not found");
            }


        }

    }

    //2. Math Operation with Exception Handling:

    //o Create a class MathOperations with a method Divide(int a, int b).
    //o This method should return the result of dividing a by b.
    //o Handle DivideByZeroException and print "Cannot divide by zero".
    public class MathOperations
    {
        public int Divide(int divident, int divisor)
        {
            int result;
            try
            {
                result = divident / divisor;
                Console.WriteLine($"result: {result}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                result = 0;
            }
            return result;
        }
    }

    //3. Custom Exception for Age Validation:

    //o Create a custom exception called InvalidAgeException that inherits from
    //Exception.
    //o Create a class Person with a property Age.
    //o Add a method SetAge(int age) in Person that throws an InvalidAgeException if
    //age is less than 0 or greater than 120.
    //o Print "Invalid age provided" if the exception is thrown.



    public class Person
    {
        public int Age { get; private set; }

        public void SetAge(int age)
        {
            if (age < 0 || age > 120)
            {
                throw new InvalidAgeException();
            }

            Age = age;
        }
    }
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException() 
            {
            Console.WriteLine("Invalid age provided");
            }
        }


        //4. Test Class:
        //o Create a main class ExceptionDemo with the Main method.
        //o In the Main method:
        // Create an instance of FileProcessor and call ReadFileContent() with a file
        //path that does not exist to trigger and handle the FileNotFoundException.
        // Create an instance of MathOperations and call Divide() with b as 0 to
        //trigger and handle the DivideByZeroException.
        //Create an instance of Person, call SetAge() with an invalid age (like -5 or 130) to trigger and
        //handle the InvalidAgeException

        //Available in program.cs itself


   
}