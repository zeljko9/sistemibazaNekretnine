﻿using AgencijaNekretnine.Entiteti;
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
            Id(x => x.IDugkp).Column("IDUGPR").GeneratedBy.SequenceIdentity("S17254.SEQ_KUPOPROD_UGOVOR");

            Map(x => x.Datum_transakcije).Column("DATUM_TRANSAKCIJE");

            References(x => x.kupoprodNekretnine).Column("IDKPN").LazyLoad();
            References(x => x.vlasnik).Column("IDVLASNIK").LazyLoad();
            References(x => x.kupac).Column("IDKUPAC").LazyLoad();
            References(x => x.prodavac).Column("JMBG1").LazyLoad();

        }
    }
}
