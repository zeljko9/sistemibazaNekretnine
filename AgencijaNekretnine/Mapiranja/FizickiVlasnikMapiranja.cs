using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class FizickiVlasnikMapiranja:SubclassMap<FizickiVlasnik>
    {
        public FizickiVlasnikMapiranja()
        {
            Table("FIZ_VLASNIK_NEKRETNINE");

            KeyColumn("JMBGPIB");

            References(x => x.jeVlasnik).Column("IDVLASNIK1").LazyLoad();
            
        }
    }
}
