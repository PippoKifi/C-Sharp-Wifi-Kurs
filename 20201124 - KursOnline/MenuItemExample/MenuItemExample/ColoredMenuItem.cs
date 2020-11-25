using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class ColoredMenuItem : MenuItem
    {

        //TODO Lokale Variablen anlegen
        ConsoleColor _itemcolor;

        //TODO Konstruktor anlegen
        ColoredMenuItem(string descriprion, char code, int order, bool action, ConsoleColor itemcolor )
            : base (descriprion, code, order, action)
        {
            _itemcolor = itemcolor;
        }

        public override void Display(int width)
        {
            throw new NotImplementedException();
        }

    }
}
