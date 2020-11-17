 using Artikel;
using System;

namespace MyArtikel
{
    public class Artikel
    {
        //#### Spezification:
        //> Keine Consolen angaben!!!
        //#### Spezification Ende

        //Interne Eigenschaften / Felder
        private string _bezeichung;
        private Guid _code;
        private int _preis_euro;
        private ArtikelStatus _artikelStatus;

        //Konstruktor
        public Artikel(string buchBezeichnung, int preis)
        {
            _bezeichung = buchBezeichnung;
            _code = Guid.NewGuid();
            _preis_euro = preis;
            _artikelStatus = ArtikelStatus.Unknown;
        }


        //Eigenschaften / Property (Gekapselung)
        //Nur für den gebrauch von aussen gedacht!
        public string Bezeichung

        {
            get 
            {
                return _bezeichung;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value)) //'value' ist immer derselbe typ von der Eigenschaft
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
        public string GetInfoString()
        {
            string returnString = "";
        return returnString = "Bezeichnung : " + _bezeichung + " | Code: " + _code + " | Preis (Euro): " + _preis_euro + " | Artikel Status: " + _artikelStatus;
        }
        
            


        //Test Artikel



    }
}