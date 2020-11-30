using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndLambda
{
    // Delegates and Lambda Expression 
    // Functionszeiger (Functions Pointer)
    // Es sind Datentypen


    //Daten-Typ spezifizieren
    // Delegates Variablen hören immer mit 'Handler' auf

    public delegate void DoSomethingHandler(string message); // Das ist ein Delegate
    //'DoSomethingHandler' ist unser Daten-Typ
    //Im hinterrund werden ableitungen von der Klasse erstellt


    class Program
    {
        static void Main(string[] args)
        {
            DoSomethingHandler myAction; //Methoden zuweisung
            DoSomethingHandler[] myActionList = new DoSomethingHandler[2];

            //Methode als WER zuweisen
            //myAction = DisplayMessage;
            myAction = CreateOutput;


            //Mehrere Mehoden in ein Array zusammenfassen
            myActionList[0] = CreateOutput;
            myActionList[1] = DisplayMessage;

            foreach (var method in myActionList)
            {
                Console.WriteLine($"Invoke {method.Method.Name}:");
                method("Wie cool ist denn das?");
                Console.WriteLine();
            }


            //Methode über delegate aufrufen
            myAction("Hallo Welt!");
        }

        static void CreateOutput(string text)
        {
            Console.WriteLine(" ... creating output now:");
            Console.WriteLine("\t{0}", text.ToUpper());
        }

        static void DisplayMessage(string userMessage)
        {
            Console.WriteLine(userMessage);
        }

    }
}
