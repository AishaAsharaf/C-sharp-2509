using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Oct_29.Program;

namespace Oct_29
{
    public class Program
    {


        //public class Student
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }


        //}

        [Obsolete("Old method",false)]   //Obsolute
        public static void ExampleOut(out int a, out int b)  // this has to be static
        {
            a = 1; 
            b = 2;
            a = b+ 10; 
            b = 3 + a;
        }

        [Conditional("DEBUG")]
        public static void ConditionalnewExampleOut(int a, int b)  // this has to be static
        {
            a = 1;
            b = 2;
            a = b + 10;
            b = 3 + a;
        }


        public static void newExampleOut(out int a, out int b)  // this has to be static
        {
            a = 1;
            b = 2;
            a = b + 10;
            b = 3 + a;
        }
        public static void Main(string[] args)
        {
            int x, y;
            ExampleOut(out x, out y);
            newExampleOut(out x, out y);
            Console.WriteLine("a = " + x);
            Console.WriteLine("b = " + y);

            //Ref keyword
            Ref_keyword example = new Ref_keyword();
            int a = 999;
            Console.WriteLine(a);
            example.Example(ref a);


            //Student student = new Student();
            //student.Name = "Farah";
            //student.Id = 12;
            //Console.WriteLine($"{student.Name} before calling function");  //12, Farah
            //Console.WriteLine($"{student.Id} before calling function");
            //Test(/*ref*/student);
            //Console.WriteLine($"{student.Name} after calling function");  //1,Alex
            //Console.WriteLine($"{student.Id} after calling function");

            //Indexer index = new Indexer();
            //index[0] = 1;
            //index[1] = 2;
            //index[2] = 3;

            //Console.WriteLine(index[0]);
            //Console.WriteLine(index[1]);
            //Console.WriteLine(index[2]);

            Console.ReadLine();


        }
        //public static void Test(/*ref*/Student student)
        //{
        //    student = new Student();

        //    student.Id = 1;
        //    student.Name = "Alex";
        //    Console.WriteLine($"{student.Name} after calling function");  //1,Alex
        //    Console.WriteLine($"{student.Id} after calling function");
        //}

        //public class Indexer
        //{
        //    public int[] result = new int[10];

        //    public int this[int index]
        //    {
        //        get
        //        {
        //            return result[index];
        //        }
        //        set
        //        {
        //            result[index] = value;
        //        }
        //    }
        //}
    }
}
