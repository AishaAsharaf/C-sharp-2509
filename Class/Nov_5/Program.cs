using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Async.Call();
            Async.secondMethod();
            Console.ReadLine();


            //CommonMethod();

            //------------------------------------------------
            //Employee[] employee = {

            //    new Employee(){Name="Alex",Age=34,Id=1},

            //    new Employee(){Name="Suresh",Age=20,Id=4},

            //    new Employee(){Name="Ramesh",Age=30,Id=2},

            //    new Employee(){Name="Hiba",Age=42,Id=3},

            //    new Employee(){Name="Noora",Age=39,Id=5}
            //};

            //Employee[] employee1 = employee.Where(x => x.Id == 4).ToArray();   //where is linq,that xexpression is a lambda exp

            //var emp2 = employee.Where(x=>x.Id == 5);  //without creating an array

            //var result = from x in employee1 where x.Id == 3 select x;  //using select and from

            ////To print Values inside employee,stroed in key
            //foreach (var i in employee1) { 

            //  Console.WriteLine(i.Name);

            //   }
            //--------------------------------------------------
            //Console.ReadLine();
        }
        //public class Employee
        //{   
        //    public string Name {  get; set; }
        //    public int Age {  get; set; }
        //    public int Id { get; set; }
        //}

        //public static async void CommonMethod()
        //{
        //    try
        //    {

        //        Task<int> task = Sample_1();    //If it has return type
        //        Sample_2();
        //        int result = await task;
        //        Sample_3();
        //    }
        //    catch (Exception ex)
        //    {

        //        Console.WriteLine(ex.Message);
        //    }


        //}

        //public static async Task<int> Sample_1()     //async method
        //{
        //    int count = 0;
        //    await Task.Run(() =>
        //    {              //await task run
        //        for (int i = 1; i <= 50; i++)
        //        {
        //            Console.WriteLine("Sample_1 : " + i);
        //            count++;
        //            Task.Delay(100);

        //        }


        //    });
        //    return count;   //returning here
        //}

        //public static int /*void*/ Sample_2()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("Sample_2 : " + i);

        //    }
        //    return 2;

        //}

        //public static void Sample_3()
        //{
        //    for (int i = 0; i <= 5; i++)
        //    {
        //        Console.WriteLine("Sample_3 : " + i);

        //    }


        //}

        //Without a return type
        //Simply call in static main
        //public static async void Sample_1()     //async method
        //{

        //    await Task.Run(() =>
        //    {              //await task run
        //        for (int i = 0; i < 10; i++)
        //        {
        //            Console.WriteLine("Sample_1 : " + i);

        //        }


        //    });
        //}
        //public static int /*void*/ Sample_2()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        //Console.WriteLine("Sample_2 : " + i);

        //    }
        //    return 2;

        //}
    }
}
