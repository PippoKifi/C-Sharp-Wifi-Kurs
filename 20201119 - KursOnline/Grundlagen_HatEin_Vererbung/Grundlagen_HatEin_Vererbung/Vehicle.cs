using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    public class Vehicle
    {
        private string _model; //'Propfull' shortcut verwenden
        private string _description;
        private vehicleState _state;
        private int _maxSpeed = 180;

        //'ctor' shortcut
        Vehicle() //Standard Fahhrad
        {
            _model = "Fahhrad M+F";
            _description = "Unisex Fahhrad";
            _state = vehicleState.Unknown;
        }
        //'ctor' shortcut
        Vehicle(string model, String descrition, int maxSpeed) //Änderbahrer Konstruktor 
        {
            _model = model;
            _description = descrition;
            _state = vehicleState.Unknown;
        }

        public Vehicle(string Model) {_model = Model;}
        public string Description { get => _description;}
        public int MaxSpeed { get => _maxSpeed;}
        internal vehicleState State { get => _state; set => _state = value; }

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
                Console.WriteLine($"FEHLER: FAS FZ {_model} kann sich leider nicht bewegen");
            }
            return "";
        } 

    }
}
