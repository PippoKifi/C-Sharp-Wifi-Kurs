﻿using System;
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
            Artikel meinArtikel = new Artikel("Die Bibel", 200);
            Console.WriteLine(meinArtikel.GetInfoString());
        }
    }
}
