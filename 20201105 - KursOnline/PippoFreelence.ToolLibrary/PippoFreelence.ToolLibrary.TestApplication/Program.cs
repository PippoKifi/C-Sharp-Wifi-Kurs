using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PippoFreelence.ToolLibrary.ConsoleIO;
using PippoFreelence.ToolLibrary.ConsoleIO2;


namespace PippoFreelence.ToolLibrary.TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConsoleTools.DisplayColoredMessage("Dies ist ein Test", ConsoleColor.Yellow);
            //Console.WriteLine("Der Text ist jetzt Farbig");

            //DateTime deinGeburstag = ConsoleTools.GetDateTime("Gib deine Geburtdatum ein");
            //Console.WriteLine($"Dein Geburtstag ist am {deinGeburstag}");

            //Console.WriteLine("Bravo");
            //Console.ReadLine();


            //ConsoleTools.DisplayColoredMessage("Das ist eine meldung");



            //HAUSUFGABEN
            //2 weitere Nützliche Methode dazu schreiben 
            //Input Format von DateTime parametrierbar 

            ConsoleTools2.Insert_ConsoleHeader("Das ist ein Bespielt Console-Header 'Hausaufgaben 2020.11.8'");

       

            ////Console.WriteLine("");
            ConsoleTools2.Insert_ConsoleHeader("Stelle dem User eine Ja-Nein Frage");
            Console.WriteLine($"Deine antwort war '{ConsoleTools2.AskUser_AYesNoQuestion("Hattest du eínene schönen tag heute")}'");


            ////Console.WriteLine("");
            ConsoleTools2.Insert_ConsoleHeader("Welche Farbe magst du am liebsten?");
            ConsoleTools2.AskUser_SelectAColor("Suche eine Farbe auf dem Enumerator aus");


        }


    }
}
