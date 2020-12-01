using System;

namespace EventsGrundlagen
{
    public class Car
    {
        private string _description;
        private int _maxSpeed;
        private int _currentSpeed;
        private State _state;

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
        }
        public override string ToString()
        {
            return $"{_description} = [{_currentSpeed}/{_maxSpeed} km/h]";
        }

    }
}