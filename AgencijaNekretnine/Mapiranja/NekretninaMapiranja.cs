using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    internal class NekretninaMapiranja : ClassMap<Nekretnina>
    {
        public NekretninaMapiranja()
        {
            Table("NEKRETNINA");

            Id(x => x.IDNekretnina).Column("IDNEKRETNINA").GeneratedBy.SequenceIdentity("S17254.SEQ_NEKRETNINA");

            Map(x => x.Ulica).Column("ULICA");
            Map(x => x.Sprat).Column("SPRAT");
            Map(x => x.Broj).Column("BROJ");
            Map(x => x.Cena).Column("CENA");
            Map(x => x.IDvlasnik).Column("IDVLASNIK");
            Map(x => x.DatumIzgradnje).Column("DATUMIZGRADNJE");
            Map(x => x.Starost).Column("STAROST");
            Map(x => x.TipNekretnine).Column("TIPNEKRETNINE");
            Map(x => x.BrKupatila).Column("BR_KUPATILA");
            HasMany(x => x.oprema).KeyColumn("IDNEKRETNINA").LazyLoad().Cascade.All().Inverse();
            References(x => x.PripadaKvartu).Column("IDKVART").LazyLoad();
            //HasOne(x => x.IDvlasnik).ForeignKey("IDVLASNIK").LazyLoad();
        }
    }

   /* internal class StambKupovinaMapiranja : SubclassMap<StambKupovina> {
        public StambKupovinaMapiranja() {
            Table("STAMB_KUPOVINA");

            KeyColumn("IDNEKRETNINA");

            References(x => x.Kpn).Column("IDKPN").LazyLoad();
        }
    }

    internal class StambIznajmMapiranja : SubclassMap<StambIznajm>
    {
        public StambIznajmMapiranja()
        {
            Table("STAMB_IZNAJM");

            KeyColumn("IDNEKRETNINA");

            References(x => x.Izn).Column("IDIZN").LazyLoad();
        }
    }

    internal class PoslvKupovinaMapiranja : SubclassMap<PoslvKupovina>
    {
        public PoslvKupovinaMapiranja()
        {
            Table("POSLV_KUPOVINA");

            KeyColumn("IDNEKRETNINA");

            References(x => x.Kpn).Column("IDKPN").LazyLoad();
            HasMany(x => x.oprema).KeyColumn("IDNEKRETNINA").LazyLoad().Cascade.All().Inverse();
        }
    }

    internal class PoslvIznajmMapiranja : SubclassMap<PoslvIznajm>
    {
        public PoslvIznajmMapiranja()
        {
            Table("POSLV_IZNAJM");

            KeyColumn("IDNEKRETNINA");

            References(x => x.Izn).Column("IDIZN").LazyLoad();
            HasMany(x => x.oprema).KeyColumn("IDNEKRETNINA").LazyLoad().Cascade.All().Inverse();
        }
    }*/
}
