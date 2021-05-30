using AgencijaNekretnine.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgencijaNekretnine.Entiteti;

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
                    if (i < 6)
                    {
                        i++;
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

                IEnumerable<Poslovnica> sveProdavnice = from o in s.Query<Poslovnica>()
                                                        select o;

                foreach (Poslovnica p in sveProdavnice)
                {
                    poslovnice.Add(new PoslovnicaBasic(p.IDPoslovnice, p.Adresa, p.RadnoVreme));
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


        public static List<StrucnaSpremaBasic> vratiStrucneSpremeProdavca(int idProdavca)
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

        public static void izmeniStrucnuSpremu(StrucnaSpremaBasic struka, int JMBG)
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


        public static ProdavacBasic vratiProdavca(int JMBG)
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


        public static List<AgentBasic> vratiAgenteProdavca(int idProdavca)
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

    }
}
#endregion

    



       



