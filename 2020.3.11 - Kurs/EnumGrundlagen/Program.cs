using System;

namespace EnumGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            ParticipantState state = ParticipantState.Unbekannt; //Startwert = Unbekannt

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Test");

            Console.WriteLine($"Der Status ist: '{state}'");
            Console.ResetColor();

            switch (state)
            {
                case ParticipantState.Anwesend:
                    break;
                case ParticipantState.Abwesend:
                    break;
                case ParticipantState.Krank:
                    break;
                case ParticipantState.Unbekannt:
                    break;
                case ParticipantState.Abgemeldet:
                    break;
                default:
                    break;
            }

        }
    }
}
