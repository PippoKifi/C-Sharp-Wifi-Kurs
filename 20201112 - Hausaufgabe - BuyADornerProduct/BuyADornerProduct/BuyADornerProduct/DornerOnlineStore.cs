using System;
using System.IO;
using Wifi.ToolLibrary.ConsoleIo;

namespace BuyADornerProduct
{
    public class DornerOnlineStore
    {
        public DornerCustomer[] ThisIsAnDornerCustomer;
        public DornerProducts ThisAreTheDornerProducts;

        /// <summary>
        /// Managed den Online einkauf von dem Dorner Store
        /// </summary>
        /// <param name="userName">Username of customer</param>
        /// <param name="UserPassword">Password of customer<</param>
        public DornerOnlineStore(string userName, string UserPassword) //Instance Initialisierung
        {

            bool userAvailable = false;

            //Kunde muss vorhanden (Registriert) sein
            if (IsTheUserRegistered) //User registered?
            {

            }
            else //Registered User
            {
                string userEntscheidung = (ConsoleTools.GetString("Möchtest du einen neuen User Anlagen [J] ?"));
                if (userEntscheidung == "J") //NEuer Benutzer anlegen
                {
                    CreateNewUsers(userName, UserPassword);
                    userAvailable = true;
                }
                else
                    Console.WriteLine("Um was in dem Dorner Store kaufen zu können müssen sie sich anmelden!");
                userAvailable = true;
            }

            bool userCreditworthiness = false;
            if (userAvailable = true)
            {
                //Kunden Bonität prüfen
                
            }

            //Kunden Bonität prüfen
            if (userCreditworthiness = true)
            {
                //Produkte anbieten

            }


        }

        private void CreateNewUsers(string userName, string userPassword)
        {
            ThisIsAnDornerCustomer
        }

        /// <summary>
        /// Ist der angegebene Benutzer schon angemeldet?
        /// </summary>
        /// <param name="userName">Benutzer der überprüft werden soll</param>
        /// <returns>Ergebnis von Prüfung</returns>
        static bool IsTheUserRegistered(string userName)
        {
            TextDatei


            return false;
        }

        static void SaveDataInTextFile(string fileName, DornerCustomer[] ThisIsAnDornerCustomer)
        {
            using (StreamWriter sw = new StreamWriter(fileName, true))
            {
                foreach (DornerCustomer t in ThisIsAnDornerCustomer)
                {
                    //sw.WriteLine($"{t.}, {t.Nachname}, {t.Strasse}, {t.HausNr}, {t.Plz}, {t.Ort}, {t.Geburtsdatum}");
                }
            }
        }


    }
}