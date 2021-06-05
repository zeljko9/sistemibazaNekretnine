﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaNekretnine.Forme
{
    public partial class DodajKPugovorForm : Form
    {
        public DodajKPugovorForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DTOmanager.postojiNekretnina(textUlicaBroj.Text).Equals("ne postoji")) {
                MessageBox.Show("Moli mo Vas unesite postojecu nekretninu");
                return;
            }
            if (DTOmanager.postojiLice(textKupac.Text).Equals("")) {
                MessageBox.Show("Moli mo Vas unesite odgovarajuceg kupca");
                return;
            }

            DTOmanager.dodajKPugovor(textKupac.Text, textUlicaBroj.Text, textProdavac.Text);

            this.Close();
            
        }
    }
}