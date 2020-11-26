using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Grundlagen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hat nichts mit Objekt-Orientierung zu tun

            //int[] meineZahlen = new int[5];
            //meineZahlen[0] = -1;
            //meineZahlen[1] = -1;
            //meineZahlen[2] = -1;
            //meineZahlen[3] = -1;

            //for (int i = 0; i < meineZahlen.Length; i++)
            //{

            //}


            int[] meineZahlen = InitArray(15, -1);

            double[] meineZahlenGeneric = InitArrayGeneric<double>(10, 1.99);
            DateTime[] geburtstage = InitArrayGeneric<DateTime>(10, DateTime.Now);

            List<int> meineZahlenListe = new List<int>();
     
        }



        /// <summary>
        /// Automatische Array Initialisierung
        /// </summary>
        /// <param name="elemetCount"></param>
        /// <param name="initValue"></param>
        /// <returns></returns>
        static int[] InitArray(int elemetCount, int initValue)
        {
            int[] tmpArray = new int[elemetCount];
            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }
            return tmpArray;
        }

        /// <summary>
        /// Generics ermöglicht einen variablen Datentyp (Generische Methode)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="elemetCount"></param>
        /// <param name="initValue"></param>
        /// <returns></returns>
        static T[] InitArrayGeneric<T>(int elemetCount, T initValue)
        {
            T[] tmpArray = new T[elemetCount];
            for (int i = 0; i < tmpArray.Length; i++)
            {
                tmpArray[i] = initValue;
            }
            return tmpArray;
        }

    }
}
