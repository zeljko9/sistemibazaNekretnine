using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Mapiranja
{//Kupac je izveden iz Lice, lice ima svoj id(jmbg/pib), da li je moguce da pravis nov id Kupca kad vec ima svoj id iz Lica 
    public class KupacMapiranja:ClassMap<Kupac>
    {
        KupacMapiranja()
        {
            Table("KUPAC");

            Id(x => x.KupacID).Column("IDKUPAC").GeneratedBy.SequenceIdentity("S17254.SEQ_KUPAC");
        }
    }
}
