using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class EmptyItem : IMenueItem
    {

        public EmptyItem()
        {
            //Nothing to do -> Standard Konstruktor 
        }

        public string Descriprion
        {
            get { return string.Empty;  }
        }

        public char Code
        {
            get { return ' '; }
        }


        public void Display(int width)
        {
            Console.WriteLine();
        }
    }
}
