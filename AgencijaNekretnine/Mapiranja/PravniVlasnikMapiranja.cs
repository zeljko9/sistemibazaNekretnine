using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class PravniVlasnikMapiranja:SubclassMap<PravniVlasnik>
    {  
        public PravniVlasnikMapiranja()
        {
            Table("PRAV_VLASNIK_NEKRETNINE");

            KeyColumn("JMBGPIB");

            References(x => x.jeVlasnik).Column("IDVLASNIK2").LazyLoad();
        }
    }
}
