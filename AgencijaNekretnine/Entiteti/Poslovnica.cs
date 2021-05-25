using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Poslovnica
    {
        public virtual int IDPoslovnice { get; set; }
        public virtual string Adresa { get; set; }
        public virtual string RadnoVreme { get; set; }
        public virtual Sef SefPoslovnice { get; set; }
        public virtual IList<Kvart> NagledaKvartove { get; set; }
        public virtual IList<Zaposleni> ZaposljavaZaposlene { get; set; }

        public Poslovnica()
        {
            this.NagledaKvartove = new List<Kvart>();
            this.ZaposljavaZaposlene = new List<Zaposleni>();
        }
    }
}
