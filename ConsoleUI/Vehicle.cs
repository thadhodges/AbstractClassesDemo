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


        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract int Year { get; set; }
    }
}
