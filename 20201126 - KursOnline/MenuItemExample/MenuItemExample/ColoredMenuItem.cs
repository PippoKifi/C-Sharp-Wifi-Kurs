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
        private ConsoleColor _itemcolor;

        //TODO Konstruktor anlegen
        ColoredMenuItem(string descriprion, char code, ConsoleColor itemcolor)
            : base(descriprion, code)
        {
            _itemcolor = itemcolor;
        }

        public ConsoleColor Itemcolor
        {
            get { return _itemcolor;  }
        }


        public override void Display(int width)
        {
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = _itemcolor;

            base.Display(width);
            
            Console.ForegroundColor = oldColor;
        }

    }
}
