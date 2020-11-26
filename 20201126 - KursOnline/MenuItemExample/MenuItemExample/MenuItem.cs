using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
   public class MenuItem : IMenueItem
    {
        //TODO Kapseln (Lokale Variabeln anlegen)?
        string _description;
        char _code;

        //TODO Konstrucktor anlegen?
        public MenuItem(string descriprion, ConsoleKey code)
        {
            _description = descriprion;
            _code = code.ToString().ToLower()[0]; //Immer nur klene Buchstaben für die Prüfung
        }

        //Warum Public?
        public string Descriprion
        {
            get { return _description ;  }
        }
        public ConsoleKey Code
        {
            get { return ConsoleKey.Spacebar;  }
        }

        public virtual void Display(int width)
        {
            //Daten laden ................L
            //Programm beenden ...........Q
            Console.Write($"{_description} {new string('.',width - _description.Length)}");
            Console.Write($"Was für ein Menü wünschen sie? Bitte treffen sie eine auswahl");
        }
    }
}
