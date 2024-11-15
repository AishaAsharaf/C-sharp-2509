using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{
    public class Assign_15
    {
        //Assignment 15. Parallel Programming with Task Parallel Library(TPL)
        //Question:
        //Create a program that runs multiple tasks in parallel to simulate multiple operations, such as
        //calculating the factorial of different numbers.Print the result of each task when completed.

        public static long Factorial(int number)
        {
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public static async Task RunFactorialTasksAsync(int[] numbers)
        {
            
            List<Task> tasks = new List<Task>();

            foreach (var number in numbers)
            {
                
                var task = Task.Run(() =>
                {
                    long result = Factorial(number);
                    Console.WriteLine($"Factorial of {number} is {result}");
                });

                tasks.Add(task); 
            }

            
            await Task.WhenAll(tasks);

            Console.WriteLine("All tasks completed.");
        }

    }
}
