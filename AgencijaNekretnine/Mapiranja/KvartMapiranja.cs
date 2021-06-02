﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    internal class KvartMapiranja : ClassMap<Kvart>
    {   
        public KvartMapiranja()
        {
            Table("Kvart");

            Id(x => x.IDKvart).Column("IDKVART").GeneratedBy.SequenceIdentity("S17254.SEQ_KVART");

            Map(x => x.Zona).Column("ZONA");

            //N:1 ka POSLOVNICI
            References(x => x.PripadaPoslovnici).Column("IDPOSLOVNICA1").LazyLoad();

            //1:N ka NEKRETNINI
            HasMany(x => x.NekretnineKvarta).KeyColumn("IDKVART").LazyLoad().Cascade.All().Inverse();
        }

    }
}
