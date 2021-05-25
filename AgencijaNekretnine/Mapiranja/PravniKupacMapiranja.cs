using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class PravniKupacMapiranja:SubclassMap<PravniKupac>
    {
        public PravniKupacMapiranja()
        {
            Table("PRAV_KUPAC_NEKRETNINE");

            KeyColumn("JMBGPIB");

            References(x => x.jeKupac).Column("IDKUPAC2").LazyLoad();
        }
    }
}
