using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taksi taxi = new Taksi();

            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();

            Console.WriteLine();

            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadLine();


        }
    }
}