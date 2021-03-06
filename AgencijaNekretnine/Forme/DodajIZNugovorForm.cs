using System;
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
    public partial class DodajIZNugovorForm : Form
    {
        public DodajIZNugovorForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (DTOmanager.postojiNekretnina(textUlicaBroj.Text).Equals("ne postoji"))
            {
                MessageBox.Show("Molimo Vas unesite postojecu nekretninu");
                return;
            }
            if (DTOmanager.postojiNekretnina(textUlicaBroj.Text).Equals("kupljeno"))
            {
                MessageBox.Show("Nekretnina je vec kupljena");
                return;
            }
            if (DTOmanager.postojiNekretnina(textUlicaBroj.Text).Equals("iznajmljeno"))
            {
                MessageBox.Show("Nekretnina je vec iznajmljena");
                return;
            }
            if (DTOmanager.postojiLice(textKupac.Text).Equals(""))
            {
                MessageBox.Show("Moli mo Vas unesite odgovarajuceg kupca");
                return;
            }

            DTOmanager.dodajIZNugovor(textKupac.Text, textUlicaBroj.Text, textProdavac.Text, dateTime.Value);

            this.Close();
        }
    }
}
