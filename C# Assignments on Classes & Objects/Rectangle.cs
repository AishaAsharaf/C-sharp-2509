using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssign2
{
    public class Rectangle
    {
        public int CalculateArea(int width,int height)
        {
            
            return width * height;
        }

        public int CalculateArea(int sidelenght)
        {
            return sidelenght * sidelenght ;
        }
    }
}
