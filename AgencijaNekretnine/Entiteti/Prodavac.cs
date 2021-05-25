using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Prodavac : Zaposleni
    {
        public virtual IList<StrucnaSprema> listaStrucnihSpremi { get; set; }
        public virtual IList<Agent> listaAgenata { get; set; }
        public Prodavac()
        {
            this.listaStrucnihSpremi = new List<StrucnaSprema>();
            this.listaAgenata = new List<Agent>();
        }
    }
}
