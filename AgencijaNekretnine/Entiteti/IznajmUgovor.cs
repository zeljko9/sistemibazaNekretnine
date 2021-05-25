using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class IznajmUgovor
    {
        public virtual int IDugpr { get; set; }
        public virtual IznajmNekretnina kupoprodNekretnine { get; set; }
        public virtual Vlasnik vlasnik { get; set; }
        public virtual FizickiKupac kupac { get; set; }
        public virtual Prodavac prodavac { get; set; }
        public virtual DateTime Datum_sklapanja { get; set; }
        public virtual DateTime Datum_isteka { get; set; }
        public virtual int Mesecna_zakupina { get; set; }
    }
}
