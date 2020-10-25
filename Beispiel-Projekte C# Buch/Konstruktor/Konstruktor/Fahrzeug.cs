using System;

namespace Konstruktor
{
    class Fahrzeug
    {
        private string bezeichnung;
        private int geschwindigkeit;

        public Fahrzeug()
        {
            bezeichnung = "(leer)";
            geschwindigkeit = 0;
        }

        public Fahrzeug(string b)
        {
            bezeichnung = b;
            geschwindigkeit = 0;
        }

        public Fahrzeug(int g)
        {
            bezeichnung = "(leer)";
            geschwindigkeit = g;
        }

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public string ausgabe()
        {
            return "Bezeichnung: " + bezeichnung +
                "\n" + "Geschwindigkeit: " +
                geschwindigkeit + "\n";
        }

        public void beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }
    }
}
