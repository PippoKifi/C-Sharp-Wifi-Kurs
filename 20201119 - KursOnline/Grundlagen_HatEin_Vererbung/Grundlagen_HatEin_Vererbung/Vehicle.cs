using System;

namespace Grundlagen_HatEin_Vererbung
{
    public class Vehicle
    {
        private string _model; //'Propfull' shortcut verwenden
        private string _description;
        private vehicleState _state;
        private int _maxSpeed = 180;
        private int _gewicht;


        //'ctor' shortcut
        public Vehicle() //Standard Fahhrad
        {
            _model = "Fahhrad M+F";
            _description = "Unisex Fahhrad";
            _state = vehicleState.Unknown;
        }

        //'ctor' shortcut
        public Vehicle(string model, string descrition, int maxSpeed) //Änderbahrer Konstruktor 
        {
            _model = model;
            _description = descrition;
            _state = vehicleState.Unknown;
        }


        public Vehicle(string Model) {_model = Model;}
        public string Description { get => _description;}
        public int MaxSpeed { get => _maxSpeed;}
        internal vehicleState State { get => _state; set => _state = value; }
        public int Gewicht { get { return _gewicht; } set { _gewicht = value; } }


        public string GetInfoString()
        {
            return $"{_model} - {_description}\nMax. Speed: {_maxSpeed}";
        }

        public string Drive()
        {
            if(_state == vehicleState.Unlocked)
            {
                Console.WriteLine($"{_model}");
            }
            else
            {
                Console.WriteLine($"FEHLER: Das Fahrzeug {_model}-{_description} kann leider nicht bewegen werden (Status: {_state})");
            }
            return "";
        } 

    }
}
