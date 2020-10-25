using System;

namespace VererbungKonstruktoren
{
    class PKW : Fahrzeug
    {
        int insassen;

        public PKW()
        {
            insassen = 0;
        }

        public PKW(string b, int g, int i)
            : base(b, g)
        {
            insassen = i;
        }

        public void einsteigen(int anzahl)
        {
            insassen += anzahl;
        }

        public new string ausgabe()
        {
            return "Insassen: " + insassen +
                "\n" + base.ausgabe();
        }
    }
}
