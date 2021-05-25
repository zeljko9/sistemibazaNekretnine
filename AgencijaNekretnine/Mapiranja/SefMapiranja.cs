using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
   public class SefMapiranja:SubclassMap<Sef>
    {
        public SefMapiranja()
        {
            Table("SEF");

            KeyColumn("JMBG");

            Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA");

            HasOne(x => x.sefujeNadPoslovnicom).ForeignKey("IDSEF").LazyLoad();
        }
    }
}
