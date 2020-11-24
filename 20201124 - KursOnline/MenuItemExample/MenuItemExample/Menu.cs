using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    class Menu : IMenu
    {
        public int Count => throw new NotImplementedException();

        public void Add(IMenueItem menuItem)
        {
            throw new NotImplementedException();
        }

        public void Display(int wigth)
        {
            throw new NotImplementedException();
        }

        public void Remove(IMenueItem imenuItem)
        {
            throw new NotImplementedException();
        }
    }
}
