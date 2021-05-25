using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class VlasnikMapiranja:ClassMap<Vlasnik>
    {
        public VlasnikMapiranja()
        {
            Table("VLASNIK");

            Id(x => x.VlasnikID).GeneratedBy.SequenceIdentity("nekretnineBaza.SEQ_VLASNIK");
        }
    }
}
