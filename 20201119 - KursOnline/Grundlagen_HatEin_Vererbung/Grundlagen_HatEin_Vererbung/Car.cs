using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
   public class Car : Vehicle
    {
        private int _powerInPS;
        private int _constructioYear;


       public Car(string model, string descrition, int maxSpeed, int gewicht, int seats, int powerInPS, int constructioYear)
            :base(model, descrition, maxSpeed, gewicht, seats)
        {
            _powerInPS =  powerInPS;
            _constructioYear = constructioYear;
        }


        public int ConstructioYear
        {
            get { return _constructioYear; }
            set { _constructioYear = value; }
        }

        public int PowerInPS
        {
            get { return _powerInPS; }
            set { _powerInPS = value; }
        }

        public override string GetInfoString()
        {
            return base.GetInfoString() +
                $"\nPowerInPS: {_powerInPS}\nConstructioYear: {_constructioYear}";
        }

        public override string Drive(bool increase, int speedControl)
        {
            return base.Drive(increase, speedControl) + " - Aus class Car aufgerufen";

        }

    }
}
