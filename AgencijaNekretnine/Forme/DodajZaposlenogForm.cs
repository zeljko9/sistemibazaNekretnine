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
            string jmbg = textjmbgz.Text;
            string ime = this.tbxIme.Text;
            string prez = this.tbxPrezime.Text;
            DateTime dat = this.dtpDatZaposlenja.Value;
            string Strucna = this.tbxStrucnaSprema.Text;

            if(this.cbxSef.Checked)
            {
                ZaposleniBasic sef = new ZaposleniBasic(jmbg,ime,prez,dat,Strucna,1, this.dtpPostavljanje.Value);
               // sef.datPostavljanja = this.dtpPostavljanje.Value;
                sef.radiUPoslovnici = this.poslovnica;
                this.poslovnica.listaZaposlenih.Add(sef);
                DTOmanager.dodajSefa(sef, this.poslovnica);
            }
            else
            {
                ZaposleniBasic z = new ZaposleniBasic(jmbg,ime,prez,dat,Strucna,0,DateTime.MinValue);
                //StrucnaSpremaBasic s = new StrucnaSpremaBasic
                z.radiUPoslovnici = this.poslovnica;
                this.poslovnica.listaZaposlenih.Add(z);
                DTOmanager.dodajProdavca(z, this.poslovnica);
               
            }

            



            MessageBox.Show("Uspesno ste dodali novog zaposlenog");
            this.Close();
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
