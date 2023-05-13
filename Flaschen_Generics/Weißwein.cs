using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flaschen_Generics
{
    internal class Weißwein:Getraenke
    {

        public string Herkunft()
        {
            return herkunft;
        }
        public string Information()
        {
            return description;
        }
    }
}
