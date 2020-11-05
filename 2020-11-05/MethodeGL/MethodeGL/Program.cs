using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeGL
{
    class Program
    {
        static void Main(string[] args)
        {

            int eineVariable;
            eineVariable = GetInt("Bitte Länge eingeben: ");
            Console.WriteLine("Länge = " + eineVariable);

            eineVariable = GetInt("Bitte Breite eingeben: ");
            Console.WriteLine("Breite = " + eineVariable);

            //

            double eineVariable_Dou;
            eineVariable_Dou = GetDouble("Bitte Länge eingeben: ");
            Console.WriteLine("Länge = " + eineVariable_Dou);

            //

            double gewicht = GetDouble("Gewicht eingeben: ");
            Console.WriteLine("Das Gewicht ist = " + gewicht);
        
            DateTime eineVariable_DateTime;
            eineVariable_DateTime = GetDateTime("Bitte gibt dein Geburtsdatum ein: ");
            Console.WriteLine($"Sie sind =  { DateTime.Now.Year - eineVariable_DateTime.Year} jahre alt!");


        }


        /// <summary>
        /// Reads an integer value from console input
        /// </summary>
        /// <param name="inputPrompt">Promt for the user</param>
        /// <returns>Input value as integer</returns>
        static int GetInt(string inputPrompt)
        {
            int userInputValue = 0;
            bool userInputIsValid = false;

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    userInputValue = int.Parse(Console.ReadLine());
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }


        //GetDouble() // GetString() // GetDateTime() => KISS (Keep it Simple)

        /// <summary>
        /// Reads an double value from console input
        /// </summary>
        /// <param name="inputPrompt">Promt for the user</param>
        /// <returns>Input value as double</returns>
        static double GetDouble(string inputPrompt)
        {
            double userInputValue = 0;
            bool userInputIsValid = false;

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    userInputValue = double.Parse(Console.ReadLine());
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }

        /// <summary>
        /// Reads an DateTime value from console input
        /// The format must be dd.MM.yyyy hh:mm:ss
        /// </summary>
        /// <param name="inputPrompt">Promt for the user</param>
        /// <returns>Input value as DateTime</returns>
        /// https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-date-and-time-format-strings
        static DateTime GetDateTime(string inputPrompt)
        {
            DateTime userInputValue = DateTime.MinValue; //Konstanten für die initialisierung 
            bool userInputIsValid = false;

            string inputFormat = "dd.MM.yyyy hh:mm:ss"; //vorgegebenes DatumTime format

            do
            {
                Console.Write(inputPrompt);
                try
                {
                    userInputValue = DateTime.ParseExact(Console.ReadLine(), inputFormat,CultureInfo.InvariantCulture);
                    userInputIsValid = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    userInputIsValid = false;
                }
            }
            while (!userInputIsValid);

            return userInputValue;
        }

        /// <summary>
        /// Reads an string value from console input
        /// </summary>
        /// <param name="inputPrompt">Promt for the user</param>
        /// <returns>Input value as String</returns>
        static string GetString(string inputPrompt)
        {
            Console.WriteLine(inputPrompt);
            return Console.ReadLine();
        }


    }
}
