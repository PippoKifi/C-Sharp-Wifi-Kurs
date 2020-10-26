using System;

namespace Aufgabe3
{
    class Muenzen
    {
        static void Main(string[] args)
        {
            //3.Münzen
            //Schreiben Sie folgende Anwendung:
            //-Der User soll einen Münzbetrag(EURO-Münzen) eingeben.
            //- Das Programm prüft ob der eingebene Münzbetrag eine gültige Münze ist.
            //-Gültige Münzen in cent: 5, 10, 20, 50, 100, 200
            //a) Das Beispiel nur mit if – else if Blöcken implementieren
            //b) Verwendet zur Implementierung einen switch-case Block!
            //Die Grundlagen zum Thema switch-case können Sie hier nachlesen. Bitte arbeiten Sie die
            //angeführten Beispiele durch! D.h.legen Sie ein neues Projekt an und implementieren die Beispiele
            //auf der Website nach, versuchen Sie die Funktionsweise zu verstehen und verändern die Beispiel
            //nach Ihren Wünschen ab!


            int eingegebenerCenteBetrag = 0;
            Boolean eingabePrüfung = true;
            Boolean centBetragGültig = false;

            do
            {
                
                {
                    Console.WriteLine("Geben sie eine Cent betrag ein (5, 10, 20, 50, 100, 200)");

                    try //Eigegebener Wert gültig?
                    {
                        eingegebenerCenteBetrag = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Der eingegebene betrag war '{eingegebenerCenteBetrag}', gültig sind aber nut folgende eingaben = '5, 10, 20, 50, 100, 200'");
                        eingabePrüfung = false;
                    }

                    if (eingabePrüfung)
                    {
                        switch (eingegebenerCenteBetrag)
                        {
                            case 5:
                                centBetragGültig = true;
                                break;

                            case 10:
                                centBetragGültig = true;
                                break;

                            case 20:
                                centBetragGültig = true;
                                break;

                            case 50:
                                centBetragGültig = true;
                                break;

                            case 100:
                                centBetragGültig = true;
                                break;

                            case 200:
                                centBetragGültig = true;
                                break;

                            default:
                                centBetragGültig = false;
                                Console.WriteLine($"Sie haben '{eingegebenerCenteBetrag}' eingegeben, dieser Wert ist nicht gültig!");
                                break;
                        }
                    }
                }
                

            } while (!centBetragGültig);

            if (centBetragGültig) //Wurde der Betrag richtig eingegeben?
            {
                Console.WriteLine($"Der eingegebene betrag '{eingegebenerCenteBetrag}' war RICHTIG!!!");

            }


        }
    }
}
