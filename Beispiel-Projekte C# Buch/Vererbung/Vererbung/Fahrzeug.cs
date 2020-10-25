using System;

namespace Vererbung
{
    class Fahrzeug
    {
        int geschwindigkeit;

        public void beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }

        public string ausgabe()
        {
            return "Geschwindigkeit: " +
                geschwindigkeit + "\n";
        }
    }
}
