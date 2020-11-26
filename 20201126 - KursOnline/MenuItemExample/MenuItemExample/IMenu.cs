using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public interface IMenu
    {
        int Count { get;  }

        void Add(IMenueItem menuItem);
        void Remove(IMenueItem imenuItem);
        void Display(int wigth);
        void SelectItem(int item);
    }
}
