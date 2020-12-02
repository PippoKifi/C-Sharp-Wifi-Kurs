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

            //creat selection menu
            myMenu = CreateMenu();

            while (true)
            {
                Console.Clear();
                myMenu.Display(35);
                var mySelection = myMenu.SelectItem("Ihre Wahl: ");

                //Console.WriteLine($"\nIhre Auswahl: {mySelection.Description}");

                //start execution
                mySelection.Execute(applicationParameters);
            }




            var myCar = new Car("SuperCar VW", 220);
            //myCar

            myCar.CarExploded += MyCar_CarExploded; //Mit '+' an dem Event ANMELDEN
                                                    //Mit '-' von Event ABMELDEN

            do
            {
                Console.WriteLine(myCar);
                myCar.SpeedUp(5);
                                

            } while (myCar.State != CarState.Exploded);


            //Vom Ereignis Ebmelden
            //myCar.CarExploded -= MyCar_CarExploded; //Event ABMELDEN

        }


        static IMenu<ApplicationParameters> CreateMenu()
        {
            var myMenu = new Menu<ApplicationParameters>();

            //myMenu.Add(new IMenuItem<ApplicationParameters>("Auto Einschalten",)

            myMenu.Add(new MenuItem<ApplicationParameters>("Daten laden", ConsoleKey.F1, DatenLaden));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten speichern", ConsoleKey.F2, DatenSpeichern));
            myMenu.Add(new SeperatorItem<ApplicationParameters>('~'));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten löschen", ConsoleKey.F3, DatenLoeschen));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten drucken", ConsoleKey.F4, DatenDrucken));
            myMenu.Add(new EmptyItem<ApplicationParameters>());
            myMenu.Add(new ColoredMenuItem<ApplicationParameters>("Ende", ConsoleKey.Escape, ConsoleColor.Yellow, Ende));

            return myMenu;
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
