using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using static C_Assign_Part_8.FileTooLargeException;
using System.Xml.Serialization;


namespace C_Assign_Part_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Question 1

            //string dirPath = "Directory1";
            //string filePath = Path.Combine(dirPath, "testfile.txt");

            //// Create directory if it doesn't exist
            //if (!Directory.Exists(dirPath))
            //{
            //    Directory.CreateDirectory(dirPath);
            //    File.WriteAllText(filePath, "Hello, C#!");
            //}



            //string fileContent = File.ReadAllText(filePath);
            //Console.WriteLine("File Content: " + fileContent);

            //File.Delete(filePath);
            //Directory.Delete(dirPath);

            //Console.WriteLine("File and Directory deleted .");
            //Console.ReadLine();

            //-----------------------------------------------------------------------------------
            //Question 2
            //2.Stream - based I / O
            //Question:
            // Write a program in C# that reads a text file "sample.txt" line by line using StreamReader and
            //writes each line to a new file named "copy.txt" using StreamWriter.
            // Read from source and write to destination using streams

            //string sourceFilePath = "sample.txt";
            //string destinationFilePath = "copy.txt";

            //using (StreamReader reader = new StreamReader(sourceFilePath))                //using auto close file
            //using (StreamWriter writer = new StreamWriter(destinationFilePath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        writer.WriteLine(line);
            //    }

            //}
            //string fileContent = File.ReadAllText(destinationFilePath);
            //Console.WriteLine("File Content: " + fileContent);


            //Console.WriteLine("File copied.");
            //Console.ReadLine();
            //-----------------------------------------------------------------------------------
            //Question 3
            //3.Serialization and Deserialization
            //Question:
            //Define a Person class with properties Name and Age.Write a program to serialize an instance of
            //Person to a JSON file and then deserialize it back to display the object properties on the console.

            //Person person = new Person { Name = "John Doe", Age = 30 };
            //string filePath = "person.json";

            //// Serialize to JSON and save to file
            //string jsonString = JsonSerializer.Serialize(person);
            //File.WriteAllText(filePath, jsonString);
            //Console.WriteLine("Object serialized to JSON file.");

            //// Deserialize from JSON file
            //string readJson = File.ReadAllText(filePath);
            //Person deserializedPerson = JsonSerializer.Deserialize<Person>(readJson);
            //Console.WriteLine($"Name: {deserializedPerson.Name}, Age:{deserializedPerson.Age}");
            //Console.ReadLine();

            //-----------------------------------------------------------------------
            //Question 4
            //4.Exception Handling in File Operations
            //Question:
            //Modify the file copy program in Question 2 to handle possible exceptions like
            //FileNotFoundException, UnauthorizedAccessException, and IOException.Display custom error
            //messages for each exception type.

            //string sourceFilePath = "sample.txt";
            //string destinationFilePath = "copy.txt";
            //try
            //{
            //    using (StreamReader reader = new StreamReader(sourceFilePath))                //using auto close file
            //    using (StreamWriter writer = new StreamWriter(destinationFilePath))
            //    {
            //        string line;
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            writer.WriteLine(line);
            //        }
            //    }
            //    string fileContent = File.ReadAllText(destinationFilePath);
            //    Console.WriteLine("File Content: " + fileContent);
            //}
            //catch (FileNotFoundException)
            //{
            //    Console.WriteLine("File not found");
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("I/O error exception");

            //}
            //catch (UnauthorizedAccessException)
            //{
            //    Console.WriteLine("No access");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine("File copied successfully.");
            //Console.ReadLine();
            //-----------------------------------------------------------------------
            //Question 5
            //5.File Search and Modification in Directory
            //Question:
            //Write a C# program that searches for all .txt files within a directory named "Logs". For each .txt
            //file found:
            // Append the current timestamp at the end of the file.
            // Display the filename and its content after modification.
            //If the "Logs" directory doesn’t exist, create it, add a sample file, and notify the user

            //string dirPath = "Logs";
            //Directory.CreateDirectory(dirPath);
            //string sampleFilePath = Path.Combine(dirPath, "sample.txt");
            //if (!File.Exists(sampleFilePath))
            //{
            //    File.WriteAllText(sampleFilePath, "Sample log entry.");
            //    Console.WriteLine("Sample file created in Logs directory.");
            //}
            //// Search for .txt files and modify them
            //foreach (string filePath in Directory.GetFiles(dirPath, "*.txt"))
            //{
            //    // Append timestamp
            //    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //    File.AppendAllText(filePath, $"\n{timestamp}");
            //    // Display file content after modification
            //    string content = File.ReadAllText(filePath);
            //    Console.WriteLine($"File: {filePath}\nContent:\n{content}");
            //}
            //Console.ReadLine();
            //---------------------------------------------------------
            //6.Binary File Operations with Streams
            //Question:
            //            Create a C# program that:
            // Writes an array of integers { 10, 20, 30, 40, 50}
            //            to a binary file named "data.bin".
            // Reads the integers from "data.bin" and displays them on the console.
            //Use BinaryWriter and BinaryReader classes for this operation.

            //string filePath = "data.bin";
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //// Write integers to binary file
            //using (BinaryWriter writer = new BinaryWriter(File.Open(filePath,
            //FileMode.Create)))
            //{
            //    foreach (int number in numbers)
            //    {
            //        writer.Write(number);
            //    }
            //}
            //Console.WriteLine("Data written to binary file.");
            //// Read integers from binary file
            //using (BinaryReader reader = new BinaryReader(File.Open(filePath,
            //FileMode.Open)))
            //{
            //    Console.WriteLine("Reading data from binary file:");
            //    while (reader.BaseStream.Position != reader.BaseStream.Length)
            //    {
            //        int number = reader.ReadInt32();
            //        Console.WriteLine(number);
            //    }
            //}
            //Console.ReadLine();
            //-----------------------------------------------------------------------------
            //    //7.Custom Exception Handling in File Operations
            //    //Question:
            //    //Create a custom exception class named FileTooLargeException which is thrown when a file
            //    //exceeds 1 MB in size.Write a program that reads a file's size and throws this exception if the file
            //    //size is too large.Otherwise, it should display "File size is acceptable."

            //    //FileTooLargeException example= new FileTooLargeException();


            //    //string dirPath = "MyTestDirectory";
            //    //string filePath = Path.Combine(dirPath, "largefile.txt");

            //    //// Create directory if it doesn't exist
            //    //if (!Directory.Exists(dirPath))
            //    //{
            //    //    Directory.CreateDirectory(dirPath);
            //    //}

            //    //// Create and write to file
            //    //File.WriteAllText(filePath, "foodie foddddddd");
            //    //try
            //    //{
            //    //    FileInfo fileInfo = new FileInfo(filePath);
            //    //    if (fileInfo.Length > 1024 * 1024) // 1 MB
            //    //    {
            //    //        throw new FileTooLargeException();
            //    //    }
            //    //    else
            //    //    {
            //    //        Console.WriteLine("File size is acceptable.");
            //    //    }
            //    //}
            //    //catch (FileTooLargeException ex)
            //    //{
            //    //    Console.WriteLine("Custom Exception: " + ex.Message);
            //    //}
            //    //catch (Exception ex)
            //    //{
            //    //    Console.WriteLine("An error occurred: " + ex.Message);
            //    //}
            //    //Console.ReadLine();
            //    //---------------------------------------------------------------------
            //    //Question 8
            Book_8 book = new Book_8
            {
                Title = "C# Programming",
                Author = "John Doe",
                ISBN = "1234567890"
            };
            string filePath = "book.xml";
            // Serialize to XML
            XmlSerializer serializer = new XmlSerializer(typeof(Book_8));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(fs, book);
            }
            Console.WriteLine("Book object serialized to XML.");
            // Deserialize from XML
            Book_8 deserializedBook;
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                deserializedBook = (Book_8)serializer.Deserialize(fs);
            }
            Console.WriteLine($"Title: {deserializedBook.Title}, Author:{deserializedBook.Author}, ISBN: {deserializedBook.ISBN}");
            Console.ReadLine();
        }

    }
}
