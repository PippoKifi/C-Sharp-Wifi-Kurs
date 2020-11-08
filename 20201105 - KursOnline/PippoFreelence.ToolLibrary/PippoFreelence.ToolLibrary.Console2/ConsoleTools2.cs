using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


public enum AntwortAufJaNeinFragen
{
    Ja,
    Nein,
}

namespace PippoFreelence.ToolLibrary.ConsoleIO2
{
    struct StringTyps
    {
        int UserInput_IsString;
        int UserInput_IsInteger;
    }


    enum Display_ColoredMessage_UsingColorSelectionEnum : int
    {
        Red,
        Green,
        Blue,
    }

    enum WieWarDeinTagHeute 
    {
        Schön,
        Normal,
        Schlecht,
        Beschißen,
    }



    public class ConsoleTools2
    {

        /// <summary>
        /// Inser ConsoleHeader
        /// </summary>
        /// <param name="HeaderText">Our Message to display in the Header</param>
        public static void Insert_ConsoleHeader(string HeaderText)
        {
            int headerXPosition = 0;
            Console.WriteLine(new string('#', Console.WindowWidth - 1));
            headerXPosition = (Console.WindowWidth - HeaderText.Length) / 2;
            Console.CursorLeft = headerXPosition;
            Console.WriteLine(HeaderText);
            Console.WriteLine(new string('#', Console.WindowWidth - 1));

        }

        /// <summary>
        /// Generates colored messages for the console output
        /// </summary>
        /// <param name="message">The message to diyplay</param>
        /// <param name="messageColor">The color of the message</param>
        public static void AskUser_SelectAColor(string Question)
        {
            Console.WriteLine("Folgende Farben stehen dir zur auswahl:");
            int anzahlFarben = 0;

            //Eingetragene Farben in Enum vorstellen
            foreach (Display_ColoredMessage_UsingColorSelectionEnum color in (Display_ColoredMessage_UsingColorSelectionEnum[])Enum.GetValues(typeof(Display_ColoredMessage_UsingColorSelectionEnum)))
            {
                anzahlFarben++;
                Console.WriteLine($"{color} - Auswahlt zahl ({anzahlFarben})");
            }

            bool UserWahlGültig = false;
            int eingabeVonUser = 0;
            //User muss eine entscheidung treffen
            do
            {
                Console.WriteLine($"Welche Farbe möchtest du aussuchen? (Gib eine zahl zwischen '1' und '{anzahlFarben}' ein)"); ;
                string UnserDecision = Console.ReadLine();

                for (int i = 1; i < anzahlFarben; i++)
                {
                    try
                    {
                        if (i == int.Parse(UnserDecision))
                        {
                            eingabeVonUser = int.Parse(UnserDecision);
                            if (eingabeVonUser >= 0 && eingabeVonUser <= anzahlFarben)
                            {
                                UserWahlGültig = true;
                            }
                            else
                            {
                                Console.WriteLine($"Die eingegeben Auswahl ist nicht gültig (Ausserhalb von dem gültigem bereich)! (Gib eine zahl zwischen '1' und '{anzahlFarben}' ein)");
                                UserWahlGültig = false;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"Die eingegeben Auswahl ist nicht erlaubt!"); 
                    }
                }
            } while (!UserWahlGültig);

            Console.ForegroundColor = color(Display_ColoredMessage_UsingColorSelectionEnum.(1));

            Console.WriteLine($"Die Consolen farbe wurde auf ihren wunsch angepasst"); ;

            //ConsoleColor oldColor = Console.ForegroundColor;
            //Console.ForegroundColor = messageColor;
            //Console.WriteLine(message);
            //Console.ForegroundColor = oldColor
        }


        /// <summary>
        /// Stellt dem Anwender eine Ja\Nein Frage und übermittel die antwort
        /// </summary>
        /// <param name="Question">Hier kannst du dine Ja\Nein Frage angeben</param>
        /// <returns>Ja \ Nein</returns>
        public static string AskUser_AYesNoQuestion(String Question)
        {
            string userInput = null;
            do
            {
                Console.WriteLine($"Frage: {Question} - Du kannst mit eingabe von 'J' (Ja) od. 'N''Nein' antworten)?");
                var keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.J)
                {
                    return "Ja";
                }
                else
                {
                    return "Nein";
                }

            } while (string.IsNullOrWhiteSpace(userInput));
        }



    }




    /// <summary>
    /// Gruppiert und Zählt die eingabe von dem User
    /// </summary>
    /// <param name="InputString">User eingabe</param>
    /// <returns></returns>
    //public static StringTyps GroupAndCount_UserInput(string InputString)
    //{

    //    //    //int countString = 0;
    //    //    //int countInteger= 0;


    //    //StringTyps Userinputs = New();
    //    //Userinputs = 0;


    //    //    for (int i = 0; i < InputString.Length; i++)
    //    //    {
    //    //        try
    //    //        {

    //    //            if (int.Parse(InputString.IndexOf(i))
    //    //            {
    //    //                StringTyps.UserInput_IsInteger = ++;
    //    //            }


    //    //        }
    //    //        catch (Exception)
    //    //        {
    //    //            UserInput_IsString = ++
    //    //        }


    //    //    }

    //    return StringTyps.0;


    //}

}
