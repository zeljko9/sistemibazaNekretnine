using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class ZaposleniMapiranja:ClassMap<Zaposleni>
    {
        public ZaposleniMapiranja()
        {
            Table("ZAPOSLENI");

            Id(x => x.JMBG).Column("JMBG").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.DatZaposlenja).Column("DAT_ZAPOSLENJA");

            References(x => x.RadiUPoslovnici).Column("IDPOSLOVNICA2").LazyLoad();
        }
    }
}
