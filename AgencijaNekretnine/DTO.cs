﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine
{
    public class LiceBasic
    {
        public string JMBG_PIB { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Adresa { get; set; }
        public string TipLica { get; set; }
        public IList<KupoprodajniUgovor> KPugovori { get; set; }
        public IList<IznajmUgovorBasic> IZNugovori { get; set; }
        public IList<TelefonBasic> listaTelefona { get; set; }

        public LiceBasic(string jmbg, string ime, string prez, string adresa)
        {
            this.JMBG_PIB = jmbg;
            this.Ime = ime;
            this.Prezime = prez;
            this.Adresa = adresa;
            if (Convert.ToString(JMBG_PIB).Length >= 12)
            {
                TipLica = "Fizicko";
            }
            else {
                TipLica = "Pravno";
            }
        }
        public LiceBasic(Lice l) { 
            
        }

        public LiceBasic() { this.listaTelefona = new List<TelefonBasic>(); }

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
        public string IDvlasnik { get; set; }
        public string TipNekretnine { get; set; }
        public int BrKupatila { get; set; }

        public IList<OpremaBasic> oprema { get; set; }
        public KvartBasic pripadaKvartu { get; set; }

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


    public class ZaposleniBasic
    {
        public long JMBG { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatZaposlenja { get; set; }
        public PoslovnicaBasic radiUPoslovnici { get; set; }


        public ZaposleniBasic() { }
        public ZaposleniBasic(long jmbg,string ime, string prez,DateTime dat)
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

        public ProdavacBasic(long jmbg, string ime, string prez, DateTime dat):base(jmbg, ime, prez, dat) { }

    }

    public class SefBasic:ZaposleniBasic
    {
        public DateTime datPostavljanja { get; set; }
        public PoslovnicaBasic sefujeNad { get; set; }

        public SefBasic() { }
        public SefBasic(long jmbg, string ime, string prez, DateTime dat):base(jmbg, ime, prez, dat) { }
    }

    public class OpremaBasic 
    {
        private Nekretnina pripadaNekretnini1;

        public int IDOprema { get; set; }
        public string NazivOpreme { get; set; }
        public NekretninaBasic pripadaNekretnini { get; set; }
        public OpremaBasic() { }
        public OpremaBasic(int id, string naziv)
        {
            this.IDOprema = id;
            this.NazivOpreme = naziv;
        }

        public OpremaBasic(int id, string naziv, Nekretnina pripadaNekretnini1) : this(id, naziv)
        {
            this.pripadaNekretnini1 = pripadaNekretnini1;
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

        public DateTime DatRada { get; set; }
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
        public NekretninaBasic IznajmNekretnina { get; set; }
        public LiceBasic Vlasnik { get; set; }
        public LiceBasic Kupac { get; set; }
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
        public NekretninaBasic KupoprodNekretnina { get; set; }
        public LiceBasic Kupac { get; set; }
        public LiceBasic vlasnik { get; set; }
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