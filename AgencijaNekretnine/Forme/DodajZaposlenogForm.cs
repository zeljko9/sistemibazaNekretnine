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
            this.dtpDatZaposlenja.Enabled = true;
        }

        public DodajZaposlenogForm(PoslovnicaBasic p)
        {
            InitializeComponent();
            this.dtpDatZaposlenja.Enabled = true;
            this.poslovnica = p;
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            //NE MOZE INT, JMBG IMA 13 CIFARA
            long jmbg = Convert.ToInt64(textjmbgz.Text);
            string ime = this.tbxIme.Text;
            string prez = this.tbxPrezime.Text;
            DateTime dat = this.dtpDatZaposlenja.Value;
            string Strucna = this.tbxStrucnaSprema.Text;

            if(this.cbxSef.Enabled)
            {
                SefBasic sef = new SefBasic(jmbg, ime, prez, dat);
                sef.datPostavljanja = this.dtpPostavljanje.Value;
                sef.sefujeNad = this.poslovnica;
                this.poslovnica.listaZaposlenih.Add(sef);
                DTOmanager.dodajZaposlenog(sef, this.poslovnica);
            }
            else
            {
                ProdavacBasic z = new ProdavacBasic(jmbg, ime, prez, dat);
                StrucnaSpremaBasic s = new StrucnaSpremaBasic();
                s.Naziv = Strucna;
                z.radiUPoslovnici = this.poslovnica;
                this.poslovnica.listaZaposlenih.Add(z);
                DTOmanager.dodajZaposlenog(z, this.poslovnica);
                DTOmanager.dodajStrucnuSpremu(s, z);
            }

            



            MessageBox.Show("Uspesno ste dodali novog zaposlenog");
        }

        private void cbxSef_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbxSef.Checked)
            {
                //this.dtpDatZaposlenja.Enabled = true;
                this.tbxStrucnaSprema.Enabled = false;
            }
            else
            {
               // this.dtpDatZaposlenja.Enabled = false;
                this.tbxStrucnaSprema.Enabled = true;
            }
        }
    }
}
