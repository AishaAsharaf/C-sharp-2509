using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{
    public class Assign_11
    {
        //Assignment 11. Introduction to Asynchronous Programming
        //Question:
        //Write a C# program that simulates a long-running operation using Task.Delay() and runs
        //asynchronously.Display a message before and after the operation completes. 

        public static async void AsyncMethod()
        {
            Console.WriteLine("Start of operation");
            await Task.Run(async() => {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine(i);
                    await Task.Delay(1000);
                }
            });
            Console.WriteLine("End of operation");
        }
    }
}
