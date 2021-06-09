using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class AgentMapiranja : SubclassMap<Agent>
    {
        public AgentMapiranja() {
            Table("AGENT");

            KeyColumn("IDPRODAVAC");

            //Id(x => x.JMBG).Column("IDPRODAVAC").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Procenat).Column("PROCENAT");
            Map(x => x.Telefon).Column("TELEFON");
            Map(x => x.DatRada).Column("DATUM_RADA");

            References(x => x.AngazovanOd).Column("IDPRODAVAC").LazyLoad();

        }
        
    }
}
