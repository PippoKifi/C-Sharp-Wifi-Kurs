
namespace Grundlagen_HatEin_Vererbung
{
    class Plane : Vehicle
    {
        //ToDo class Plane Implementieren
        private Plane_Drives _driveTechnology;
        private int _numberOfEngines;
        private Plane_Producer _producer;

        public Plane(string model, string descrition, int maxSpeed, Plane_Drives antrieb,int numberOfEngines, Plane_Producer producer) 
            : base(model, descrition, maxSpeed)
        {
            _driveTechnology = antrieb;
            _numberOfEngines = numberOfEngines;
            _producer = Producer;
        }

        public Plane_Producer Producer
        {
            get { return _producer; }
        }

        public Plane_Drives DriveTechnology
        {
            get { return _driveTechnology; }
        }

        public int NumberOfEngines
        {
            get { return _numberOfEngines; }
        }

        public string SpeedControl(int amount)
        {
            maxSpeed + amount
            return $"Akt. Speed {}";
        }

    }
}
