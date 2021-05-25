using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class KupacMapiranja:ClassMap<Kupac>
    {
        KupacMapiranja()
        {
            Table("KUPAC");

            Id(x => x.KupacID, "IDKUPAC").GeneratedBy.SequenceIdentity("nekretnineBaza.SEQ_KUPAC");
        }
    }
}
