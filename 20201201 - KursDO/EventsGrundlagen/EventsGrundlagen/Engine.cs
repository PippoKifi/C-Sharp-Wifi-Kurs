namespace EventsGrundlagen
{
    public class Engine
    {
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        private EngineState _engineStatus;

    }
}