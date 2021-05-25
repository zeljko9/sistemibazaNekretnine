using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class TelefonMapiranja:ClassMap<Telefon>
    {
        public TelefonMapiranja()
        {
            Table("TELEFON");

            Id(x => x.IDTelefon).GeneratedBy.SequenceIdentity("nekretninaBaza.SEQ_TELEFON");

            Map(x => x.brTel, "TELEFON");

            References(x => x.PripadaLicu).Column("JMBG_PIB").LazyLoad();
        }
    }
}
