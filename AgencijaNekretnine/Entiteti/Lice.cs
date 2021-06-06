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

        public Lice(string jMBG_PIB, string ime, string prezime, string adresa, string tipLica, IList<Telefon> telefoniLica)
        {
            JMBG_PIB = jMBG_PIB;
            Ime = ime;
            Prezime = prezime;
            Adresa = adresa;
            TipLica = tipLica;
            TelefoniLica = telefoniLica;
        }
    }

   

    public class PravniKupac:Lice
    {
        public virtual Kupac jeKupac { get; set; }
        public PravniKupac()
        {
        }

        public PravniKupac(Lice lice) : base(lice.JMBG_PIB, lice.Ime, lice.Prezime, lice.Adresa, lice.TipLica, lice.TelefoniLica)
        {
        }
    }
    public class FizickiKupac : Lice
    {  //public virtual int JMBG_PIB { get; set; }
        public virtual Kupac jeKupac { get; set; }
        public FizickiKupac()
        { 
        }

        public FizickiKupac(Lice lice) : base(lice.JMBG_PIB, lice.Ime, lice.Prezime, lice.Adresa, lice.TipLica, lice.TelefoniLica)
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
