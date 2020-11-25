using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class EmptyItem : IMenueItem
    {
        public string Descriprion => throw new NotImplementedException();
        public char Code => throw new NotImplementedException();
        public int Order { set => throw new NotImplementedException(); }
        public bool Action { set => throw new NotImplementedException(); }

        public void Display(int width)
        {
            throw new NotImplementedException();
        }
    }
}
