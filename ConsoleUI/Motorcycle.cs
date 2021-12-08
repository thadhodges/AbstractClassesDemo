using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving (from derived class)");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("This is from the direved class overide...");
        }

        public bool HasCart { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override int Year { get; set; }
    }
}
