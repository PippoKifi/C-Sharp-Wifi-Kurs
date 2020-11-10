using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WertUndVerweisTypen
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();

            myBook.Title = "Die unendliche Geschichte";
            myBook.Author = "Michael Ende";
            myBook.Price = 15.99m;

            Book myNewBook = myBook;

            myBook.Title = "Dummy Title";

            DisplayBookInfos(myBook);
            DisplayBookInfos(myNewBook);
        }

        static void DisplayBookInfos(Book bookToDisplay)
        {
            Console.WriteLine($"'{bookToDisplay.Title.ToUpper()}' von {bookToDisplay.Author} => EUR {bookToDisplay.Price}");
        }
    }
}
