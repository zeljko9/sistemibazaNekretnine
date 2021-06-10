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
    public partial class IzmeniZaposlenogForm : Form
    {

        ZaposleniBasic prodavac;
        public IzmeniZaposlenogForm()
        {
            InitializeComponent();
        }

        public IzmeniZaposlenogForm(ZaposleniBasic p )
        {
            InitializeComponent();
            this.prodavac = p;
            popuniPodacima();
        }

        void popuniPodacima()
        {
            this.tbxIme.Text = this.prodavac.Ime;
            this.tbxPrezime.Text = this.prodavac.Prezime;
            //this.tbxSprema.Text = this.prodavac.strucneSpreme.Count!=0?this.prodavac.strucneSpreme[0].ToString():"Nema strucnih sprema";
            //this.nmupJMBG.Value = this.prodavac.JMBG;
            this.dtpDatum.Value = this.prodavac.DatZaposlenja;
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.prodavac.Ime = this.tbxIme.Text;
            this.prodavac.Prezime = this.tbxPrezime.Text;
            string naziv = this.tbxSprema.Text;
          // this.prodavac.JMBG = (int) this.nmupJMBG.Value;
            this.prodavac.DatZaposlenja = this.dtpDatum.Value;

            //StrucnaSpremaBasic s = new StrucnaSpremaBasic();
           // s.Naziv = naziv;
           // s.pripadaProdavcu = this.prodavac;
           // DTOmanager.izmeniStrucnuSpremu(s, this.prodavac.JMBG);
            DTOmanager.izmeniProdavca(this.prodavac);

            MessageBox.Show("Uspesno ste azurirali prodavca");

        }
    }
}
