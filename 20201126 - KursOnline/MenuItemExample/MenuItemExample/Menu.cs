using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuItemExample
{
    public class Menu : IMenu
    {

        private List<IMenueItem> _items; //Kann dynamisch 
        //private SortedList<int, IMenueItem> _items2; //Wird immer Sortiert (Schnell)
        //private Dictionary<int, IMenueItem> _myDictionary; //Jeder Datensatz ist eindeütig

        public Menu()
        {
            _items = new List<IMenueItem>();
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public void Add(IMenueItem menuItem)
        {
            _items.Add(menuItem);
        }

        public void Remove(IMenueItem menuItem)
        {
            _items.Remove(menuItem);
        }

        public void Display(int wigth)
        {
            foreach (var menuItem in _items)
            {
                menuItem.Display(wigth);
            }
        }

        public IMenueItem SelectItem(string inputPrompt)
        {

            while (true)
            {
                Console.WriteLine(inputPrompt);
               var userInput = Console.ReadKey(true); //(rrue) -> Eingaben nicht darstellen

                foreach (var menuItem in _items)
                {
                    if (userInput.KeyChar == menuItem.Code)
                    {
                        Console.WriteLine($"Ihre Auswahl war {menuItem}");
                        return menuItem;
                    }
                }

                Console.WriteLine("Ungültige Eingabe!");
            }

            
            
        }
    }
}
