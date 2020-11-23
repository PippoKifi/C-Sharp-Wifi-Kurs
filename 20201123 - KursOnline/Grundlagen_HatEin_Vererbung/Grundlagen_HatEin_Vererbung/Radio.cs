using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    public class Radio
    {
        private double _frequency;
        private int _volume;
        private Power _powerState;


        public Radio()
        {
            _frequency = 90.5;
            _volume = 3;
            _powerState = Power.Off;
        }


        public int Volume
        {
            get { return _volume; }
            set { 
                //ToDo: Limit possible value between 0-10!
                _volume = value; 
            }
        }

        public double Frequency
        {
            get { return _frequency; }
            set 
            {
                //ToDo:Limit possible frequency range
                _frequency = value; 
            }
        }


        public string GetInfoString()
        {
            return $"Freq: {_frequency} MHz | Volume: {_volume}";
        }


        //TODO Macht euch gedancken darüber welche Status wann gesetzte werden dürfen

        public void SetPowerState(Power newPowerState)
        {
            switch (newPowerState)
            {
                case Power.On:
                    Console.WriteLine("Radio macht nun Musik: " + GetInfoString());
                    break;
                case Power.Off:
                    break;
                case Power.Suspend:
                    break;
                default:
                    break;
            }
        }


    }
}
