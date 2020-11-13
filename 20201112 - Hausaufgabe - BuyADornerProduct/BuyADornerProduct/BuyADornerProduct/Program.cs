using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.ToolLibrary.ConsoleIo;

namespace BuyADornerProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            DornerOnlineStore BuyADornerProduct = new DornerOnlineStore(ConsoleTools.GetString("Wie ist dein Account Name?"), (ConsoleTools.GetString("Wie ist das Kennwort?"))); //Ich möchte ein Dorner Produkt kaufen

        }
    }
}
