using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class KupoprodajniUgovor
    {
        public virtual int IDugkp { get; set; }
        public virtual Nekretnina kupoprodNekretnine { get; set; }
        public virtual Kupac kupac { get; set; }
        public virtual Prodavac prodavac { get; set; }
        public virtual DateTime Datum_transakcije { get; set; }
    }
}
