using SelectionMenuExample.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //string myData = "Meine Daten";
            ApplicationParameters applicationParameters = new ApplicationParameters();
            IMenu<ApplicationParameters> myMenu = new Menu<ApplicationParameters>();

            //myMenu.LoadFromFile("menufile.txt");

            myMenu = CreateMenu();

            myMenu.Display(35);

            var mySelection = myMenu.SelectItem("Ihre Wahl: ");

            Console.WriteLine($"\nIhre Auswahl: {mySelection.Description}");

            //start execution 
            mySelection.Execute(applicationParameters);
            //mySelection.Execute(myData); //Man kann es auch so schreiben
        }

        private static IMenu<ApplicationParameters> CreateMenu()
        {
            //Menu myMenu = new Menu();

            var myMenu = new Menu<ApplicationParameters>();

            myMenu.Add(new MenuItem<ApplicationParameters>("Daten laden", ConsoleKey.F1, DatenLaden));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten speichern", ConsoleKey.F2,DatenSpeichern));
            myMenu.Add(new SeperatorItem<ApplicationParameters>('~'));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten löschen", ConsoleKey.F3, DatenLöschen));
            myMenu.Add(new MenuItem<ApplicationParameters>("Daten drucken", ConsoleKey.F4, DatenDrucken));
            myMenu.Add(new EmptyItem<ApplicationParameters>());
            myMenu.Add(new ColoredMenuItem<ApplicationParameters>("Ende", ConsoleKey.Escape, ConsoleColor.Yellow, Ende));

            return myMenu;
        }

        private static void Ende(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void ProgrammBeendenYellow(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void DatenDrucken(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void DatenLöschen(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void DatenSpeichern(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }

        private static void DatenLaden(ApplicationParameters obj)
        {
            throw new NotImplementedException();
        }
    }
}
