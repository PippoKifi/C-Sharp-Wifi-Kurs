namespace Strukturen
{
    struct kontakt
    {
        public int plz;
        public string ort;
        public string strasse;
        public int hausnummer;
        public telefon tel, fax;

        /* Konstruktor */
        public kontakt(int p, string o, string s,
            int h, telefon t, telefon f)
        {
            plz = p;
            ort = o;
            strasse = s;
            hausnummer = h;
            tel = t;
            fax = f;
        }

        /* Methode */
        public string aus()
        {
            return (strasse + " " + hausnummer +
                "\n" + plz + " " + ort + "\nTel: " +
                tel.aus() + "\nFax: " + fax.aus());
        }
    }
}
