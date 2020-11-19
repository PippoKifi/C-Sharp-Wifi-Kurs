using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    class Plane : Vehicle
    {
        //ToDo class Plane Implementieren
        private string _producer;
        private string _model;
        private Plane_drives _antrieb;
        private int _numberOfEngines;

        public string Producer
        {
            get { return _producer; }
            set { _producer = value; }
        }

       public Plane() : base()
        {

        }


        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int NumberOfEngines
        {
            get { return _numberOfEngines; }
            set { _numberOfEngines = value; }
        }

        public Plane_drives Antrieb
        {
            get { return _antrieb; }
            set { _antrieb = value; }
        }



    }
}
