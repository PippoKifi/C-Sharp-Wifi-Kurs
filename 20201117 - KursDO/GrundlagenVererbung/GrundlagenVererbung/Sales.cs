using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenVererbung
{
    class Sales : Emloyee //Ableitung - Die Klasse 'Sales' erbt jetzt die Klasse 'Emloyee'
    {
        private Double _provision;

        //Konstruktor | Instanzieren
        public Sales(string vorname, string nachname, DateTime geburtsDatum, decimal gehalt,double _provision) 
            : base(vorname, nachname, geburtsDatum, gehalt)
        {
            _provision = Provision;
        }


        public Double Provision
        {
            get { return _provision; }
            set { _provision = value; }
        }

    }
}
