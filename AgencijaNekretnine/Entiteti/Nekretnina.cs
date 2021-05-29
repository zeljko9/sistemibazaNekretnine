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

        public virtual IList<Oprema> oprema { get; set; }
        public virtual Kvart PripadaKvartu { get; set; }

        public Nekretnina()
        {
            this.oprema = new List<Oprema>();
        }

        public Nekretnina(int iDNekretnina, string ulica, int broj, int sprat, int cena, int starost, DateTime datumIzgradnje, string tipNekretnine, int brKupatila, /*IList<Oprema> oprema*/Kvart pripadaKvartu)
        {
            IDNekretnina = iDNekretnina;
            Ulica = ulica;
            Broj = broj;
            Sprat = sprat;
            Cena = cena;
            Starost = starost;
            DatumIzgradnje = datumIzgradnje;
            TipNekretnine = tipNekretnine;
            BrKupatila = brKupatila;
           // this.oprema = oprema;
            PripadaKvartu = pripadaKvartu;
        }
    }

    public class StambKupovina: Nekretnina
    {
        public virtual KupoprodNekretnina Kpn { get; set; }

        public StambKupovina() { }
    }
    public class StambIznajm : Nekretnina
    {
        public virtual Nekretnina Izn { get; set; }

        public StambIznajm() { }
    }
    public class PoslvKupovina : Nekretnina
    {
        public virtual KupoprodNekretnina Kpn { get; set; }
       // public virtual IList<Oprema> oprema { get; set; }

        public PoslvKupovina() 
        {
            //this.oprema = new List<Oprema>();
        }
    }
    public class PoslvIznajm : Nekretnina
    {
       // public virtual IList<Oprema> oprema { get; set; }
        public virtual IznajmNekretnina Izn { get; set; }

        public PoslvIznajm()
        {
           // this.oprema = new List<Oprema>();
        }
    }
}
