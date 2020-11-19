using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VererbungGrundlagen_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales susi = new Sales("Susi", "Sales", new DateTime(2000, 5, 19), 1500.8m, 0.15);
            Console.WriteLine(susi.GetInfoString());

            Manager manfred = new Manager("Manfred", "Manager", new DateTime(2000, 5, 19), 15, 1500.8m);
            Console.WriteLine(manfred.GetInfoString());

            Console.WriteLine(manfred.AddShares(20));
            Console.WriteLine(manfred.RemoveShares(30));

        }
    }
}
