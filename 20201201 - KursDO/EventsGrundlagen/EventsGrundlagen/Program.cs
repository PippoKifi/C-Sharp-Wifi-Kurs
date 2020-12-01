using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsGrundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("SuperCar VW", 220);
            //myCar

            do
            {
                Console.WriteLine(myCar);
                myCar.SpeedUp(20);

            } while (myCar.State != State.Exploded);
                

        }
    }
}
