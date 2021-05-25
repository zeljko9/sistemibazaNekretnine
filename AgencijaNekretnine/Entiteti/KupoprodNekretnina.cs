using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class KupoprodNekretnina : Nekretnina
    {
        public virtual int IDkpn { get; set; }

        public KupoprodNekretnina() { }
    }
}
