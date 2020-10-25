using System;

namespace Polymorphie
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

        public override string ausgabe()
        {
            return base.ausgabe() +
                "Insassen: " + insassen + "\n";
        }

        public override string ToString()
        {
            return base.ToString() +
                "Insassen: " + insassen + "\n";
        }
    }
}
