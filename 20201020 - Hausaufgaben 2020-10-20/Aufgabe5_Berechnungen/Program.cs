using System;

namespace Hausaufgaben_2020_10_25
{
   public class Aufgabe5_Berechnungen
    {
        static void Main(string[] args)
        {
            //Schreiben Sie eine Anwendung mit der die Fläche eines Rechtecks berechnet werden kann! 
            //Der User soll die einzelnen Seiten(a, b) eingeben.
            //Das Programm berechnet die Fläche und generiert die Ausgabe dazu!
            //Achten Sie auf eine formatierte Ausgabe und eine fehlertolerante Eingabe der Werte!
            //Dieses Beispiel kann mit allen möglichen Formeln implementiert werden.

            string userEingabe_Rechteck_X;
            Boolean userEingabe_Rechteck_X_Correct = false;

            Console.WriteLine("Dieses Programm berechnet die Fläche von einem Rechteck");

            do //X Koordiante abfragen
            {
                Console.WriteLine("Geben sie die X-Koordinate von ihrem Rechteck ein:");
                userEingabe_Rechteck_X = Console.ReadLine(); //User eingabe in string-Variable schreiben
                if ( CheckUserInput(userEingabe_Rechteck_X))
                {
                    userEingabe_Rechteck_X_Correct = true;
                }
                else
                {
                    Console.WriteLine("Der eingegebene Wert ist nicht gültig! Bitte versuche sie es noch einmal");
                }

            } while (!userEingabe_Rechteck_X_Correct);


            string userEingabe_Rechteck_Y;
            Boolean userEingabe_Rechteck_Y_Correct = false;
            do //Y Koordiante abfragen
            {
                Console.WriteLine("Geben sie die Y-Koordinate von ihrem Rechteck ein:");
                userEingabe_Rechteck_Y = Console.ReadLine(); //User eingabe in string-Variable schreiben
                if (CheckUserInput(userEingabe_Rechteck_Y))
                {
                    userEingabe_Rechteck_Y_Correct = true;
                }
                else
                {
                    Console.WriteLine("Der eingegebene Wert ist nicht gültig! Bitte versuche sie es noch einmal");
                }

            } while (!userEingabe_Rechteck_Y_Correct);


            //Fläche berechnen
            int Fläche_berechnung = (int.Parse(userEingabe_Rechteck_X) * int.Parse(userEingabe_Rechteck_Y));

            //Ausgabe generieren
            Console.WriteLine($"Das ergebnis der Fläche berechnen ist: {Fläche_berechnung}");

        }


        //Eingabe auf korrektheit prüfen
        static Boolean CheckUserInput(string Input2Checkt)
        //, Boolean NurZahlenErlaub
        {

            string[] blacklist;
            blacklist = new string[10];
            blacklist[0] = "-";
            blacklist[1] = " ";


            string[] whitelist;
            whitelist = new string[10];
            whitelist[0] = "-";
            whitelist[1] = "-";


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
