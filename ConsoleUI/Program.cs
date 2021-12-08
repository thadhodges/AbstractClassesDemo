using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles
            List<Vehicle> vlist = new List<Vehicle>();

            Motorcycle mc1 = new Motorcycle() 
            { 
                HasCart = true, 
                Make = "harley", 
                Model = "xx45",               
                Year = 2015 
            };

            Car car1 = new Car()
            {
                HasTrunk = true,
                Make = "Honda",
                Model = "Civic",
                Year = 2010
            };

            Vehicle car2 = new Car()
            {
                HasTrunk = true,
                Make = "Ford",
                Model = "Fiesta",
                Year = 2021
            };

            Vehicle mc2 = new Motorcycle() 
            { 
                HasCart = true, 
                Make = "Suziki", 
                Model = "XRV", 
                Year = 2017 
            };

            vlist.Add(car1);
            vlist.Add(car2);
            vlist.Add(mc1);
            vlist.Add(mc2);

            foreach (var item in vlist)
            {
                Console.WriteLine($"Vehicle information ; {item.Make} /// {item.Model} /// {item.Year}");
                Console.WriteLine("_____________________________________________________________________");
            }

            mc1.DriveAbstract();
            Console.WriteLine("______________________________________________________");
            car1.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
