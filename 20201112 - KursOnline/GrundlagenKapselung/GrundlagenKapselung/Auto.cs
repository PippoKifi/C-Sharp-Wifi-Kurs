using System;
using Wifi.ToolLibrary.ConsoleIo;

namespace GrundlagenKapselung
{
    public class Auto
    {
        //EIGENSCHAFTEN (Feldern -> Niemals Öffentlich!)
        private string _type;
        private string _description;
        private int _maxSpeed;
        private int _currentSpeed;

        //##### KONSTRUKTOR
        public Auto()
        {
            _type = "Opel Astra";
            _description = "Ein std. Fahrzeug für die Familie";
            _maxSpeed = 175;
            _currentSpeed = 0;
        }
        public Auto(string type, string description, int maxSpeed)
        {
            _type = type;
            _description = description;
            _maxSpeed = maxSpeed;
            _currentSpeed = 0;
        }
        public Auto(string type, string description)
        {
            _type = type;
            _description = description;

            _maxSpeed = 175;
            _currentSpeed = 0;
        }

        //##### EIEGNSCHAFTEN Zugriffs & änderungs-Methoden (Get \ Set)
        //Zustand informationen kapseln und nach aussen kommunizieren (Privat macht keine sinn!)
        //Set-Block weglassen -> Schreibgeschützt!
        //Im hintergrund erstellt VS Methoden 
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _type = value;
                }
            }
        }
        public string Description
        {
            get
            {
                return _description;
            }
        }
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
        }
        public int CurrentSpeed
        {
            get
            {
                return _currentSpeed;
            }
        }

        public void SpeedUp(int delta)
        {
            if (_currentSpeed + delta > _maxSpeed || _currentSpeed + delta < 0)
            {
                ConsoleTools.DisplayColoredMessage($"ERROR: Die aktuelle Geschwindigkeit kann nicht um {delta} verändert werden.", ConsoleColor.Red);
                return;
            }

            //update current speed
            _currentSpeed += delta;
        }

        public void DisplayInfos()
        {
            ConsoleTools.DisplayColoredMessage($"{_type} - {_description}");
            ConsoleTools.DisplayColoredMessage($"Max. Speed: {_maxSpeed} km/h Current Speed: {_currentSpeed} km/h");
            Console.WriteLine();
        }
    }
}