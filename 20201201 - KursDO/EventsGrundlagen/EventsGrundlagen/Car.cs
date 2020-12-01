using System;

namespace EventsGrundlagen
{

    public delegate void CarExplodesHandler(int currentSpeed, int maxSpeed);

    public class Car
    {
        private string _description;
        private int _maxSpeed;
        private int _currentSpeed;
        private State _state;

        public event CarExplodesHandler CarExploded;
        //Event (Observer-Patterm) kann von mehrere "abbonenten" verwendet werden
        //Diese werden dann benachricht (wie ein Zeitungsaustrager)


        public Car(string description, int maxSpeed)
        {
            _description = description;
            _maxSpeed = maxSpeed;
            _state = State.Normal;
        }

        public State State
        {
            get { return _state; }
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