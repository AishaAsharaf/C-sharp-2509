using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace C__Assignments__Part_7
{

    //Assignment 4. Events
    //Question:
    //Create an event called OnCompleted in a class Process. Raise the event when a process is
    //completed.Subscribe to the event from the main program to display a message.

    class Process
    {
        //OnCompleted event
        public event EventHandler OnCompleted;

        // Method 
        public void Trigger()
        {
            Console.WriteLine("Process started...");

            
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Process completed, raise the event
            OnCompleted?.Invoke(this, EventArgs.Empty);
        }
    }


}
