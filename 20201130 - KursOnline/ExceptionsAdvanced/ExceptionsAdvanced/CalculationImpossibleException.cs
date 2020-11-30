using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAdvanced
{
    //Abgeleitet Exception Klassen sollen immer mit 'Exception' enden
    //Sie muss immer von 'Exception' abgeleitet sein
    public class CalculationImpossibleException : Exception

    {
        private string _invalidParameter;


    public CalculationImpossibleException(string InvalidParameter)
        : base()
        {
            _invalidParameter = InvalidParameter;
        }  
        

        public override string Message
        {
            get
            {
                return $"Parameter '{_invalidParameter}' hat einen ungültigen inhalt";
            }
        }
               
    }
}

