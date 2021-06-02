using AgencijaNekretnine.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Mapiranja
{
    class KupoprodNekretninaMapiranja:ClassMap<KupoprodNekretnina>
    {
        public KupoprodNekretninaMapiranja()
        {
            Table("KUPOPROD_NEKRETNINA");

            Id(x => x.IDkpn).Column("IDKPN").GeneratedBy.SequenceIdentity("S17254.SEQ_KUPOPRODAJNA_NEK");
        }
    }
}
