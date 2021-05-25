using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class IznajmNekretnina : Nekretnina
    {
        public virtual int IDizn { get; set; }

        public IznajmNekretnina() { 
        }
    }
}
