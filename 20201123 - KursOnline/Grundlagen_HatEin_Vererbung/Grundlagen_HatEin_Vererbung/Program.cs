using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle myVehicle1 = new Vehicle(); //Standard Konstriktor
            Vehicle myVehicle2 = new Vehicle("Vespa"); //Konstriktor 2;
            Vehicle myVehicle3 = new Vehicle("H1","H1 ist ein Gelendewaagen",180, 3000, 5); //Konstriktor 3;


            Car porsche = new Car("Porsche Carrera GT", "Ist ein Supersportwagen von Porsche", 334, 1380,2, 612, 2005);

            Plane airbus737 = new Plane("Airbus 737", "737 MAX is a fourth-generation Boeing 737", 840, 80000,400,Plane_Drives.Jets, 2, Plane_Producer.Airbus);



            //Fahrzeug Info ausgeben
            Vehicle[] sammlung = new Vehicle[6];
            int i;
            sammlung[0] = new Vehicle();
            sammlung[1] = myVehicle1;
            sammlung[2] = myVehicle2;
            sammlung[3] = myVehicle3;
            sammlung[4] = porsche;
            sammlung[5] = airbus737;
            
            string OutputString = "";
            for (i = 0; i < sammlung.Length; i++)
            {
                OutputString += sammlung[i].GetInfoString();
                Console.WriteLine();
                Console.WriteLine(OutputString);
            }


            //Fahrzeug Testen


            //for (porsche i = porsche.MaxSpeed; i < porsche.AktSpeed; i++)
            //{
            //    porsche.Drive(true, 20); //Um 20Km/h Beschlänigen
            //    Console.WriteLine(porsche.AktSpeed);
            //}

       

        }
    }
}
