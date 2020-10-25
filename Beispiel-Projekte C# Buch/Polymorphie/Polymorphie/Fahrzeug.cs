using System;

namespace Polymorphie
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

        public virtual string ausgabe()
        {
            return "\n" +
                "Bezeichnung: " + bezeichnung + "\n" +
                "Geschwindigkeit: " + geschwindigkeit +
                "\n";
        }

        public override string ToString()
        {
            return "\n" +
                "Bezeichnung: " + bezeichnung + "\n" +
                "Geschwindigkeit: " + geschwindigkeit +
                "\n";
        }
    }
}
