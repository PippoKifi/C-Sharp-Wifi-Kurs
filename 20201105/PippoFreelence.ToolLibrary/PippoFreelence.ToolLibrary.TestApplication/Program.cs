using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PippoFreelence.ToolLibrary.ConsoleIO;

namespace PippoFreelence.ToolLibrary.TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleTools.DisplayColoredMessage("Dies ist ein Test", ConsoleColor.Yellow);
            Console.WriteLine("Der Text ist jetzt Farbig");

            DateTime deinGeburstag = ConsoleTools.GetDateTime("Gib deine Geburtdatum ein");
            Console.WriteLine($"Dein Geburtstag ist am {deinGeburstag}");

            Console.WriteLine("Bravo");
            Console.ReadLine();


            ConsoleTools.DisplayColoredMessage("");


            //TODO
            //2 weitere Nützliche Methode dazu schreiben 
            //Input Format von DateTime parametrierbar 

            //codefreak @kati.bz


        }


    }
}
