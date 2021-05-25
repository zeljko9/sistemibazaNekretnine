using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Nekretnina
    {
        public virtual int IDNekretnina { get; set; }
        public virtual String Ulica { get; set; }
        public virtual int Broj { get; set; }
        public virtual int Sprat { get; set; }
        public virtual int Cena { get; set; }
        public virtual int Starost { get; set; }
        public virtual DateTime DatumIzgradnje { get; set; }
        public virtual String TipNekretnine { get; set; }
        public virtual int BrKupatila { get; set; }

        public virtual Kvart PripadaKvartu { get; set; }

        public Nekretnina()
        {

        }
    }

    public class StambKupovina 
    {
        public virtual KupoprodNekretnina Kpn { get; set; }

        public StambKupovina() { }
    }
    public class StambIznajm 
    {
        public virtual IznajmNekretnina Izn { get; set; }

        public StambIznajm() { }
    }
    public class PoslvKupovina
    {
        public virtual KupoprodNekretnina Kpn { get; set; }

        public PoslvKupovina() { }
    }
    public class PoslvIznajm 
    {
        public virtual IznajmNekretnina Izn { get; set; }

        public PoslvIznajm() { }
    }
}
