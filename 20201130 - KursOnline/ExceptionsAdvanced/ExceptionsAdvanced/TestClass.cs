using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAdvanced
{
    public class TestClass
    {
        public void Calculate(int z1, int z2)
        {
            if(z1 == 0) //Exception künstlich auslösen
            {
                //throw new ArgumentException("z1 oder s2 ist 0. Dies ist nicht erlaubt!");
                throw new CalculationImpossibleException("z1");
            }

            if (z2 == 0) //Exception künstlich auslösen
            {
                //throw new ArgumentException("z1 oder s2 ist 0. Dies ist nicht erlaubt!");
                try
                {
                    throw new CalculationImpossibleException("z2");
                }
                catch (Exception)
                {

                    Console.WriteLine("z2 hat ein ungültiger Parameter");
                }

                
            }

            Console.WriteLine("Berechnung gestartet ... ");

        }
    }
}
