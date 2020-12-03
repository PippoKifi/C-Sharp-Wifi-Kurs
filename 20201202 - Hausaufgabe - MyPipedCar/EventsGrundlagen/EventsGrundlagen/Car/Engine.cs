using EventsGrundlagen;

namespace MyPimpedCar
{
    public class Engine
    {
        private string _description;
        private int _maxSpeed;
        private EngineTyp _engineTyp;
        private EngineState _engineStatus;

        public Engine(string description, EngineTyp engineTyp, int maxSpeed)
        {
            _description = description;
            _engineTyp = engineTyp;
            _maxSpeed = maxSpeed;
            _engineStatus = EngineState.Off;
        }

        public EngineTyp EngineTyp
        {
            get { return _engineTyp; }
            set { _engineTyp = value; }
        }

        public EngineState EngineStatus
        {
            get { return _engineStatus; }
            set { _engineStatus = value; }
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private EngineState _engineStatus;

    }
}