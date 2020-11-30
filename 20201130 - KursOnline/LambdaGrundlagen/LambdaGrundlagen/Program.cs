using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaGrundlagen
{
    public delegate void DoSomethinHandle<T,T2>(string message, T2 count);
    
    class Program
    {
        static void Main(string[] args)
        {
            DoSomethinHandle <string> myAction = DisplayMessage;
            myAction("Hallo Welt");

            // ### Delegates die uns Microsoft zur verfügung stellt
            Action<string> myNewAction = DisplayMessage;//Methode OHNE Rückgabe-Typ (PARAMETER)
            Func<int, bool> myFunc = CheckSize; //Methode MIT Rückgabe-Typ (PARAMETER | RÜCKGABE)
            // ### Delegates die uns Microsoft zur verfügung stellt

            //Anonyme Methode (gibt es erste ab C# 2.0) | Kann nuin dem Main verwenden
            myAction = delegate (string userText)
            {
                Console.WriteLine("Ausgabe anonyme Methode: ");
                Console.WriteLine(userText);
            };
            myAction("Invoke anonyme Methode");

            //Anonyme Methode (gibt es erste ab C# 3.0) 
            myAction = (string userText) => //'=>' ist das zeichen für Delegate (Lambda expression)
            {
                Console.WriteLine("Ausgabe anonyme Methode: ");
                Console.WriteLine(userText);
            };

            //Daten Typ kann auch weggelassen werden
            myAction = userText => //'=>' ist das zeichen für Delegate
            {
                Console.WriteLine("Ausgabe anonyme Methode: ");
                Console.WriteLine(userText);
            };

            //Funktioniert nur mit einem Parameter
            myAction = x => Console.WriteLine(x);
            myAction("Test");


            int[] zahlenReihe = new int[] { 5, 21, 8, 9, 22, 50, 1, 94 };
            zahlenReihe = zahlenReihe.Where(x => x > 10).ToArray(); // Diese zeile macht genau dasselbe wie 'CheckSize()' | Entfernt alle Zahlen aus dem Array die < 10 sind
            //Where ist wie ein If-Filter |  das was in den klammern ist (BEDINGUNG)

            // Macht dasselbe wie diese Methode!
            //List<int> sortElements = new List<int>();
            //foreach (var item in zahlenReihe)
            //{
            //    if (item > 10)
            //    {
            //        sortElements.Add(item);
            //    }
            //}


            //Vorteil von Lambda + Dalagate 
            //Methode on the Fly definieren

            var max = zahlenReihe.Select(x => x * x).ToArray(); //Transformation (jede zahl wird Quadriert (x10))


        }


        static bool CheckSize(int number)
        {
            return number > 10;
        }


        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

    }
}
