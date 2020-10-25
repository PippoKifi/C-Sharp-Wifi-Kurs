using System;

namespace KonsoleFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] stadt = {"München", "Berlin",
                "Bonn", "Bremerhaven", "Ulm"};

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine(
                    "{0,-15}{1,9:0.0000}{2,12:#,##0.0}",
                    stadt[i], i / 7.0, i * 1e4 / 7);
            }
        }
    }
}
