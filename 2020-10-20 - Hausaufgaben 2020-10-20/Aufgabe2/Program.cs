using System;

namespace Hausaufgaben_2020_10_25
{
    class Aufgabe2
    {
        static void Main(string[] args)
        {
            //2.Entwicklen Sie ein Programm welche folgende Ausgabe generieren kann!
            //Dabei gilt: -Der User soll eine Zahl zwischen 1 und 5 eingeben
            //- Das Programm generiert daraufhin folgenden Ausgabe
            //Usereingabe: 4 PC: Dies war die Zahl vier!
            //Usereingabe: 2 PC: Dies war die Zahl zwei!

            Boolean userInputValid = false;
            int userInput = 0;

            do //User solange nach 
            {
                Console.WriteLine("Geben sie eine Zahl zwischen 1 und 5 ein");

                try //
                {
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput >= 1 && userInput <= 5)
                    {
                        userInputValid = true;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Eingabe ungültig!");
                }

            } while (!userInputValid);

            Console.WriteLine($"Die eingabe war {userInput}");
        }
    }
}
