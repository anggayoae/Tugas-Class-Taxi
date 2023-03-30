using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanTaxi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.Drivername = "Angga";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;


            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.WriteLine();
        }
    }
}
