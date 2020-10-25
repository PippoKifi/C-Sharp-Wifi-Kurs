using System;

namespace Vererbung
{
    class PKW : Fahrzeug
    {
        int insassen;

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
