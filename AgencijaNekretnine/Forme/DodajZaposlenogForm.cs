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
    public partial class DodajZaposlenogForm : Form
    {
        PoslovnicaBasic poslovnica;
        public DodajZaposlenogForm()
        {
            InitializeComponent();
        }

        public DodajZaposlenogForm(PoslovnicaBasic p)
        {
            this.poslovnica = p;
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            int jmbg = (int)this.nmupJMBG.Value;
            string ime = this.tbxIme.Text;
            string prez = this.tbxPrezime.Text;
            DateTime dat = this.dtpDatZaposlenja.Value;
            string Strucna = this.tbxStrucnaSprema.Text;

            ProdavacBasic z = new ProdavacBasic(jmbg, ime, prez, dat);
            StrucnaSpremaBasic s = new StrucnaSpremaBasic();
            s.Naziv = Strucna;

            DTOmanager.dodajZaposlenog(z, this.poslovnica);
            DTOmanager.dodajStrucnuSpremu(s, z);

            MessageBox.Show("Uspesno ste dodali novog zaposlenog");
        }
    }
}
