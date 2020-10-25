using System;

namespace Eigenschaftsmethode
{
    class Fahrzeug
    {
        private int geschwindigkeit;

        public int Geschwindigkeit
        {
            get
            {
                return geschwindigkeit;
            }

            private set
            {
                if (value > 100)
                    geschwindigkeit = 100;
                else if (value < 0)
                    geschwindigkeit = 0;
                else
                    geschwindigkeit = value;
            }
        }

        public void beschleunigen(int wert)
        {
            Geschwindigkeit += wert;
        }
    }
}
