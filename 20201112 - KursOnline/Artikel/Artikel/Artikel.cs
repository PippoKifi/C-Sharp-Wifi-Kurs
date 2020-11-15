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
        public Artikel(string gesuchterArtikel)
        {
            _bezeichung = gesuchterArtikel;
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
        public int Preis_euro
        {
            get
            {
                return _preis_euro;
            }
            set
            {
                //if (!string.IsNullOrWhiteSpace(value))
                //{
                _preis_euro = value;
                //}
            }
        }
        public ArtikelStatus ArtikelStatus
        {
            get
            {
                return _artikelStatus;
            }
            set
            {
                //if (!string.IsNullOrWhiteSpace(value))
                //{
                _artikelStatus = value;
                //}
            }
        }

        //Methode

        /// <summary>
        /// Liefert das Ergebniss nach außen
        /// </summary>
        /// <returns></returns>
        public string[] GetInfoString()
        {
            string[] infoToTheOutside = new string[4];
            infoToTheOutside[1] = _bezeichung;
            //infoToTheOutside[2] = _code;
            //infoToTheOutside[3] = _preis_euro;
            //infoToTheOutside[4] = _artikelStatus;

            return infoToTheOutside;
        }


        //Test Artikel



    }
}