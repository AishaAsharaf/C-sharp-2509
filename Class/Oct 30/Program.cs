using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct_30
{
    public class Program
    {
        public class DivideByZero : Exception
        {
            public DivideByZero()
            {
                Console.WriteLine("Division by zero Attempted");
            }
            static void Main(string[] args)
            {
                //try
                //{

                //    int a = 10;
                //    int b = 0;
                //    Console.WriteLine("Result: " + (a / b));

                //}
                //catch (DivideByZeroException)
                //{
                //    Console.WriteLine("Divided by zero");
                //}
                //finally
                //{
                //    Console.WriteLine("Arithmetic operation done !");
                ////}

                //    try
                //    {
                //        int[] words = { 12, 3, 4, 21, 2 };
                //        Console.WriteLine(words[10]);

                //    }
                //    catch (Exception ex)
                //    {
                //        Console.WriteLine("Source : " + ex.Source);
                //        Console.WriteLine("StackTrace : " + ex.StackTrace);
                //        Console.WriteLine("Message : " + ex.Message);
                //    }
                //    finally
                //    {
                //        Console.WriteLine("Completed");
                //    //}

                //    //try
                //    //{
                //    //    string name = null;
                //    //    Console.WriteLine(name[0]);

                //    //}
                //    //catch (NullReferenceException)
                //    //{
                //    //    Console.WriteLine("Null");
                //    //}
                //    //finally
                //    //{
                //    //    Console.WriteLine("Null Check");
                //    //}
                int a = 6;
                int b = 3;
                int c = 0;
                //try
                //{
                //    Console.WriteLine("The answer is");
                //    Console.WriteLine(a / b);
                //}
                //catch
                //{
                //    throw new DivideByZero();
                //}
                //finally
                //{
                //    Console.WriteLine("Division done");
                //}


                //divide by zero
                try
                {
                    Console.WriteLine("The answer is");
                    Console.WriteLine(a / c);
                }
                catch
                {
                    throw new DivideByZero();
                }
                finally
                {
                    Console.WriteLine("Division done");
                }


                try
                {
                    int result = Division(3, 0);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Division done");
                }



                Console.ReadLine();

            }

            public static int Division(int Num, int Deno)
            {
                int result = 0;
                try
                {
                    return Num / Deno;
                }
                catch (Exception ex)
                {
                    throw new DivideByZero();
                }
                finally
                {
                    Console.WriteLine("Division done");
                }
            }

        }

        }
}
