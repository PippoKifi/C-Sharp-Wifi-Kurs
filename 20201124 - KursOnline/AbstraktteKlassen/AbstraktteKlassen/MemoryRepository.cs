using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraktteKlassen
{
    class MemoryRepository : DataRepository
    {

        public MemoryRepository(int maxSite)
        
            :base("RAM Repository", maxSite)
        {
        
        }

        public override string Read()
        {
            throw new NotImplementedException();
        }

        public override void Write(string data)
        {
            throw new NotImplementedException();
        }
    }
}
