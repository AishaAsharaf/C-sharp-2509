using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInheritance
{
    internal class OperatorLoad
    {

        public int Number1, Number2;
        public int temp;
        public OperatorLoad(int num_one, int num_two)
        {
            Number1 = num_one;
            Number2 = num_two;
            temp = Number1 + Number2;
        }
        static OperatorLoad()
        {
            Console.WriteLine("static");
        }

        public OperatorLoad()
        {
            Console.WriteLine("no para");
        }


        public void Print()
        {
            Console.WriteLine("Number1 is " + Number1);
            Console.WriteLine("Number2 is " + Number2);
        }


        public static OperatorLoad operator +(OperatorLoad operatorLoad){
            operatorLoad.Number1 =+ operatorLoad.Number2;
            operatorLoad.Number2 =+ operatorLoad.temp-operatorLoad.Number1;
            return operatorLoad;
           }

    }
}
