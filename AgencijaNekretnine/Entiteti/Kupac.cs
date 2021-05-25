using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Kupac:Lice
    {
        public virtual int KupacID { get; set; }

        public Kupac()
        {

        }
    }
}
