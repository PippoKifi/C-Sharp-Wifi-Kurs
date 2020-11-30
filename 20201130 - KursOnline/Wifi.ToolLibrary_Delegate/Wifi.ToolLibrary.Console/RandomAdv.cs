using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.ToolLibrary
{
    public class RandomAdv : Random
    {

        //'ctor'
        public RandomAdv() 
        {

        }

        public RandomAdv(int Seed) : base (Seed)
        {

        }

        /// <summary>
        /// Generiert einen zufälligen String
        /// </summary>
        /// <param name="lenght">Definiert die länge von dem Zufälligem String</param>
        /// <returns></returns>
        public string NextString(int lenght)
        {
            //char[] myCharacterList = new char[20];
            //int zufallsIndex = this.Next(0, 66);
            //string zufallsString = string.Empty;
            //zufallsString += myCharacterList[zufallsIndex].ToString();
            //return zufallsString;

            string randomString = string.Empty;
            int randomChar = 0;
            for (int i = 0; i < lenght; i++)
            {
                int isUpperCase = this.Next(0, 2); // 0 = False | 1 = True
                if (isUpperCase == 0)
                {
                    randomChar = this.Next('a', 'z' + 1);
                }
                else
                {
                    randomChar = this.Next('A', 'Z' + 1 );
                }
                randomString += (char)randomChar;
            }
            return randomString;
        }

    }
}
