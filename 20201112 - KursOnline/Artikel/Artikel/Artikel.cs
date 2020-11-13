using Artikel;
using System;

namespace MyArtikel
{
    public class Artikel
    {

        //#### Spezification:
        //> Keine Consolen angaben!!!
        //#### Spezification Ende

        //Interne eigenschaften
        private string _bezeichung;
        private Guid _code;
        private int _preis_euro;
        private ArtikelStatus _artikelStatus;

        //Konstruktor
        public Artikel()
        {
            _code = Guid.NewGuid();
            _preis_euro = 0;
            _artikelStatus = ArtikelStatus.Unknown;
        }

        //Eigenschaften (Gekapsel)
        public string Bezeichung
        {
            get 
            {
                return _bezeichung;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _bezeichung = value;
                }
            }
        }

        public Guid Code 
        {
            get 
            {
                return _code;
            }
            set
            {
                //if (!string.IsNullOrWhiteSpace(value))
                //{
                _code = value;
                //}
            }
        }


        //GetInfoString()

    }
}