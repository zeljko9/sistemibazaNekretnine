using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine
{
    public class LiceBasic
    {
        public int JMBG_PIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public IList<TelefonBasic> listaTelefona { get; set; }

        public LiceBasic(int jmbg, string ime, string prez, string adresa)
        {
            this.JMBG_PIB = jmbg;
            this.Ime = ime;
            this.Prezime = prez;
            this.Adresa = adresa;
        }

        public LiceBasic() { this.listaTelefona = new List<TelefonBasic>(); }

    }

    public class FizickiKupacBasic : LiceBasic
    {
        public KupacBasic jeKupac { get; set; }
        public FizickiKupacBasic() { }

        public FizickiKupacBasic(int JMBG_PIB, string ime, string prezime, string adresa) : base(JMBG_PIB, ime, prezime, adresa) { }
    }

    public class PravniKupacBasic : LiceBasic
    {
        public KupacBasic jeKupac { get; set; }
        public PravniKupacBasic() { }

        public PravniKupacBasic(int jmbg,string ime,string prez, string adresa) : base(jmbg, ime, prez, adresa) { }
    }

    public class FizickiVlasnikBasic : LiceBasic 
    {
        public VlasnikBasic jeVlasnik { get; set; }
        public FizickiVlasnikBasic() { }
        public FizickiVlasnikBasic(int jmbg,string ime,string prez, string adr) : base(jmbg, ime, prez, adr) { }
    }

    public class PravniVlasnikBasic : LiceBasic
    {
        public VlasnikBasic jeVlasnik { get; set; }
        public PravniVlasnikBasic() { }
        public PravniVlasnikBasic(int jmbg,string ime,string prez,string adr) : base(jmbg, ime, prez, adr) { }
    }


    public class KupacBasic 
    {
        public int KupacID { get; set; }
        public KupacBasic() { }
        public KupacBasic(int id) { KupacID = id; }
    }

    public class VlasnikBasic 
    {
        public int VlasnikID { get; set; }
        public VlasnikBasic() { }
        public VlasnikBasic(int id) { VlasnikID = id; }
    }


    public class NekretninaBasic
    {
        public int IDNekretnina { get; set; }
        public string Ulica { get; set; }
        public int Broj { get; set; }
        public int Sprat { get; set; }
        public int Cena { get; set; }
        public int Starost { get; set; }
        public DateTime DatumIzgradnje { get; set; }

        public string TipNekretnine { get; set; }
        public int BrKupatila { get; set; }

        public IList<OpremaBasic> oprema { get; set; }
        public Kvart pripadaKvartu { get; set; }

        public NekretninaBasic() { this.oprema = new List<OpremaBasic>(); }

        public NekretninaBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup)
        {
            this.IDNekretnina = id;
            this.Ulica = ulica;
            this.Broj = br;
            this.Sprat = sprat;
            this.Cena = cena;
            this.Starost = star;
            this.DatumIzgradnje = dat;
            this.TipNekretnine = tip;
            this.BrKupatila = brkup;
        }
    }


   public class KupoprodNekretninaBasic:NekretninaBasic
    {
        public int IDKpn { get; set; }
        public KupoprodNekretninaBasic() { }
        public KupoprodNekretninaBasic(int id) { IDKpn = id; }
    }

    public class IznajmNekretninaBasic: NekretninaBasic
    {
        public int IDIzn { get; set; }
        public IznajmNekretninaBasic() { }
        public IznajmNekretninaBasic(int id) { this.IDIzn = id; }

    }

    public class StambKupovinaBasic : NekretninaBasic
    {
        public StambKupovinaBasic() { }
        public StambKupovinaBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup):base(id, ulica,  br,  sprat,  cena,  star,  dat,  tip, brkup) { }

    }

    public class StambIznajmBasic : NekretninaBasic 
    {
        public StambIznajmBasic() { }
        public StambIznajmBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup) : base(id, ulica, br, sprat, cena, star, dat, tip, brkup) { }
    }

    public class PoslvKupovinaBasic:NekretninaBasic
    {
        public PoslvKupovinaBasic() { }
        public PoslvKupovinaBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup) : base(id, ulica, br, sprat, cena, star, dat, tip, brkup) { }
    }

    public class PoslvIznajmBasic:NekretninaBasic
    {
        public PoslvIznajmBasic() { }
        public PoslvIznajmBasic(int id, string ulica, int br, int sprat, int cena, int star, DateTime dat, string tip, int brkup) : base(id, ulica, br, sprat, cena, star, dat, tip, brkup) { }
    }


    public class ZaposleniBasic
    {
        public int JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatZaposlenja { get; set; }
        public PoslovnicaBasic radiUPoslovnici { get; set; }


        public ZaposleniBasic() { }
        public ZaposleniBasic(int jmbg,string ime, string prez,DateTime dat)
        {
            this.JMBG = jmbg;
            this.Ime = ime;
            this.Prezime = prez;
            this.DatZaposlenja = dat;
        }
    }


    public class ProdavacBasic : ZaposleniBasic
    { 
        public IList<StrucnaSpremaBasic> strucneSpreme { get; set; }
        public IList<AgentBasic> Agenti { get; set; }

        public ProdavacBasic()
        {
            this.strucneSpreme = new List<StrucnaSpremaBasic>();
            this.Agenti = new List<AgentBasic>();
        }

        public ProdavacBasic(int jmbg, string ime, string prez, DateTime dat):base(jmbg, ime, prez, dat) { }

    }

    public class SefBasic:ZaposleniBasic
    {
        public DateTime datPostavljanja { get; set; }
        public PoslovnicaBasic sefujeNad { get; set; }

        public SefBasic() { }
        public SefBasic(int jmbg, string ime, string prez, DateTime dat):base(jmbg, ime, prez, dat) { }
    }



    public class OpremaBasic 
    {
        public int IDOprema { get; set; }
        public string NazivOpreme { get; set; }
        public NekretninaBasic pripadaNekretnini { get; set; }
        public OpremaBasic() { }
        public OpremaBasic(int id, string naziv)
        {
            this.IDOprema = id;
            this.NazivOpreme = naziv;
        }
    }


    public class TelefonBasic
    {
        public int IDTelefon { get; set; }
        public string brTel { get; set; }
        public LiceBasic pripadaLicu { get; set; }

        public TelefonBasic() { }

        public TelefonBasic(int id, string br)
        {
            this.IDTelefon = id;
            this.brTel = br;
        }
    }


    public class AgentBasic
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Procenat { get; set; }
        public string brTel { get; set; }
        public ProdavacBasic angazovanOd { get; set; }

        public AgentBasic() { }
        public AgentBasic(string ime, string prez, int proc, string br)
        {
            this.Ime = ime;
            this.Prezime = prez;
            this.Procenat = proc;
            this.brTel = br;
        }
    }
    public class PoslovnicaBasic 
    {
        public int IDPoslovnice { get; set; }
        public string Adresa { get; set; }
        public string RadnoVreme { get; set; }
        public SefBasic Sef { get; set; }
        public IList<ZaposleniBasic> listaZaposlenih { get; set; }
        public IList<KvartBasic> nagledaKvartove { get; set; }

        public PoslovnicaBasic() 
        {
            this.listaZaposlenih = new List<ZaposleniBasic>();
            this.nagledaKvartove = new List<KvartBasic>();
        }

        public PoslovnicaBasic(int id, string adr, string vrem)
        {
            this.IDPoslovnice = id;
            this.Adresa = adr;
            this.RadnoVreme = vrem;
        }
    }
    public class StrucnaSpremaBasic 
    {
        public int IDSpreme { get; set; }
        public ProdavacBasic pripadaProdavcu { get; set; }
        public string Naziv { get; set; }

        public StrucnaSpremaBasic() { }
        public StrucnaSpremaBasic(int id, string naz)
        {
            this.IDSpreme = id;
            this.Naziv = naz;
        }
    }

    public class KvartBasic 
    {
        public int IDKvart { get; set; }
        public int Zona { get; set; }
        public PoslovnicaBasic pripadaPoslovnici { get; set; }
        public IList<NekretninaBasic> listaNekretnina { get; set; }

        public KvartBasic()
        {
            this.listaNekretnina = new List<NekretninaBasic>();
        }

        public KvartBasic(int id, int zona)
        {
            this.IDKvart = id;
            this.Zona = zona;
        }
    }


    public class IznajmUgovorBasic
    { 
        public int IDUgovorIznajm { get; set; }
        public IznajmNekretninaBasic IznajmNekretnina { get; set; }
        public VlasnikBasic Vlasnik { get; set; }
        public FizickiKupacBasic Kupac { get; set; }
        public ProdavacBasic Prodavac { get; set; }
        public DateTime DatSklapanja { get; set; }
        public DateTime DatIsteka { get; set; }
        public int MesecnaZakupina { get; set; }

        public IznajmUgovorBasic() { }

        public IznajmUgovorBasic(int id, DateTime od, DateTime doo, int cena)
        {
            this.IDUgovorIznajm = id;
            this.DatSklapanja = od;
            this.DatIsteka = doo;
            this.MesecnaZakupina = cena;
        }
    }


    public class KupoprodajniUgovorBasic
    {
        public int IDUgovorKupoprodaja { get; set; }
        public KupoprodNekretninaBasic KupoprodNekretnina { get; set; }
        public VlasnikBasic Vlasnik { get; set; }
        public KupacBasic Kupac { get; set; }
        public ProdavacBasic Prodavac { get; set; }
        public DateTime DatTransakcije { get; set; }

        public KupoprodajniUgovorBasic() { }

        public KupoprodajniUgovorBasic(int id, DateTime dat)
        {
            this.IDUgovorKupoprodaja = id;
            this.DatTransakcije = dat;
        }

    }
}



