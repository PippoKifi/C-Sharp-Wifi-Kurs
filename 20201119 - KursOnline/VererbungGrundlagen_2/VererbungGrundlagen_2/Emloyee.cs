using System;

namespace VererbungGrundlagen_2
{
    public class Emloyee
    {
        private string _vorname;
        private string _nachname;
        //private Guid _id; 
        private Guid _id; //Snipped 'propfull'
        private DateTime _geburtsDatum;
        private decimal _gehalt;

        public Emloyee(string vorname, string nachname, DateTime geburtsDatum, decimal gehalt)
        {
            _vorname = vorname;
            _nachname = nachname;
            _geburtsDatum = geburtsDatum;
            _gehalt = gehalt;
            _id = Guid.NewGuid();
        }

        public decimal Gehalt
        {
            get { return _gehalt; }
            set { _gehalt = value; }
        }
        public Guid ID
        {
            get { return _id; }
        }        
        public string Name
        {
            get { return $"{_nachname} {_vorname}"; } //{return _name;}
            set { _nachname = value; }//{return _name;}
        }
        public DateTime GebDatum
        {
            get => _geburtsDatum;
        }
        
        public decimal GetCalculatedSalary()
        {
            return _gehalt;
        }

        public string GetInfoString()
        {
            return $"[{_id}]: {_vorname} {_nachname} - {_geburtsDatum.ToShortDateString()}";
        }

    }
}