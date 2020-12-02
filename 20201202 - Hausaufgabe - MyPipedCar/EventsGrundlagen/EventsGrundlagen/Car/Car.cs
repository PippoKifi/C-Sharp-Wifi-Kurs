using System;

namespace MyPimpedCar
{

    public delegate void CarExplodesHandler(int currentSpeed, int maxSpeed);

    public class Car
    {
        private string _description;
        private int _maxSpeed;
        private int _currentSpeed;
        private CarState _state;
        private EngineState _engineStatus;


        private Engine MyEngine;

        public event CarExplodesHandler CarExploded;
        //Event (Observer-Patterm) kann von mehrere "abbonenten" verwendet werden
        //Diese werden dann benachricht (wie ein Zeitungsaustrager)


        //Konstruktor
        public Car(string description, int maxSpeed)
        {
            _description = description;
            _maxSpeed = maxSpeed;
            _state = CarState.Normal;
        }

        public CarState State
        {
            get { return _state; }
         }

        public EngineState EngineStatus
        {
            get { return _engineStatus; }
            set { _engineStatus = value; }
        }


        internal void SpeedUp(int delta)
        {
            _currentSpeed += delta;
            if(_currentSpeed > _maxSpeed)
            {
                //_state = State.Exploded;

                //Ereignis abfeuern
                if(CarExploded != null) //Immer prüfen ob sich jemand dafür interessiert (Sonst Exceprion!)
                {
                    CarExploded(_currentSpeed, _maxSpeed);
                }
            }
        }
        public override string ToString()
        {
            return $"{_description} = [{_currentSpeed}/{_maxSpeed} km/h]";
        }

    }
}