using System;

namespace KlasseObjekt
{
    class Fahrzeug
    {
        private int geschwindigkeit;

        public string ausgabe()
        {
            return "Geschwindigkeit: " +
                geschwindigkeit;
        }

        public void beschleunigen(int wert)
        {
            this.geschwindigkeit += wert;
        }
    }
}
