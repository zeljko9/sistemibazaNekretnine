using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Lice
    {
        public virtual string JMBG_PIB { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual String Adresa { get; set; }
        public virtual String TipLica { get; set; }

        //1:N veza sa TELEFON, LICE ima VISE TELEFONA
        public virtual IList<Telefon> TelefoniLica { get; set; }


        public Lice()
        {
            this.TelefoniLica = new List<Telefon>();
        }
    }

    public class PravniVlasnik:Lice
    {

        public virtual Vlasnik jeVlasnik { get; set; }
        public PravniVlasnik()
        {
        }
    }

    public class PravniKupac:Lice
    {
        public virtual Kupac jeKupac { get; set; }
        public PravniKupac()
        {
        }

        public static explicit operator PravniKupac(Kupac v)
        {
            throw new NotImplementedException();
        }
    }
    public class FizickiKupac : Lice
    {  //public virtual int JMBG_PIB { get; set; }
        public virtual Kupac jeKupac { get; set; }
        public FizickiKupac()
        { 
        }
    }

    public class FizickiVlasnik:Lice
    {
        public virtual Vlasnik jeVlasnik { get; set; }
        public FizickiVlasnik()
        {
        }
    }
    // public class PravniKupac : Lice { }
    /*public class FizickoLice : Lice
    {

    }

    public class PravnoLice : Lice
    {

    }*/
}
