
namespace Grundlagen_HatEin_Vererbung
{
    class Plane : Vehicle
    {
        //ToDo class Plane Implementieren
        private Plane_Drives _driveTechnology;
        private int _numberOfEngines;
        private Plane_Producer _producer;

        public Plane(string model, string descrition, int maxSpeed, int gewicht, int seats, Plane_Drives _driveTechnology,  int numberOfEngines, Plane_Producer producer) 
            : base(model, descrition, maxSpeed, gewicht, seats)
        {
            _driveTechnology = _driveTechnology;
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

        public override string GetInfoString()
        {
            return base.GetInfoString() +
                $"\nDriveTechnology: {_driveTechnology}\nNumberOfEngines: {_numberOfEngines}\nProducer: {_producer}";
        }

        public override string Drive(bool increase, int speedControl)
        {
            return base.Drive(increase, speedControl) + " - Aus class Plane aufgerufen";

        }


    }
}
