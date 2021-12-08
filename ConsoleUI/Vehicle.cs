using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public abstract void DriveAbstract();


        public virtual void DriveVirtual()
        {
            Console.WriteLine("This vehicle operates.");
        }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}
