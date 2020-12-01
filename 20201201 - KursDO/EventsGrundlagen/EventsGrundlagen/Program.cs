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

            myCar.CarExploded += MyCar_CarExploded; //Mit '+' an dem Event ANMELDEN
                                                    //Mit '-' von Event ABMELDEN

            do
            {
                Console.WriteLine(myCar);
                myCar.SpeedUp(20);
                                

            } while (myCar.State != State.Exploded);


            //Vom Ereignis Ebmelden
            //myCar.CarExploded -= MyCar_CarExploded; //Event ABMELDEN

        }

        private static void MyCar_CarExploded(int currentSpeed, int maxSpeed)
        {
            Console.WriteLine("Leider ist das Auto Explodiert!");
        }
    }
}
