using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_5
{
    public class Async
    {
        public static async void firstMethod()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("First method");
                    Task.Delay(100).Wait();
                }
            });
        }
        public static void secondMethod()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Second method");
                Task.Delay(100).Wait();
            }
        }
        public static async Task<int> newMethod()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("New method");
                    //Task.Delay(100).Wait();
                }
            });
            return count;
        }
        public static async void Call()
        {
            firstMethod();                  
            //var result = newMethod();
            //await result;

            Task<int> task = newMethod();
            int result = await task;

            //secondMethod();
        }
    }
}
