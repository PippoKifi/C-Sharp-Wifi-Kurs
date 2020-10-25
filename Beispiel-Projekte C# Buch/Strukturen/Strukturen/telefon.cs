namespace Strukturen
{
    struct telefon
    {
        public string vorwahl;
        public int nummer;

        /* Konstruktor */
        public telefon(string v, int n)
        {
            vorwahl = v;
            nummer = n;
        }

        /* Methode */
        public string aus()
        {
            return (vorwahl + "-" + nummer);
        }
    }
}
