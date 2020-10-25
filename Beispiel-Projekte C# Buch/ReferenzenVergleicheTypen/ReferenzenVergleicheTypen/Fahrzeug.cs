using System;

namespace ReferenzenVergleicheTypen
{
    class Fahrzeug
    {
        private string bezeichnung;
        private int geschwindigkeit;

        public Fahrzeug(string b, int g)
        {
            bezeichnung = b;
            geschwindigkeit = g;
        }

        public string ausgabe()
        {
            return bezeichnung + ", " + geschwindigkeit;
        }

        public bool Equals(Fahrzeug x)
        {
            if (bezeichnung == x.bezeichnung && geschwindigkeit == x.geschwindigkeit)
                return true;
            else
                return false;
        }

        public void beschleunigen(int wert)
        {
            geschwindigkeit += wert;
        }
    }
}
