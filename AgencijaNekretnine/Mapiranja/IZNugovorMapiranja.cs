﻿using FluentNHibernate.Mapping;
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
            Id(x => x.IDugizn, "IDUGIZ").GeneratedBy.Assigned();

            Map(x => x.Mesecna_zakupina, "MESECNA_ZAKUPINA");
            Map(x => x.Datum_sklapanja, "DATUM_SKLAPANJA");
            Map(x => x.Datum_isteka, "DATUM_ISTEKA");
            References(x => x.kupoprodNekretnine).Column("IDIZN").LazyLoad();
            References(x => x.vlasnik).Column("IDVLASNIK").LazyLoad();
            References(x => x.kupac).Column("IDFZK").LazyLoad();
            References(x => x.prodavac).Column("JMBG2").LazyLoad();
        }
    }
}
