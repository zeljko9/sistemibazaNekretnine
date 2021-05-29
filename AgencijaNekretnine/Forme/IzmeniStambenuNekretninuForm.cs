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
    public partial class IzmeniStambenuNekretninuForm : Form
    {
        NekretninaBasic n;
        public IzmeniStambenuNekretninuForm(NekretninaBasic nek)
        {
            InitializeComponent();
            n = nek;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            n.Ulica = textUlica.Text;
            n.Broj = (int)numBroj.Value;
            n.Sprat = (int)numSprat.Value;
            n.Cena = (int)numCena.Value;
            n.DatumIzgradnje = dateTimePicker1.Value;
            n.BrKupatila = (int) numBrKupatila.Value;

            DTOmanager.izmeniNekretninu(n);
        }

        private void IzmeniStambenuNekretninuForm_Load(object sender, EventArgs e)
        {
            textUlica.Text = n.Ulica;
            numBroj.Value = n.Broj;
            numSprat.Value = n.Sprat;
            dateTimePicker1.Value = n.DatumIzgradnje;
            numCena.Value = n.Cena;
            numBrKupatila.Value = n.BrKupatila;
        }
    }
}
