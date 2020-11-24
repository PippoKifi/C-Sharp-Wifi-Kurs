namespace AbstraktteKlassen
{
    public abstract class DataRepository
    //abstract = Klasse kann nicht instanziert werden!
    {
        private string _name;
        private int _maxSize;

        public DataRepository(string name, int maxSize)
         {
            _name = name;
            _maxSize = maxSize;
         }

        public int MaxSize
        {
            get { return _maxSize; }
            private set { _maxSize = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public abstract void Write(string data);
        //Abstracte methode
        //Es gibt keine implementierug dafür

        public abstract string Read();
        //Abstracte methode
        //Es gibt keine implementierug dafür



    }
}