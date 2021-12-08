using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public override void DriveAbstract()
        {
            Console.WriteLine("The Car is driving abstractly (from derived class)...");
        }

        public bool HasTrunk { get; set; }
    }
}
