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
        int _order;
        bool _action;

        //TODO Konstrucktor anlegen?
        MenuItem(string descriprion, char code, int order, bool action)
        {
            _description = descriprion;
            _code = code;
            _order = order;
            _action = action;
        }



        //Warum Public?
        public string Descriprion
        {
            set { _description = value;  }
        }
        public char Code
        {
            get { return value;  }
        }
        public int Order 
        {
            set { _order = value;  } 
        }
        public bool Action
        {
            set { }
        }

        string IMenueItem.Descriprion => throw new NotImplementedException();

        public void Display(int width)
        {
            throw new NotImplementedException();
        }
    }
}
