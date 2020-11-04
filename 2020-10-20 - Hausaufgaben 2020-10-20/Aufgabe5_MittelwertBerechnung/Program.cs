using System;

namespace Hausaufgaben_2020_10_25
{
    class Aufgabe6_MittelwertBerechnung
    {
        static void Main(string[] args)
        {
            //6.Mittelwert Berechnung
            //Der User gibt die Anzahl der Zahlen für die Mittelwertberechnung ein. 
            //Das Programm soll anschließend alle Zahlen der Reihe nach einlesen und den Mittelwert berechnen.
            //Achten Sie auf eine gute Benutzerführung!
            //a) Implementieren Sie dieses Beispiel ohne Arrays!
            //b) Implementieren Sie dieses Beispiel mit Arrays!

            //Anzahl der Zahlen für die Mittelwertberechnung ermitteln
            
            int AnzahlZahlen = 0;
            bool eingabeKorrekt = false;
            do
            {
                Console.WriteLine("Anzahl der Zahlen für die Mittelwertberechnung?: ");
                string userEingabe = Console.ReadLine(); //User eingabe in string-Variable schreiben
                if (CheckUserInput(userEingabe))
                {
                    AnzahlZahlen = int.Parse(userEingabe);
                    eingabeKorrekt = true;
                }
                else
                {
                    Console.WriteLine("Der eingegebene Wert ist nicht gültig! Bitte versuche sie es noch einmal");
                    eingabeKorrekt = false;
                }

            } while (!eingabeKorrekt);

            //Zahlen der Reihe nach einlesen 
            int[] AnzahlZahlen_Array;
            AnzahlZahlen_Array = new int[AnzahlZahlen];
            int zahlAufrechnen = 0;

            for (int i = 0; i < AnzahlZahlen; i++)
            {
                Console.WriteLine($"Geben sie die Zahl {i} ein: ");
                string userEingabe = Console.ReadLine(); //User eingabe in string-Variable schreiben
                if (CheckUserInput(userEingabe))
                {
                   int aktZahl = int.Parse(userEingabe); //String in Int konvertieren
                    AnzahlZahlen_Array[i] = aktZahl;
                    zahlAufrechnen =+ aktZahl;
                }
                else
                {
                    Console.WriteLine("Der eingegebene Wert ist nicht gültig! Bitte versuche sie es noch einmal");
                }
            }

            //Mittelwert berechnen
           int mittelwertBerechnen = zahlAufrechnen / AnzahlZahlen;

        }



        //Eingabe auf korrektheit prüfen
        static Boolean CheckUserInput(string Input2Checkt)
        //, Boolean NurZahlenErlaub
        {

            //string[] blacklist;
            //blacklist = new string[10];
            //blacklist[0] = "-";
            //blacklist[1] = " ";


            //string[] whitelist;
            //whitelist = new string[10];
            //whitelist[0] = "-";
            //whitelist[1] = "-";


            if (true) //Nur auf Zahlen prüfen?
            {
                for (int i = 0; i < Input2Checkt.Length; i++)
                {
                    char aktSingleToCheck = Input2Checkt[i];
                    if (!char.IsDigit(aktSingleToCheck)) //Enthält die eingabe auch zeichen die keine Zahlen (int) sind?
                    {
                        //Console.WriteLine($"Sie haben '{Input2Check}' eingegeben, dieser Wert ist nicht gültig!");
                        return false; //Flag setzte das Eingabe nicht gültig ist
                    }
                    //return true; 
                }
            }

            return true;

        }


    }
}
