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
        public MenuItem(string descriprion, char code)
        {
            _description = descriprion;
            _code = code;
        }

        //Warum Public?
        public string Descriprion
        {
            get { return _description ;  }
        }
        public char Code
        {
            get { return _code ;  }
        }

        public virtual void Display(int width)
        {
            //Daten laden ................L
            //Programm beenden ...........Q
            Console.Write($"{_description} {new string('.',width - _description.Length)}");

        }
    }
}
