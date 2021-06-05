using AgencijaNekretnine.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Mapiranja
{
    internal class KPugovorMapiranja:ClassMap<KupoprodajniUgovor>
    {
        public KPugovorMapiranja() {

            Table("KUPOPROD_UGOVOR");

            Id(x => x.IDugkp).Column("IDUGOVOR").GeneratedBy.SequenceIdentity("S17254.SEQ_KUPOPROD_UGOVOR");

            Map(x => x.Datum_transakcije).Column("DATUM_TRANSAKCIJE");

            References(x => x.kupoprodNekretnine).Column("IDNEKRETNINA").LazyLoad();
   
            References(x => x.kupac).Column("IDKUPAC").LazyLoad();
            References(x => x.prodavac).Column("IDPRODAVAC").LazyLoad();

        }
    }
}
