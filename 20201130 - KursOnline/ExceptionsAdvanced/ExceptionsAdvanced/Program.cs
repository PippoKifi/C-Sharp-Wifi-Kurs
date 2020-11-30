using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var testClass = new TestClass();
            testClass.Calculate(5, 0);
        }
    }
}
