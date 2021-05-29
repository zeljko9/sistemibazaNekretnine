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






        public static void dodajZaposlenog(ZaposleniBasic z)
        {
            ISession s = DataLayer.GetSession();
            Zaposleni zap = new Zaposleni();
            zap.JMBG = z.JMBG;
            zap.Ime = z.Ime;
            zap.Prezime = zap.Prezime;
            zap.DatZaposlenja = z.DatZaposlenja;
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
                    poslovnice.Add(new PoslovnicaBasic(p.IDPoslovnice,p.Adresa,p.RadnoVreme));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                //handle exceptions
            }

            return poslovnice;
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




            }catch(Exception e)
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
            catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }


    }
}
#endregion

    



       



