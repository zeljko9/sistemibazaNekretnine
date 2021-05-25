using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    internal class AgentMapiranja : SubclassMap<Agent>
    {
        public AgentMapiranja() {
            Table("AGENT");

            KeyColumn("IDPRODAVAC");

            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Procenat, "PROCENAT");
            Map(x => x.Telefon, "TELEFON");
            Map(x => x.AngazovanOd, "DATUM_RADA");

            References(x => x.AngazovanOd).Column("IDPRODAVAC").LazyLoad();

        }
        
    }
}
