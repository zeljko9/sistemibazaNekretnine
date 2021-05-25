using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class ProdavacMapiranja:SubclassMap<Prodavac>
    {
        public ProdavacMapiranja()
        {
            Table("PRODAVAC");

            KeyColumn("JMBG");

            HasMany(x => x.listaStrucnihSpremi).KeyColumn("JMBG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
