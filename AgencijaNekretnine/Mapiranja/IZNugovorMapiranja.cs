using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Mapiranja
{
    internal class IZNugovorMapiranja:ClassMap<IznajmUgovor>
    {
        public IZNugovorMapiranja()
        {
            Table("IZNAJM_UGOVOR");

            Id(x => x.IDugizn).Column("IDIZN").GeneratedBy.SequenceIdentity("S17254.SEQ_IZNAJMLJIVANJE_UGOVOR");

            Map(x => x.Mesecna_zakupina).Column("MESECNA_ZAKUPINA");
            Map(x => x.Datum_sklapanja).Column("DATUM_SKLAPANJA");
            Map(x => x.Datum_isteka).Column("DATUM_ISTEKA");
            References(x => x.iznajmNekretnine).Column("IDNEKRETNINA").LazyLoad();
            References(x => x.kupac).Column("IDKUPAC").LazyLoad();
            References(x => x.prodavac).Column("IDPRODAVAC").LazyLoad();
        }
    }
}
