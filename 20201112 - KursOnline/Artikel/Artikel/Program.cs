using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArtikel
{
    class Program
    {
        static void Main(string[] args)
        {

            Artikel MeinArtikel = new Artikel("");
            Console.WriteLine(MeinArtikel.GetInfoString());

        }
    }
}
