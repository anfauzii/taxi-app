using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3_Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek Taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Fauzi";
            taxi.OnDuty = true;
            taxi.NumPassenger = 17;
            
            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
