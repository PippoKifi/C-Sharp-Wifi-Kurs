using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionMenuExample
{
    public interface IMenu<T>
    {
        int Count { get;  }

        void Add(IMenuItem<T> menuItem);
        void Remove(IMenuItem<T> imenuItem);
        void Display(int wigth);
        IMenuItem<T> SelectItem(string selection);
        
    }
}
