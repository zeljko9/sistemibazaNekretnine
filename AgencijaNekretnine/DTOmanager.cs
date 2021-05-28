using AgencijaNekretnine.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine
{
    class DTOmanager
    {
        #region Nekretnine
        public static void dodajNekretninu(Nekretnina n) {
            try {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(n);
                s.Flush();
                s.Close();
            } catch (Exception e) {
                //greska
            }
        }

        public static List<Nekretnina> vratiSveNekretnine() {
            List<Nekretnina> nekretnine = new List<Nekretnina>();
            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Nekretnina> sveNekretnine = s.Query<Nekretnina>().ToList();

                foreach (Nekretnina n in sveNekretnine) {
                    nekretnine.Add(new Nekretnina(n.IDNekretnina, n.Ulica, n.Broj, n.Sprat, n.Cena, n.Starost, n.DatumIzgradnje, n.TipNekretnine, n.BrKupatila, n.oprema, n.PripadaKvartu));
                }
                s.Close();

            }
            catch (Exception e) { 
                //greska
            }
            return nekretnine;
        }

        public static void izmeniNekretninu(Nekretnina n)
        {
            try {
                ISession s = DataLayer.GetSession();
                Nekretnina nekretnina = s.Load<Nekretnina>(n.IDNekretnina);
                nekretnina.Ulica = n.Ulica;
                nekretnina.Broj = n.Broj;
                nekretnina.DatumIzgradnje = n.DatumIzgradnje;
                nekretnina.Cena = n.Cena;
                nekretnina.Sprat = n.Sprat;
                nekretnina.BrKupatila = n.BrKupatila;
                nekretnina.oprema = n.oprema;

                s.SaveOrUpdate(nekretnina);
                s.Flush();
                s.Close();
            }
            catch (Exception e) { 
                //greska
            }
        }

        public static Nekretnina vratiNekretninu(int id)
        {
            Nekretnina n = new Nekretnina();
            try
            {
                ISession s = DataLayer.GetSession();

                n= s.Load<Nekretnina>(id);

                s.Close();
            }
            catch (Exception e)
            {
                //greska
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
            }
        }
        #endregion

        #region Oprema
        public static List<Oprema> vratiSvuOpremu(Nekretnina n) {
            List<Oprema> opreme = new List<Oprema>();

            try {
                ISession s = DataLayer.GetSession();

                IEnumerable<Oprema> data = from o in s.Query<Oprema>()
                                           where o.PripadaNekretnini == n
                                           select o;

                foreach (Oprema opr in data) {
                    opreme.Add(new Oprema(opr.IDoprema, opr.NazivOpreme, opr.PripadaNekretnini));
                }

                s.Close();
            } catch (Exception e) { 
                
            }

            return opreme;
        }

        public static void izmeniOpremu(Oprema o)
        {
            try {
                ISession s = DataLayer.GetSession();

                Oprema opr = s.Load<Oprema>(o.IDoprema);
                opr.NazivOpreme = o.NazivOpreme;

                s.SaveOrUpdate(opr);
                s.Flush();
                s.Close();
            } catch (Exception e) { 
                
            }
        }

        public static void dodajOpremu(Oprema o)
        {
            try {
                ISession s = DataLayer.GetSession();

                s.SaveOrUpdate(o);
                s.Flush();
                s.Close();
            } catch (Exception E) { 
                //greska
            }
        }

        public static void obrisiOpremu(Oprema o) {
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
    }
}
