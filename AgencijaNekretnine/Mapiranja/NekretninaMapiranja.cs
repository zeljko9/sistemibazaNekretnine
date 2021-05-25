using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    internal class NekretninaMapiranja : ClassMap<Nekretnina>
    {
        public NekretninaMapiranja()
        {
            Table("NEKRETNINA");

            Id(x => x.IDNekretnina, "IDNEKRETNINA").GeneratedBy.SequenceIdentity("nekretnineBaza.SEQ_NEKRETNINA");

            Map(x => x.Ulica, "ULICA");
            Map(x => x.Sprat, "SPRAT");
            Map(x => x.Broj, "BROJ");
            Map(x => x.Cena, "CENA");
            Map(x => x.DatumIzgradnje, "DATUMIZGRADNJE");
            Map(x => x.Starost, "STAROST");
            Map(x => x.TipNekretnine, "TIPNEKRETNINE");
            Map(x => x.BrKupatila, "BR_KUPATILA");
            References(x => x.PripadaKvartu).Column("IDKVART").LazyLoad();
        }
    }
}
