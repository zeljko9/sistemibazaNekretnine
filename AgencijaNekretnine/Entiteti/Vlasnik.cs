using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Vlasnik:Lice
    {
        public virtual int VlasnikID { get; set; }

        public Vlasnik()
        {

        }
    }
}
