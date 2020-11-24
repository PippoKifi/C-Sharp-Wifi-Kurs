using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakteKlassen
{
    public interface IDataRepository //Intrface fangen immer mit 'I' an
    {
        //Interface Member IMMER PUBLIC + ABSTRACT

        //Interface hat immer nur Public elemente (deshalb muss es nicht definiert werden)
        // Jedes Member ist automatisch abstract (deshalb muss es nicht spezifisch declariert werden!)
        string Name { get; }
        
        int MaxSize { get; }

        void Write(string data);

        string Read();
    }
}
