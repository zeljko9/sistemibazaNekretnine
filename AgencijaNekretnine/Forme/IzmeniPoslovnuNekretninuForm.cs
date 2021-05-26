using AgencijaNekretnine.Entiteti;
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
    public partial class IzmeniPoslovnuNekretninuForm : Form
    {
        Nekretnina n;
        public IzmeniPoslovnuNekretninuForm(Nekretnina nkr)
        {
            InitializeComponent();
            n = nkr;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            n.Ulica = textUlica.Text;
            n.Broj = (int) numBroj.Value;
            n.Sprat = (int) numSprat.Value;
            n.Cena = (int) numCena.Value;
            n.DatumIzgradnje = dateTimePicker1.Value;

            DTOmanager.izmeniNekretninu(n);
        }

        private void IzmeniPoslovnuNekretninuForm_Load(object sender, EventArgs e)
        {
            textUlica.Text = n.Ulica;
            numBroj.Value = n.Broj;
            numSprat.Value = n.Sprat;
            dateTimePicker1.Value = n.DatumIzgradnje;
            numCena.Value = n.Cena;
        }

        private void numBroj_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numCena_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numSprat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textUlica_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
