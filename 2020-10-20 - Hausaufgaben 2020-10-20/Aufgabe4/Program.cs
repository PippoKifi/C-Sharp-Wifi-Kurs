using System;

namespace Hausaufgaben_2020_10_25
{
    class Aufgabe4_Zahlenraten
    {
        static void Main(string[] args)
        {
            // 4.Zahlenraten
            // Das Programm ermittelt intern eine ganze Zahl(1 - 100).Diese Zahl soll der User erraten!
            // Das Programm gibt folgende Hinweise:
            // -Ist die eingegebene Zahl zu klein: ==> Die Zahl ist größer!
            //- Ist die eingegebene Zahl zu groß: ==> Die Zahl ist kleiner!
            //- Ist die eingegebene Zahl gleich interne Zahl: ==> GEWONNEN!
            // a) Begrenzen Sie die Anzahl der Versuche!
            // b) Begrenzen Sie die Zeit/ Versuch!
            // Zur Generierung der Zufallszahl muss ein Zufallsgenerator verwendet werden.Wie das realisiert
            // werden kann, können Sie hier nachlesen.

            Random zufallsZahl = new Random();
            int aktZufallsZahl = zufallsZahl.Next(0, 100); //Zufallszahl Generieren

            string eingegebenerCenteBetrag_String;
            Boolean eingabePrüfung = true;

            do
            {
             Console.WriteLine("Erraten sie die Zufallzahl zwischen 0 - 100");
                eingegebenerCenteBetrag_String = Console.ReadLine(); //User eingabe in string-Variable schreiben

                //Eingabe auf korrektheit prüfen
                for (int i = 0; i < eingegebenerCenteBetrag_String.Length; i++)
                {

                    char aktSingleToCheck = eingegebenerCenteBetrag_String[i];
                    if (!char.IsDigit(aktSingleToCheck)) //Enthält die eingabe auch zeichen die keine Zahlen (int) sind?
                    {
                        Console.WriteLine($"Sie haben '{eingegebenerCenteBetrag_String}' eingegeben, dieser Wert ist nicht gültig!");
                        eingabePrüfung = false; //Flag setzte das Eingabe nicht gültig ist
                        break; //for schleife verlassen
                    }
                    eingabePrüfung = true;
                }


                //### Eingabe auf korrektheit prüfen ###
                //######################################

                //switch (int.Parse(eingegebenerCenteBetrag_String)) //String in Int convertieren
                //{

                //    case aktZufallsZahl:
                //        Console.WriteLine($"BINGO!!! - Gratulation! Du hast die geheimzahl '{eingegebenerCenteBetrag_String}' erraten !");
                //        eingabePrüfung = true;
                //        break;

                //    case < aktZufallsZahl:
                //        Console.WriteLine($"Der eingegebene Wert ist leider ZU KLEIN '{eingegebenerCenteBetrag_String}'!");
                //        eingabePrüfung = false;
                //        break;

                //    case > aktZufallsZahl:
                //        Console.WriteLine($"Der eingegebene Wert ist leider ZU HOCH '{eingegebenerCenteBetrag_String}'!");
                //        eingabePrüfung = false;
                //        break;

                //    default:
                //        //centBetragGültig = false;
                //        //Console.WriteLine($"Sie haben '{eingegebenerCenteBetrag_String}' eingegeben, dieser Wert ist nicht gültig!");
                //        //break;
                //}

                if (eingabePrüfung)
                {

                

                int eingegebenerCenteBetrag_int = int.Parse(eingegebenerCenteBetrag_String); //String in Int convertieren
                if (eingegebenerCenteBetrag_int == aktZufallsZahl)
                {
                    Console.WriteLine($"BINGO!!! - Gratulation! Du hast die geheimzahl '{eingegebenerCenteBetrag_String}' erraten !");
                    eingabePrüfung = true;
                }
                else if(eingegebenerCenteBetrag_int < aktZufallsZahl)
                {
                    Console.WriteLine($"Der eingegebene Wert ist leider ZU KLEIN '{eingegebenerCenteBetrag_String}'!");
                    eingabePrüfung = false;
                }
                else if(eingegebenerCenteBetrag_int > aktZufallsZahl)
                {
                    Console.WriteLine($"Der eingegebene Wert ist leider ZU GROSS '{eingegebenerCenteBetrag_String}'!");
                    eingabePrüfung = false;
                }
                }

            } while (!eingabePrüfung);




            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }
}
