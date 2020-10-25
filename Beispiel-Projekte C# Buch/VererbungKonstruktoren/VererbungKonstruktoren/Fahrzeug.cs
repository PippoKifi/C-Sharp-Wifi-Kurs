using System;

namespace VererbungKonstruktoren
{
    class Fahrzeug
    {
        string bezeichnung;
        int geschwindigkeit;

        public Fahrzeug()
        {
            bezeichnung = "(leer)";
            geschwindigkeit = 0;
        }

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public void beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }

        public string ausgabe()
        {
            return "Bezeichnung: " + bezeichnung +
                "\n" + "Geschwindigkeit: " +
                geschwindigkeit + "\n";
        }
    }
}
