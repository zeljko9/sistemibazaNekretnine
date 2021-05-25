﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgencijaNekretnine.Entiteti
{
    public class Agent
    {
        public virtual Prodavac AngazovanOd { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int Procenat { get; set; }
        public virtual string Telefon { get; set; }

        public Agent() { }
    }
}
