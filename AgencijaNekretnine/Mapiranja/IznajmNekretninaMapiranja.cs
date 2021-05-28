using AgencijaNekretnine.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Mapiranja
{
    class IznajmNekretninaMapiranja: ClassMap<IznajmNekretnina>
    {
        public IznajmNekretninaMapiranja() {
            Table("IZNAJM_NEKRETNINA");

            Id(x => x.IDizn, "IDIZN").GeneratedBy.SequenceIdentity("nekretnineBaza.SEQ_IZNAJM_NEKRETNINA");
        }
    }
}
