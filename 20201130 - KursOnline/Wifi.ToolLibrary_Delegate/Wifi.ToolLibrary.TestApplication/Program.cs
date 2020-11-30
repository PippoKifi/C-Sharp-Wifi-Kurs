using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wifi.ToolLibrary.ConsoleIo;

namespace Wifi.ToolLibrary.TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleTools.DisplayColoredMessage("Dies ist ein Test..", ConsoleColor.Red);

            //double val1 = ConsoleTools.GetDouble("Bitte Wert eingeben: ");

            //Console.WriteLine($"Der Wert war: {val1}");

            //ConsoleTools.DisplayColoredMessage("Test", ConsoleColor.Yellow);

            //ConsoleTools.DisplayColoredMessage("Hallo");

            //Console.ReadLine();

            //Console.WriteLine("Use STD Random");
            //Random rnd = new Random();
            //Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1,10)}");
            //Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1, 10)}");
            //Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1, 10)}");
            //Console.WriteLine($" Zufällg zahl (1-10) {rnd.Next(1, 10)}");

            //Console.WriteLine("Use RandomAdv");
            //RandomAdv rndAdv = new RandomAdv();
            //Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.Next(1, 10)}");
            //Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.Next(1, 10)}");
            //Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.Next(1, 10)}");

            //Console.WriteLine("Use RandomAdv whit NextString ");
            //Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.NextString(25)}");
            //Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.NextString(50)}");
            //Console.WriteLine($" Zufällg zahl (1-10) {rndAdv.NextString(75)}");

           var geburtsJahr =  ConsoleTools.GetInt("In was für eine Geburtsjahr ", DisplayErrorOnSameLine);

        }

        private static void DisplayInputError(string errorMessage)
        {
            //Wie soll der Fehle dargestellt werden?
            ConsoleTools.DisplayColoredMessage(errorMessage, ConsoleColor.Red);
        }

        static  void DisplayErrorOnSameLine(string errorMessage)
        {
            var oldYPosition = Console.CursorTop;
            Console.SetCursorPosition(0, Console.WindowHeight - 3);
            ConsoleTools.DisplayColoredMessage(errorMessage, ConsoleColor.Red);
            Console.ReadLine();

            //Löschen der Fehlermeldung
            Console.SetCursorPosition(0, Console.WindowHeight - 3);
            Console.WriteLine(new string(' ', errorMessage.Length));
            Console.SetCursorPosition(0, oldYPosition);
        }


    }
}
