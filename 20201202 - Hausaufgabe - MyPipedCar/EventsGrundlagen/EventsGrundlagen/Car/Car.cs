using EventsGrundlagen;
using System;

namespace MyPimpedCar
{

    public delegate void CarExplodesHandler(int currentSpeed, int maxSpeed);



    public class Car
    {
        private string _description;
        private int _currentSpeed;
        private CarState _state;
        private Engine _myEngine;
        private Radio _myRadio;

        public event CarExplodesHandler CarExploded;
        //Event (Observer-Patterm) kann von mehrere "abbonenten" verwendet werden
        //Diese werden dann benachricht (wie ein Zeitungsaustrager)

        //#################################
        //########## Konstruktor ##########
        public Car(string description, Engine engine)
        {
            _description = description;
            _myEngine = engine;
            _state = CarState.Normal;
        }

        //Auto mit Radio
        public Car(string description, Engine engine, Radio myradio)
        {
            _description = description;
            _myEngine = engine;
            _state = CarState.Normal;
            _myRadio = new Radio();
        }

        public Radio MyRadio
        {
            get { return _myRadio; }
            set { _myRadio = value; }
        }

        public CarState State
        {
            get { return _state; }
         }

        public Engine MyEngine
        {
            get { return _myEngine; }
            set { _myEngine = value; }
        }

        //#################################
        //########## Methoden ##########
        internal void SpeedUp(int delta)
        {
            _currentSpeed += delta;
            if(_currentSpeed > _myEngine.MaxSpeed)
            {
                //_state = State.Exploded;

                //Ereignis abfeuern
                if(CarExploded != null) //Immer prüfen ob sich jemand dafür interessiert (Sonst Exceprion!)
                {
                    CarExploded(_currentSpeed, _myEngine.MaxSpeed);
                }
            }
        }
        public override string ToString()
        {
            return $"{_description} = [{_currentSpeed}/{_myEngine.MaxSpeed} km/h]";
        }


        public void SwitchOnOff(bool comand)
        {
            if (comand)
            {
                _myEngine.EngineState.Off;


            }
        }

    }
}