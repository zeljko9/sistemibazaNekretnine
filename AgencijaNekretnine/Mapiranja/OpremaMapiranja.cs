using AgencijaNekretnine.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Mapiranja
{
    internal class OpremaMapiranja:ClassMap<Oprema>
    {
        public OpremaMapiranja()
        {
            Table("TELEFON");

            Id(x => x.IDoprema).Column("IDOPREMA").GeneratedBy.SequenceIdentity("S17254.SEQ_OPREMA");

            Map(x => x.NazivOpreme).Column("OPREMA");

            References(x => x.PripadaNekretnini).Column("IDNEKRETNINA").LazyLoad();
        }
    }
}
