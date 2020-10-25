using System;

namespace StatischeElemente
{
    class Zahl
    {
        double wert;
        int nummer;
        static int anzahl = 0;
        public static double pi = 3.1415926;

        public Zahl(double x)
        {
            anzahl += 1;
            nummer = anzahl;
            wert = x;
        }

        public void maldrei()
        {
            wert = wert * 3;
        }

        public static double verdoppeln(double x)
        {
            return x * 2;
        }

        public string ausgabe()
        {
            return "Objekt Nr. " + nummer +
                ", Wert: " + wert;
        }
    }
}
