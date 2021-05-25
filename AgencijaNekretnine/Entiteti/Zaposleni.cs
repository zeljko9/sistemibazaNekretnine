using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
   public class Zaposleni
    {
        public virtual int JMBG { get; set; }
        public virtual String Ime { get; set; }
        public virtual String Prezime { get; set; }
        public virtual DateTime DatZaposlenja { get; set; }

        public virtual Poslovnica RadiUPoslovnici { get; set; }

        public Zaposleni()
        {

        }
    }
}
