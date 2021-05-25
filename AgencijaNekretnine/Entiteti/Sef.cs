using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Sef:Zaposleni
    {
        public virtual DateTime DatumPostavljanja { get; set; }

        public virtual Poslovnica sefujeNadPoslovnicom { get; set; }
        
    }
}
