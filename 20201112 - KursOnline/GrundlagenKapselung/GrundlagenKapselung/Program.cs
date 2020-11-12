using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrundlagenKapselung
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car = new Auto();
            car.DisplayInfos();

            for (int i = 0; i < 5; i++)
            {
                car.SpeedUp(+10);
                car.DisplayInfos();
            }

            Console.WriteLine($"Status of {car.Type} |  ");

            while (car.CurrentSpeed < 100)
            {
                car.SpeedUp(10);
                Console.WriteLine($"Status of {car.Type} |  ");
                Thread.Sleep(1000);
            }

        }
    }
}
