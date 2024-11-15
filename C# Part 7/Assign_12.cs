using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{
    public class Assign_12
    {
        //Assignment 12. Async and Await Keywords
        //Question:
        //Create a method that downloads data from a sample URL asynchronously.Use HttpClient to
        //fetch the data and print the length of the content.The method should use async and await
        //keywords.

        public static async Task DownloadData(string url)
        {
            using(HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(url);

                Console.WriteLine($"The length of the content in the url is : {content.Length}");
            }
            Console.WriteLine("Completed.......");
        }

    }
}
