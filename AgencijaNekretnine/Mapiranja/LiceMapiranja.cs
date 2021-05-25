using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    internal class LiceMapiranja : ClassMap<Lice>
    {
        public LiceMapiranja()
        {
            Table("LICE");

            //DiscriminateSubClassesOnColumn("TIPLICA");

            Id(x => x.JMBG_PIB,"JMBGPIB").GeneratedBy.Assigned();

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.TipLica, "TIPLICA");

            //1:N VEZA SA TELEFON, IMA NIZ TELEFONA
            HasMany(x => x.TelefoniLica).KeyColumn("JMBGPIB").LazyLoad().Cascade.All().Inverse();


        }
    }

    /*internal class FizickoLiceMapiranja : SubclassMap<Lice>
    {
        public FizickoLiceMapiranja()
        {
            DiscriminatorValue("Fizicko");
        }
    }

    internal class PravnoLiceMapiranja : SubclassMap<Lice>
    {
        public PravnoLiceMapiranja()
        {
            DiscriminatorValue("Pravno");
        }
    }*/

    internal class FizickiKupacMapiranja : SubclassMap<FizickiKupac>
    {
        public FizickiKupacMapiranja()
        {
            Table("FIZICKI_KUPAC_NEKRETNINE");

            KeyColumn("JMBGPIB");

            References(x => x.jeKupac).Column("IDKUPAC1").LazyLoad();
        }
    }

    internal class FizickiVlasnikMapiranja : SubclassMap<FizickiVlasnik>
    {
        public FizickiVlasnikMapiranja()
        {
            Table("FIZ_VLASNIK_NEKRETNINE");

            KeyColumn("JMBGPIB");

            References(x => x.jeVlasnik).Column("IDVLASNIK1").LazyLoad();

        }
    }

    internal class PravniKupacMapiranja : SubclassMap<PravniKupac>
    {
        public PravniKupacMapiranja()
        {
            Table("PRAV_KUPAC_NEKRETNINE");

            KeyColumn("JMBGPIB");

            References(x => x.jeKupac).Column("IDKUPAC2").LazyLoad();
        }
    }

    internal class PravniVlasnikMapiranja : SubclassMap<PravniVlasnik>
    {
        public PravniVlasnikMapiranja()
        {
            Table("PRAV_VLASNIK_NEKRETNINE");

            KeyColumn("JMBGPIB");

            References(x => x.jeVlasnik).Column("IDVLASNIK2").LazyLoad();
        }
    }
}
