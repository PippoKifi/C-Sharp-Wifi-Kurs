using System;

namespace KonsoleStartparameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double summe = 0;

            for (i = 0; i < args.Length; i++)
                Console.WriteLine(i + ": " + args[i]);

            for (i = 0; i < args.Length; i++)
            {
                try
                {
                    summe += Convert.ToDouble(args[i]);
                }
                catch
                {
                }
            }

            Console.WriteLine("Summe: " + summe);
        }
    }
}
