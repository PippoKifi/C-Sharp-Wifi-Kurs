using Grundlage_Polimorphie.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlage_Polimorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] myVehicleList = new Vehicle[]
            {
                new Vehicle(),
                new Vehicle("Badmobil","Black Edition",350,500,2),
                new Plane("F16", "Euro-Fighter Legal Edition", 2500,1000,2,Plane_Drives.Jets, 2,Plane_Producer.Airbus),
                new Car("VW", "Rabbit Golf",120,1500,5,90,1980),
            };

            //Hauptprogramm
            foreach (var vehicle in myVehicleList)
            {
                Display(vehicle);
            }

        }

        private static void Display(Vehicle vehicle)
        {
            Console.WriteLine(vehicle.GetInfoString());
            //Console.WriteLine();
        }
    }
}
