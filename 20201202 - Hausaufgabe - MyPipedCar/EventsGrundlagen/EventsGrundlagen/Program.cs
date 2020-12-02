using EventsGrundlagen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPimpedCar
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationParameters applicationParameters = new ApplicationParameters();
            IMenu<ApplicationParameters> myMenu = new Menu<ApplicationParameters>();

            myMenu = CreateMenu();
      
            while (true) //User abfragen
            {
                Console.Clear();
                myMenu.Display(35); //Breite angeben
                var mySelection = myMenu.SelectItem("Ihre Wahl: ");

                //start execution
                //mySelection.Execute(applicationParameters);

                Engine DobloMotor1 = new Engine("1.6 Multijet", EngineTyp.Gasoline, 180);
                Engine DobloMotor2 = new Engine("2.9 Multijet", EngineTyp.Diesel, 200);

                var myCar = new Car("Fiat Ducato", DobloMotor2);
                myCar.CarExploded += MyCar_CarExploded; //Event Abonieren
                do
                {
                    Console.WriteLine(myCar);
                    myCar.SpeedUp(5);

                } while (myCar.State != CarState.Exploded);

            }
        }


        static IMenu<ApplicationParameters> CreateMenu()
        {
            var myMenu = new Menu<ApplicationParameters>();
            myMenu.Add(new MenuItem<ApplicationParameters>("Auto Ausschalten", ConsoleKey.O, AutoAusschalten));
            myMenu.Add(new MenuItem<ApplicationParameters>("Auto Einsschalten", ConsoleKey.I, AutoEinschalten));
            myMenu.Add(new SeperatorItem<ApplicationParameters>('~'));
            myMenu.Add(new MenuItem<ApplicationParameters>("Beschleünigen", ConsoleKey.UpArrow, AutoBeschleünigen));
            myMenu.Add(new MenuItem<ApplicationParameters>("Bremsen", ConsoleKey.DownArrow, AutoBremsen));
            myMenu.Add(new SeperatorItem<ApplicationParameters>('~'));
            myMenu.Add(new MenuItem<ApplicationParameters>("Links Lencken", ConsoleKey.LeftArrow, LinksLencken));
            myMenu.Add(new MenuItem<ApplicationParameters>("Rechts Lencken", ConsoleKey.LeftArrow, RechtsLencken));
            myMenu.Add(new SeperatorItem<ApplicationParameters>('~'));
            myMenu.Add(new ColoredMenuItem<ApplicationParameters>("Programm beenden", ConsoleKey.Escape, ConsoleColor.Yellow, Ende));
            return myMenu;
        }

        private static void RechtsLencken(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void LinksLencken(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void AutoBremsen(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void AutoBeschleünigen(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void AutoEinschalten(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void AutoAusschalten(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }



        //Methode die von Delegate aufgerufen wird
        private static void MyCar_CarExploded(int currentSpeed, int maxSpeed)
        {
            Console.WriteLine("Leider ist das Auto Explodiert!");
        }

        static void Ende(ApplicationParameters obj)
        {
            Environment.Exit(0);
        }

        static void DatenDrucken(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        static void DatenLoeschen(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        static void DatenSpeichern(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        static void DatenLaden(ApplicationParameters obj)
        {
            Console.WriteLine($"\n\nDaten werden nun geladen....");
            Console.ReadLine();
        }


    }
}
