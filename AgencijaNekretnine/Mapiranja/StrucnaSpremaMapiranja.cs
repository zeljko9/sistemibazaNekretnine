using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class StrucnaSpremaMapiranja:ClassMap<StrucnaSprema>
    {   
        public StrucnaSpremaMapiranja()
        {
            Table("STRUCNA_SPREMA");

            Id(x => x.IDSpreme).Column("IDSTRUCNASPREMA").GeneratedBy.SequenceIdentity("S17254.SEQ_STRUCNA_SPREMA");

            Map(x => x.NazivSpreme).Column("STRUCNA_SPREMA");

            References(x => x.pripadaProdavcu).Column("JMBG").LazyLoad();
        }
    }
}
