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
        NekretninaBasic n;
        public DodajStambenuNekretninuForm()
        {
            InitializeComponent();
            n = new NekretninaBasic();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK) {
                n.pripadaKvartu =DTOmanager.vratiKvartPoZoni(Convert.ToInt32(comboKvart.SelectedItem.ToString()));
                n.IDvlasnik =comboVlasnik.SelectedItem.ToString();
                n.Ulica = textUlica.Text;
                n.Broj = (int)numBroj.Value;
                n.Sprat = (int)numSprat.Value;
                n.BrKupatila = (int)numBrojKupatila.Value;
                n.DatumIzgradnje = dateTimePicker1.Value;
                n.TipNekretnine = "Stambena";
                n.Cena = (int)nmbCena.Value;
                n.Starost = DateTime.Now.Year - n.DatumIzgradnje.Year;

                DTOmanager.dodajNekretninu(this.n);
                MessageBox.Show("Uspesno ste dodali novu stambenu nekretninu!");
                this.Close();
            }
        }

        private void DodajStambenuNekretninuForm_Load(object sender, EventArgs e)
        {
            List<LiceBasic> lb = DTOmanager.vratiSvaLica();
            List<KvartBasic> kb = DTOmanager.vratiKvartove();
      

            foreach (LiceBasic l in lb) {
                comboVlasnik.Items.Add(l.JMBG_PIB);
            }
            foreach (KvartBasic k in kb)
            {
                comboKvart.Items.Add(k.Zona);
            }
        }
    }
}
