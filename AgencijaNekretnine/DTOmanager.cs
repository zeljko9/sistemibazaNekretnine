using AgencijaNekretnine.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate.Linq;
using System.Text;
using System.Threading.Tasks;
//using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine
{
    class DTOmanager
    {
        #region Nekretnine
        public static void dodajNekretninu(NekretninaBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nekretnina nek = new Nekretnina();
                nek.IDvlasnik = n.IDvlasnik;
                nek.Ulica = n.Ulica;
                nek.TipNekretnine = n.TipNekretnine;
                nek.Starost = n.Starost;
                nek.Sprat = n.Sprat;
                nek.BrKupatila = n.BrKupatila;
                nek.Broj = n.Broj;
                nek.Cena = n.Cena;
                nek.DatumIzgradnje = n.DatumIzgradnje;

                s.SaveOrUpdate(nek);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                //greska
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        

        public static List<NekretninaBasic> vratiSveNekretnine()
        {
            List<NekretninaBasic> nekretnine = new List<NekretninaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Nekretnina> sveNekretnine = from n in s.Query<Nekretnina>() select n;
                int i = 0;
                foreach (Nekretnina n in sveNekretnine)
                {
                    if (n.IDNekretnina==0) {
                        continue;
                    }
                    NekretninaBasic nek = DTOmanager.vratiNekretninu(n.IDNekretnina);
                    nekretnine.Add(nek);

                    //nekretnine.Add(new Nekretnina(n.IDNekretnina, n.Ulica, n.Broj, n.Sprat, n.Cena, n.Starost, n.DatumIzgradnje, n.TipNekretnine, n.BrKupatila, n.oprema, n.PripadaKvartu));

                }
                s.Close();

            }
            catch (Exception e)
            {
                //greska 
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return nekretnine;
        }

        public static void izmeniNekretninu(NekretninaBasic n)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Nekretnina nekretnina = s.Load<Nekretnina>(n.IDNekretnina);
                nekretnina.Ulica = n.Ulica;
                nekretnina.Broj = n.Broj;
                nekretnina.DatumIzgradnje = n.DatumIzgradnje;
                nekretnina.Cena = n.Cena;
                nekretnina.Sprat = n.Sprat;
                nekretnina.BrKupatila = n.BrKupatila;
                int i = 0;
                if (n.oprema != null)
                {
                    foreach (OpremaBasic o in n.oprema)
                    {
                        nekretnina.oprema[i] = DTOmanager.izmeniOpremu(o);
                    }
                }

                s.SaveOrUpdate(nekretnina);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                //greska
            }
        }

        public static Oprema izmeniOpremu(OpremaBasic ob)
        {
            ISession s = DataLayer.GetSession();
            Oprema oprema = s.Load<Oprema>(ob.IDOprema);
            oprema.NazivOpreme = ob.NazivOpreme;
            return oprema;
        }

        public static NekretninaBasic vratiNekretninu(int id)
        {
            NekretninaBasic n = new NekretninaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Nekretnina nek = s.Load<Nekretnina>(id);
                n = new NekretninaBasic(nek.IDNekretnina, nek.Ulica, nek.Broj, nek.Sprat, nek.Cena, nek.Starost, nek.DatumIzgradnje, nek.TipNekretnine, nek.BrKupatila);

                s.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return n;
        }

        public static void obrisiNekretninu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Nekretnina n = s.Load<Nekretnina>(id);

                s.Delete(n);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                //greska

                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }
        #endregion

        #region Oprema
        public static List<Oprema> vratiSvuOpremu(Nekretnina n)
        {
            List<Oprema> opreme = new List<Oprema>();

            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Oprema> data = from o in s.Query<Oprema>()
                                           where o.PripadaNekretnini == n
                                           select o;

                foreach (Oprema opr in data)
                {
                    opreme.Add(new Oprema(opr.IDoprema, opr.NazivOpreme, opr.PripadaNekretnini));
                }

                s.Close();
            }
            catch (Exception e)
            {

            }

            return opreme;
        }

        public static void izmeniOpremu(Oprema o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oprema opr = s.Load<Oprema>(o.IDoprema);
                opr.NazivOpreme = o.NazivOpreme;

                s.SaveOrUpdate(opr);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {

            }
        }

        public static void dodajOpremu(Oprema o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            }
            catch (Exception E)
            {
                //greska
            }
        }

        public static void obrisiOpremu(Oprema o)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Oprema opr = s.Load<Oprema>(o.IDoprema);

                s.Delete(opr);
                s.Flush();
                s.Close();
            }
            catch (Exception E)
            {
                //greska
            }
        }

        public static Oprema vratiOpremu(int id)
        {
            Oprema opr = new Oprema();
            try
            {
                ISession s = DataLayer.GetSession();

                opr = s.Load<Oprema>(id);


                s.Close();
            }
            catch (Exception E)
            {
                //greska
            }
            return opr;
        }
        #endregion

        #region Poslovice i zaposleni
        public static void dodajZaposlenog(ProdavacBasic z, PoslovnicaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Prodavac zap = new Prodavac();

                zap.JMBG = z.JMBG;
                zap.Ime = z.Ime;
                zap.Prezime = zap.Prezime;
                zap.DatZaposlenja = z.DatZaposlenja;

                Poslovnica pos = s.Load<Poslovnica>(p.IDPoslovnice);
                zap.RadiUPoslovnici = pos;

                s.SaveOrUpdate(zap);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            //zap.RadiUPoslovnici = z.radiUPoslovnici;

        }




        public static List<PoslovnicaBasic> vratiSvePoslovnice()
        {

            List<PoslovnicaBasic> poslovnice = new List<PoslovnicaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Poslovnica> sveProdavnice = (from o in s.Query<Poslovnica>()
                                                        select o).ToList<Poslovnica>();

                foreach (Poslovnica p in sveProdavnice)
                {
                    PoslovnicaBasic pb = new PoslovnicaBasic(p.IDPoslovnice, p.Adresa, p.RadnoVreme);
                    if(pb.Sef != null)
                        pb.Sef = DTOmanager.vratiSefa(p.SefPoslovnice.JMBG);
                    poslovnice.Add(pb);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return poslovnice;
        }



        public static PoslovnicaBasic vratiPoslovnicu(int id)
        {
            PoslovnicaBasic pos = new PoslovnicaBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Poslovnica p = s.Load<Poslovnica>(id);
                pos.Adresa = p.Adresa;
                pos.RadnoVreme = p.RadnoVreme;
                pos.IDPoslovnice = p.IDPoslovnice;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return pos;
        }



        public static List<ProdavacBasic> vratiZaposlenePoslovnice(int idPoslovnice)
        {

            List<ProdavacBasic> listaProdavaca = new List<ProdavacBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Prodavac> prodavci = from p in s.Query<Prodavac>()
                                                 where p.RadiUPoslovnici.IDPoslovnice == idPoslovnice
                                                 select p;
                foreach (Prodavac p in prodavci)
                {

                    ProdavacBasic prod = new ProdavacBasic(p.JMBG, p.Ime, p.Prezime, p.DatZaposlenja);
                    List<StrucnaSpremaBasic> spreme = DTOmanager.vratiStrucneSpremeProdavca(prod.JMBG);
                    prod.strucneSpreme = spreme;
                    //vratiStrucneSpreme


                    listaProdavaca.Add(new ProdavacBasic(p.JMBG, p.Ime, p.Prezime, p.DatZaposlenja));

                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return listaProdavaca;

            /* List<ZaposleniBasic> listaZaposleni = new List<ZaposleniBasic>();
             try
             {
                 ISession s = DataLayer.GetSession();
                 IEnumerable<Zaposleni> zaposleni = from z in s.Query<Zaposleni>()
                                                    where z.RadiUPoslovnici.IDPoslovnice == idPoslovnice
                                                    select z;

                 foreach(Zaposleni z in zaposleni)
                 {
                     listaZaposleni.Add(new ZaposleniBasic(z.JMBG, z.Ime, z.Prezime, z.DatZaposlenja));
                 }
             }
             catch(Exception e) 
             {
                 System.Windows.Forms.MessageBox.Show(e.Message);
             }

             return listaZaposleni;*/
        }


        public static List<StrucnaSpremaBasic> vratiStrucneSpremeProdavca(long idProdavca)
        {
            List<StrucnaSpremaBasic> str = new List<StrucnaSpremaBasic>();
            ISession s = DataLayer.GetSession();
            IEnumerable<StrucnaSprema> sprem = from st in s.Query<StrucnaSprema>()
                                               where st.pripadaProdavcu.JMBG == idProdavca
                                               select st;
            foreach (StrucnaSprema sprema in sprem)
            {
                StrucnaSpremaBasic struka = new StrucnaSpremaBasic(sprema.IDSpreme, sprema.NazivSpreme);
                str.Add(struka);
            }

            return str;


        }
        public static void dodajPoslovnicu(PoslovnicaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Poslovnica pos = new Poslovnica();
                pos.Adresa = p.Adresa;
                pos.RadnoVreme = pos.RadnoVreme;

                s.SaveOrUpdate(pos);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }


        }


        public static void izmeniPoslovnicu(PoslovnicaBasic p)
        {
            try
            {

                ISession s = DataLayer.GetSession();
                Poslovnica pos = s.Load<Poslovnica>(p.IDPoslovnice);
                pos.Adresa = p.Adresa;
                pos.RadnoVreme = p.RadnoVreme;
                s.Update(pos);
                s.Flush();
                s.Close();




            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public static void obrisiPoslovnicu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Poslovnica p = s.Load<Poslovnica>(id);

                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public static void dodajStrucnuSpremu(StrucnaSpremaBasic struka, ProdavacBasic prod)
        {

            try
            {
                ISession s = DataLayer.GetSession();
                StrucnaSprema str = new StrucnaSprema();

                str.NazivSpreme = struka.Naziv;
                str.pripadaProdavcu = s.Load<Prodavac>(prod.JMBG);

                s.SaveOrUpdate(str);
                s.Flush();
                s.Close();


            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        public static void izmeniProdavca(ProdavacBasic prodavac)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Prodavac p = s.Load<Prodavac>(prodavac.JMBG);
                p.Ime = prodavac.Ime;
                p.Prezime = prodavac.Prezime;
                p.DatZaposlenja = prodavac.DatZaposlenja;

                s.SaveOrUpdate(p);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public static void izmeniStrucnuSpremu(StrucnaSpremaBasic struka, long JMBG)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                // StrucnaSprema struc = s.Load<StrucnaSprema>(struka.IDSpreme);
                Prodavac p = s.Load<Prodavac>(JMBG);
                IEnumerable<StrucnaSprema> struc = from strucna_sprema in s.Query<StrucnaSprema>()
                                                   where strucna_sprema.pripadaProdavcu.JMBG == JMBG
                                                   select strucna_sprema;

                foreach (StrucnaSprema stru in struc)
                {
                    stru.NazivSpreme = struka.Naziv;
                    stru.pripadaProdavcu = p;
                }

                s.SaveOrUpdate(struc);
                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        public static ProdavacBasic vratiProdavca(long JMBG)
        {
            ProdavacBasic prod = new ProdavacBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Prodavac p = s.Load<Prodavac>(JMBG);
                prod.Ime = p.Ime;
                prod.Prezime = p.Prezime;
                prod.DatZaposlenja = p.DatZaposlenja;
                prod.JMBG = p.JMBG;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return prod;
        }


        public static void obrisiProdavca(int jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Prodavac p = s.Load<Prodavac>(jmbg);
                s.Delete(p);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        public static void dodajZaposlenog(SefBasic sef, PoslovnicaBasic p)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Sef Sef = new Sef();

                Sef.JMBG = sef.JMBG;
                Sef.Ime = sef.Ime;
                Sef.Prezime = sef.Prezime;
                Sef.DatZaposlenja = sef.DatZaposlenja;

                Poslovnica pos = s.Load<Poslovnica>(p.IDPoslovnice);
                Sef.sefujeNadPoslovnicom = pos;

                s.SaveOrUpdate(Sef);

                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        public static List<SefBasic> vratiSveSefove()
        {
            List<SefBasic> sefovi = new List<SefBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Sef> listaSefova = from sef in s.Query<Sef>()
                                               select sef;
                foreach(Sef sef in listaSefova)
                {
                    SefBasic seef = new SefBasic(sef.JMBG, sef.Ime, sef.Prezime, sef.DatZaposlenja);
                    seef.datPostavljanja = sef.DatumPostavljanja;
                    sefovi.Add(seef);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return sefovi;
        }

        public static SefBasic vratiSefa(long JMBG)
        {
            SefBasic sef = new SefBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Sef sefBaza = s.Load<Sef>(JMBG);
                sef.Ime = sefBaza.Ime;
                sef.Prezime = sefBaza.Prezime;
                sef.DatZaposlenja = sefBaza.DatZaposlenja;
                sef.datPostavljanja = sefBaza.DatumPostavljanja;
                sef.radiUPoslovnici = DTOmanager.vratiPoslovnicu(sefBaza.RadiUPoslovnici.IDPoslovnice);
                sef.sefujeNad = sef.radiUPoslovnici;

            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return sef;
        }


        public static List<AgentBasic> vratiAgenteProdavca(long idProdavca)
        {
            List<AgentBasic> listaAgenata = new List<AgentBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Agent> agenti = from a in s.Query<Agent>()
                                            where a.AngazovanOd.JMBG == idProdavca
                                            select a;

                foreach(Agent a in agenti)
                {
                    AgentBasic agent = new AgentBasic(a.Ime, a.Prezime, a.Procenat, a.Telefon);
                    agent.DatRada = a.DatRada;
                    agent.angazovanOd = DTOmanager.vratiProdavca(idProdavca);
                    listaAgenata.Add(agent);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return listaAgenata;
        }




        public static void dodajAgenta(AgentBasic a)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Agent agent = new Agent();
                agent.Ime = a.Ime;
                agent.Prezime = a.Prezime;
                agent.Procenat = a.Procenat;
                agent.DatRada = a.DatRada;
                agent.Telefon = a.brTel;
                agent.AngazovanOd = s.Load<Prodavac>(a.angazovanOd.JMBG);

                s.SaveOrUpdate(agent);
                s.Flush();
                s.Close();

            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }



        public static void izmeniAgenta(AgentBasic agent)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Agent a = s.Load<Agent>(agent.angazovanOd.JMBG);
                a.Ime = agent.Ime;
                a.Prezime = agent.Prezime;
                a.Telefon = agent.brTel;
                a.Procenat = agent.Procenat;
                a.DatRada = agent.DatRada;

                s.SaveOrUpdate(a);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }



        public static AgentBasic vratiAgenta(int JMBG)
        {
            AgentBasic agent = new AgentBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Agent a = s.Load<Agent>(JMBG);
                agent.Ime = a.Ime;
                agent.Prezime = a.Prezime;
                agent.brTel = a.Telefon;
                agent.DatRada = a.DatRada;
                agent.Procenat = a.Procenat;
                agent.angazovanOd = DTOmanager.vratiProdavca(JMBG);
                
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return agent;
        }


        public static void obrisiAgenta(int idAgenta)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Agent a = s.Load<Agent>(idAgenta);

                s.Delete(a);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Kvart
        public static List<KvartBasic> vratiKvartove()
        {
            List<KvartBasic> listaKvartova = new List<KvartBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable<Kvart> kvartovi = from k in s.Query<Kvart>()
                                              select k;

                foreach(Kvart k in kvartovi)
                {
                    KvartBasic kvart = new KvartBasic(k.IDKvart, k.Zona);
                    kvart.pripadaPoslovnici = DTOmanager.vratiPoslovnicu(k.PripadaPoslovnici.IDPoslovnice);
                    listaKvartova.Add(kvart);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return listaKvartova;
        }



        public static void dodajKvart(KvartBasic kvart)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kvart k = new Kvart();
                k.Zona = kvart.Zona;
                k.PripadaPoslovnici = s.Load<Poslovnica>(kvart.pripadaPoslovnici.IDPoslovnice);

                s.SaveOrUpdate(k);
                s.Flush();
                s.Close();
                
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        public static KvartBasic vratiKvart(int id)
        {
            KvartBasic k = new KvartBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                Kvart kvart = s.Load<Kvart>(id);
                k.IDKvart = kvart.IDKvart;
                k.Zona = kvart.Zona;
                k.pripadaPoslovnici = DTOmanager.vratiPoslovnicu(kvart.PripadaPoslovnici.IDPoslovnice);

            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return k;
        }


        public static void izmeniKvart(KvartBasic k)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kvart kvart = s.Load<Kvart>(k.IDKvart);
                kvart.Zona = k.Zona;
                kvart.PripadaPoslovnici = s.Load<Poslovnica>(k.pripadaPoslovnici.IDPoslovnice);

                s.SaveOrUpdate(kvart);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


        public static void obrisiKvart(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kvart k = s.Load<Kvart>(id);

                s.Delete(k);
                s.Flush();
                s.Close();
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        public static List<NekretninaBasic> vratiSveNekretnineKvarta(int IDKvarta)
        {
            List<NekretninaBasic> listaNekretnina = new List<NekretninaBasic>();
            try
            {
                ISession s = DataLayer.GetSession();
                IEnumerable < Nekretnina > nekretnine = from n in s.Query<Nekretnina>()
                                             where n.PripadaKvartu.IDKvart == IDKvarta
                                             select n;
                foreach(Nekretnina n in nekretnine)
                {
                    NekretninaBasic nek = new NekretninaBasic(n.IDNekretnina, n.Ulica, n.Broj, n.Sprat, n.Cena, n.Starost, n.DatumIzgradnje, n.TipNekretnine, n.BrKupatila);
                    listaNekretnina.Add(nek);
                }
            }
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return listaNekretnina;
        }
        #endregion

        #region Lice

        public static string postojiLice(string jmbg) {
            try
            {
                ISession s = DataLayer.GetSession();

                Lice lice = s.Load<Lice>(jmbg);
                /*(Lice)(from l in s.Query<Lice>()
                        where l.JMBG_PIB == jmbg
                        select l);*/
                s.Close();

                if (lice != null)
                    return lice.TipLica;
                else
                    return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public static string postojiNekretnina(String ulicabroj) {
            try
            {
                string[] niz = ulicabroj.Split(" ");
                string broj = niz.Last();
                string ulica = "";
                for (int i = 0; i < niz.Length - 1; i++)
                {
                    ulica.Concat(" ");
                    ulica.Concat(niz[i]);
                }
                ulica.Remove(0, 1);

                ISession s = DataLayer.GetSession();

                Nekretnina nek = (Nekretnina)(from n in s.Query<Nekretnina>()
                                 where n.Ulica == ulica &&
                                 n.Broj == Convert.ToInt32(broj)
                                 select n);

                s.Close();

                if (nek != null)
                {
                    return "postoji";
                }
                else {
                    return "ne postoji";
                }

            }
            catch (Exception e)
            {

            }
            return "";
        }

        public static List<LiceBasic> vratiSvaLica() {
            List<LiceBasic> lica = new List<LiceBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IList<Lice> svaLica = s.Query<Lice>().ToList();

                int i = 0;
                foreach (Lice l in svaLica)
                {

                    LiceBasic lice = new LiceBasic(l.JMBG_PIB, l.Ime, l.Prezime, l.Adresa);
                    lica.Add(lice);
                    /*if (n.IDNekretnina == 0)
                    {
                        continue;
                    }*/
                    //LiceBasic nek = DTOmanager
                    //LiceBasic lb = DTOmanager.vratiLice(l);
                    //lica.Add(lb);

                    //nekretnine.Add(new Nekretnina(n.IDNekretnina, n.Ulica, n.Broj, n.Sprat, n.Cena, n.Starost, n.DatumIzgradnje, n.TipNekretnine, n.BrKupatila, n.oprema, n.PripadaKvartu));

                }
                s.Close();

            }
            catch (Exception e)
            {
                //greska 
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return lica;
        }

        public static LiceBasic vratiLice(Lice l)
        {
            LiceBasic lb = new LiceBasic();
            try {
                ISession s = DataLayer.GetSession();

                Lice lice = s.Load<Lice>(l.JMBG_PIB);

                lb.Ime = lice.Ime;
                lb.Prezime = lice.Prezime;
                lb.JMBG_PIB = lice.JMBG_PIB;
                lb.Adresa = lice.Adresa;

                s.Close();

            } catch (Exception e) {
                Console.WriteLine("Greska u  komunikacije sa bazom!");
            }

            return lb;
        }

        public static bool dodajLice(LiceBasic lb)
        {
            try {

                ISession s = DataLayer.GetSession();

                Telefon t = new Telefon();
                Lice l = new Lice();

                t.brTel = lb.listaTelefona[0].brTel;
                t.PripadaLicu = l;

                l.JMBG_PIB = lb.JMBG_PIB;
                l.Ime = lb.Ime;
                l.Prezime = lb.Prezime;
                l.TelefoniLica.Add(t);
                l.Adresa = lb.Adresa;

                s.SaveOrUpdate(l);
                s.Flush();
                s.Close();
            } catch (Exception e) {
                return false;
            }

            return true;
        }

        public static void dodajTelefonLicu(LiceBasic lb, TelefonBasic tb)
        {
            try {
                ISession s = DataLayer.GetSession();

                Lice l = s.Load<Lice>(lb.JMBG_PIB);
                Telefon t = new Telefon();

                t.brTel = tb.brTel;
                l.TelefoniLica.Add(t);

                s.SaveOrUpdate(l);
                s.Flush();
                s.Close();

            } catch (Exception e) { 
                //greska
            }
        }

        public static void izmeniLice(LiceBasic lb) {
            try
            {
                ISession s = DataLayer.GetSession();

                Lice l = s.Load<Lice>(lb.JMBG_PIB);

                l.Ime = lb.Ime;
                l.Prezime = lb.Prezime;
                l.Adresa = lb.Adresa;

                s.SaveOrUpdate(l);
                s.Flush();
                s.Close();

            }
            catch (Exception e)
            {
                //greska
            }
        }

        public static void obrisiLice(int jp) {
            try
            {
                ISession s = DataLayer.GetSession();

                Lice l = s.Load<Lice>(jp);

                s.Delete(l);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {

            }
        }

        public static LiceBasic vratiVlasnikaKupca(int vlasnikID)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lice l = s.Load<Lice>(vlasnikID);

                s.Close();

                

                LiceBasic lb = new LiceBasic();
                lb.Prezime = l.Prezime;
                lb.TipLica = l.TipLica;
                lb.Adresa = l.Adresa;
                lb.Ime = l.Ime;
                lb.JMBG_PIB = l.JMBG_PIB;

                return lb;


            }
            catch (Exception e)
            {

            }
            return null;
        }
        #endregion

        #region Ugovor

        public static List<KupoprodajniUgovorBasic> vratiKPugovore()
        {
            List<KupoprodajniUgovorBasic> kpbl = new List<KupoprodajniUgovorBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<KupoprodajniUgovor> kpu = from o in s.Query<KupoprodajniUgovor>()
                                                      select o;

                
                KupoprodajniUgovorBasic kpb = new KupoprodajniUgovorBasic();
                foreach (KupoprodajniUgovor kp in kpu) {
                    kpb.DatTransakcije = kp.Datum_transakcije;
                    kpb.IDUgovorKupoprodaja = kp.IDugkp;
                    kpb.Kupac = new KupacBasic(kp.kupac.KupacID);
                    //kpb.KupoprodNekretnina = (KupoprodNekretninaBasic)vratiNekretninu(kp.kupoprodNekretnine.IDNekretnina);
                    kpb.Vlasnik = new VlasnikBasic(kp.vlasnik.VlasnikID);
                    kpb.Prodavac = vratiProdavca(kp.prodavac.JMBG);

                    kpbl.Add(kpb);
                }
            }
            catch (Exception e)
            {

            }
            return kpbl;
        }

        public static List<IznajmUgovorBasic> vratiIZNugovore()
        {
            List<IznajmUgovorBasic> kpbl = new List<IznajmUgovorBasic>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<IznajmUgovor> kpu = from o in s.Query<IznajmUgovor>()
                                                      select o;

                IznajmUgovorBasic kpb = new IznajmUgovorBasic();
                foreach (IznajmUgovor kp in kpu)
                {
                    kpb.DatIsteka = kp.Datum_isteka;
                    kpb.DatSklapanja = kp.Datum_sklapanja;
                    kpb.Kupac = new FizickiKupacBasic(kp.kupac.JMBG_PIB, kp.kupac.Ime, kp.kupac.Prezime, kp.kupac.Adresa);
                    kpb.Kupac.jeKupac = new KupacBasic(kp.kupac.jeKupac.KupacID);
                    kpb.IDUgovorIznajm = kp.IDugizn;
                    NekretninaBasic nb = vratiNekretninu(kp.iznajmNekretnine.nekretnina.IDNekretnina);
                    kpb.IznajmNekretnina =  new IznajmNekretninaBasic(kp.iznajmNekretnine.IDizn, nb);
                    kpb.Vlasnik = new VlasnikBasic(kp.vlasnik.VlasnikID);
                    kpb.Prodavac = vratiProdavca(kp.prodavac.JMBG);
                    kpb.MesecnaZakupina = kp.Mesecna_zakupina;

                    kpbl.Add(kpb);
                }
            }
            catch (Exception e)
            {

            }
            return kpbl;
        }

        public static void dodajKPugovor(string jmbgK, string ulicabroj, string jmbgP) {
            try
            {
                ISession s = DataLayer.GetSession();

                Lice lice = (Lice)(from l in s.Query<Lice>()
                            where l.JMBG_PIB == jmbgK
                            select l);
                Prodavac prodavac = (Prodavac)(from p in s.Query<Prodavac>()
                                               where p.JMBG == Convert.ToDouble(jmbgP)
                                               select p);

                string[] niz = ulicabroj.Split(" ");
                string broj = niz.Last();
                string ulica = "";
                for (int i = 0; i < niz.Length - 1; i++) {
                    ulica.Concat(" ");
                    ulica.Concat(niz[i]);                    
                }
                ulica.Remove(0, 1);

                Nekretnina nekretnina = (Nekretnina)(from n in s.Query<Nekretnina>()
                                                     where n.Ulica == ulica &&
                                                     n.Broj == Convert.ToInt32(broj)
                                                     select n); 


                KupoprodajniUgovor kp = new KupoprodajniUgovor();
                kp.kupac = new Kupac();

                if (lice.TipLica == "fizicko") {
                    FizickiKupac fk = (FizickiKupac)lice;
                    fk.jeKupac = kp.kupac;
                    s.SaveOrUpdate(fk);
                } else if (lice.TipLica == "pravno") {
                    PravniKupac pk = (PravniKupac)lice;
                    pk.jeKupac = kp.kupac;
                    s.SaveOrUpdate(pk);
                }

                kp.Datum_transakcije = DateTime.Now;
                //kp.kupoprodNekretnine = (KupoprodNekretnina)nekretnina;
                kp.prodavac = prodavac;
                kp.vlasnik = (Vlasnik)(from v in s.Query<Lice>()
                             where v.JMBG_PIB == Convert.ToString(nekretnina.IDvlasnik)
                             select v);

                s.SaveOrUpdate(kp);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {

            }
        }

        public static void dodajIZNugovor(string jmbgK, string ulicabroj, string jmbgP, DateTime dt) {
            try
            {
                ISession s = DataLayer.GetSession();

                FizickiKupac lice = (FizickiKupac)(from l in s.Query<FizickiKupac>()
                                   where l.JMBG_PIB == jmbgK
                                   select l);
                Prodavac prodavac = (Prodavac)(from p in s.Query<Prodavac>()
                                               where p.JMBG == Convert.ToDouble(jmbgP)
                                               select p);

                string[] niz = ulicabroj.Split(" ");
                string broj = niz.Last();
                string ulica = "";
                for (int i = 0; i < niz.Length - 1; i++)
                {
                    ulica.Concat(" ");
                    ulica.Concat(niz[i]);
                }
                ulica.Remove(0, 1);

                Nekretnina nekretnina = (Nekretnina)(from n in s.Query<Nekretnina>()
                                                     where n.Ulica == ulica &&
                                                     n.Broj == Convert.ToInt32(broj)
                                                     select n);


                IznajmUgovor kp = new IznajmUgovor();

                kp.kupac = lice;               
                kp.Datum_sklapanja = DateTime.Now;
                kp.Datum_isteka = dt;
                kp.iznajmNekretnine = new IznajmNekretnina();
                kp.Mesecna_zakupina = nekretnina.Cena / 300;
                kp.prodavac = prodavac;
                kp.vlasnik= (Vlasnik)(from v in s.Query<Lice>()
                                      where v.JMBG_PIB == Convert.ToString(nekretnina.IDvlasnik)
                                      select v);

                s.SaveOrUpdate(kp);
                s.Flush();
                s.Close();
            }
            catch (Exception e)
            {

            }
        }

        #endregion
        /*try {

        } catch (Exception e) { 

        }*/

    }
}


    



       



