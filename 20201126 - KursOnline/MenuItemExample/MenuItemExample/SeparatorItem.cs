using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    class SeparatorItem : IMenueItem
    {
        //ToDo: User kann Separator zeichen aussuchen

        public string Descriprion => throw new NotImplementedException();

        public ConsoleKey Code => throw new NotImplementedException();

        public bool Selectable { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Visible { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display(int width)
        {
            throw new NotImplementedException();
        }
    }
}
