using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject_9
{
    public class Calculator_9
    {
            //9. Visual Studio Debugging Tools and NUnit
            //Question:
            //Using NUnit, write test cases to validate the following Calculator class methods :
            // Add(int a, int b): Returns the sum of a and b.
            // Divide(int a, int b) : Returns the result of dividing a by b, and throws
            //DivideByZeroException if b is zero.
            public int Add(int x, int y)
            {
                    return x + y;
            }

            
            public int Divide(int x, int y)
            {
            if (y == 0) {

                throw new DivideByZeroException("Cannot divide by zero");
            }
                
            return x / y;
          
            }
    }
}
