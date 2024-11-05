using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nov_4
{
    public static class Anonymous
    {
        public static void Print(dynamic inputvalue)
        {
            Console.WriteLine(inputvalue.name.ToString());
            Console.WriteLine(inputvalue.age);
            Console.WriteLine(inputvalue.college);
            Console.WriteLine("\n Access a nested value");
            Console.WriteLine(inputvalue.course.grade);
        }
    }

}
