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
    public partial class DodajStambenuNekretninuForm : Form
    {
        Nekretnina n;
        public DodajStambenuNekretninuForm()
        {
            InitializeComponent();
            n = new Nekretnina();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                n.Ulica = textUlica.Text;
                n.Broj = (int)numBroj.Value;
                n.Sprat = (int)numSprat.Value;
                n.BrKupatila = (int)numBrojKupatila.Value;
                n.DatumIzgradnje = dateTimePicker1.Value;
                n.TipNekretnine = "stambena";

                DTOmanager.dodajNekretninu(this.n);
                MessageBox.Show("Uspesno ste dodali novu stambenu nekretninu!");
                this.Close();
            }
        }
    }
}
