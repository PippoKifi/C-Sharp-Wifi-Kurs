using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToDo - Menü vorlage auf File laden 
            //myMenu.LoadFromFile("menufile.txt"))


            //Menü-Erstellen
            Menu myMenu = new Menu();
            myMenu.Add(new MenuItem("Daten Laden", ConsoleKey.F1));
            myMenu.Add(new MenuItem("Daten speichern", ConsoleKey.F2));
            myMenu.Add(new EmptyItem());
            myMenu.Add(new MenuItem("Daten löschen", ConsoleKey.F3));
            myMenu.Add(new MenuItem("Daten Drucker", ConsoleKey.F4));
            myMenu.Add(new EmptyItem());
            myMenu.Add(new ColoredMenuItem("Ende", ConsoleKey.Escape, ConsoleColor.Yellow));

            //Menü-Ausgabe
            myMenu.Display(25);

            IMenueItem mySelection = myMenu.SelectItem("Ihre Wahl:");


            var testVariable = 10; //Implizite Typ Deklaration

            var testVariable_TestDecimal = 1999999999999900000.000000000000000000000; //Implizite Typ Deklaration

            //Der Datentyp ergibt sich aus dem Wert mit dem er initialisiert werden Rückgabe-Typ
            var mySelectionTest = myMenu.SelectItem("Ihre Wahl:"); //Lenkt den Blick auf die Variablen bezeichnung 

        }
    }
}
