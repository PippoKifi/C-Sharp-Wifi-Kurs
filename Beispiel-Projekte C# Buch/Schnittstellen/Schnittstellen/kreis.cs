using System;

namespace Schnittstellen
{
    class kreis : aenderbar, ICloneable
    {
        string farbe;
        double radius;

        public kreis(string f, double r)
        {
            farbe = f;
            radius = r;
        }

        public void vergroessern(double faktor)
        {
            radius = radius * faktor;
        }

        public void faerben(string f)
        {
            farbe = f;
        }

        public object Clone()
        {
            kreis tmp = new kreis(farbe, radius);
            return tmp;
        }

        public string aus()
        {
            return "Farbe: " + farbe +
                ", Radius: " + radius;
        }
    }
}
