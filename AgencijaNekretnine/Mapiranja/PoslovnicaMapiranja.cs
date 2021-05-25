using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{
    public class PoslovnicaMapiranja: ClassMap<Poslovnica>
    {   
        public PoslovnicaMapiranja()
        {
            Table("POSLOVNICA");

            Id(x => x.IDPoslovnice, "IDPOSLOVNICA").GeneratedBy.SequenceIdentity("nekretnineBaza.SEQ_POSLOVNICA");

            Map(x => x.Adresa, "ADRESA");
            Map(x => x.RadnoVreme, "RADNO_VREME");

            References(x => x.SefPoslovnice).Column("IDSEF").LazyLoad();
            HasMany(x => x.NagledaKvartove).KeyColumn("IDPOSLOVNICA1").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.ZaposljavaZaposlene).KeyColumn("IDPOSLOVNICA2").LazyLoad().Cascade.All().Inverse();
            //ide 1:1 sef mapiranje

        }
    }
}
