using System;

namespace Grundlagen_HatEin_Vererbung
{
    public class Vehicle
    {
        private string _model; //'Propfull' shortcut verwenden
        private string _description;
        private vehicleState _state;
        private int _maxSpeed;
        private int _gewicht;
        private int _seats; //Sitzplätze
        private int _targetSpeed;
        private int _aktSpeed;

        private Radio boseRadio;

        //'ctor' shortcut
        /// <summary>
        /// Standard Konstruktor
        /// </summary>
        public Vehicle() //Standard Konstruktor (Fahhrad)
        {
            _model = "Fahhrad M+F";
            _description = "Unisex Fahhrad";
            _state = vehicleState.Unknown;
        }

        /// <summary>
        /// Personalisierbahrer Konstruktor (2)
        /// </summary>
        /// <param name="Model">Was für ein Modell ist das</param>
        public Vehicle(string Model) //Konstruktor 2
        {
            _model = Model; 
        }

        /// <summary>
        /// Personalisierbahrer Konstruktor (3)
        /// </summary>
        /// <param name="model">Was für ein Modell ist es</param>
        /// <param name="descrition">Beschreibe ddas Fahrzeug</param>
        /// <param name="maxSpeed">Maximale geschwindigkeit</param>
        /// <param name="gewicht">Was ist das Gewicht</param>
        /// <param name="seats">Wie viel Sitzpläze gibt es</param>
        public Vehicle(string model, string descrition, int maxSpeed, int gewicht, int seats)  //Konstruktor 3
        {
            _model = model;
            _description = descrition;
            _state = vehicleState.Unknown;
            _maxSpeed = maxSpeed;
            _gewicht = gewicht;
            _seats = seats;
            _aktSpeed = 0;

            boseRadio = new Radio();
        }



        
        public string Description { get => _description;}
        public int MaxSpeed { get => _maxSpeed;}
        internal vehicleState State { get => _state; set => _state = value; }
        public int Gewicht { get { return _gewicht; } set { _gewicht = value; } }
        public int Seats { get { return _seats; } set { _seats = value; } }
        public int AktSpeed
        {
            get { return _aktSpeed; }
            private set
            {
                if (_aktSpeed > _maxSpeed) { _aktSpeed = _maxSpeed; }
                else if (_aktSpeed < 0) { _aktSpeed = 0; }
                else { _aktSpeed = value; }
            }
        }

        public virtual string GetInfoString()
        {
            return $"\n\n########## {_model} ||| {_description} ########## \nMax. Speed: {_maxSpeed}\nGewicht: {_gewicht}\nSitzplätze: {_seats}";
        }

        public virtual string Drive(bool increase, int speedControl)
        {
            string returnString = "";
            string bewegungsrichtung = "-";
            if (increase) { bewegungsrichtung = "+"; }


            if(_state == vehicleState.Locked || _state == vehicleState.Exploded || _state == vehicleState.Unknown)
            {
                returnString = $"FEHLER: Das Fahrzeug '{_model}' kann leider nicht um {bewegungsrichtung}{speedControl} bewegen werden (Fahrzeug Status: '{_state}'";
            }
            else
            {
                AktSpeed += speedControl;
                returnString += AktSpeed;
            }
            
            return returnString;

        } 

    }
}
