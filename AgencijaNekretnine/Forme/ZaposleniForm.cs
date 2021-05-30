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
    public partial class ZaposleniForm : Form
    {
        PoslovnicaBasic poslovnica;
        public ZaposleniForm()
        {
            InitializeComponent();
        }

        public ZaposleniForm(PoslovnicaBasic p)
        {
            InitializeComponent();
            this.poslovnica = p;
        }

        public void ZaposleniForm_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        void popuniPodacima()
        {
            /* this.zaposleni.Clear();
             List<ZaposleniBasic> listaZaposlenih = DTOmanager.vratiZaposlenePoslovnice(this.poslovnica.IDPoslovnice);
             foreach(ZaposleniBasic z in listaZaposlenih)
             {
                 ListViewItem zap = new ListViewItem(new string[] { z.JMBG.ToString(), z.Ime, z.Prezime, z.DatZaposlenja.ToString() });
                 this.zaposleni.Items.Add(zap);
             }

             this.zaposleni.Refresh();*/

            this.zaposleni.Clear();
            List<ProdavacBasic> listaProdavaca = DTOmanager.vratiZaposlenePoslovnice(this.poslovnica.IDPoslovnice);
            foreach(ProdavacBasic p in listaProdavaca)
            {
                ListViewItem prod = new ListViewItem(new string[] { p.JMBG.ToString(), p.Ime, p.Prezime, p.DatZaposlenja.ToString(), p.strucneSpreme.ToString() });
            }
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            DodajZaposlenogForm form = new DodajZaposlenogForm(this.poslovnica);
            form.ShowDialog();
            form.Close();
        }

        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (zaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da izmenite!");
                return;
            }

            int idZaposleni = Int32.Parse(zaposleni.SelectedItems[0].SubItems[0].Text);
            // RadnikBasic r = DTOManager.vratiRadnika(idZaposleni);
            //IzmeniZaposlenogForma forma = new IzmeniZaposlenogForma(r);
            //forma.ShowDialog();
            ProdavacBasic p = DTOmanager.vratiProdavca(idZaposleni);
            IzmeniZaposlenogForm forma = new IzmeniZaposlenogForm(p);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            int idZaposleni = Int32.Parse(zaposleni.SelectedItems[0].SubItems[0].Text);
            // RadnikBasic r = DTOManager.vratiRadnika(idZaposleni);
            //IzmeniZaposlenogForma forma = new IzmeniZaposlenogForma(r);
            //forma.ShowDialog();
            
           
                //ProdavacBasic p = DTOmanager.vratiProdavca(idZaposleni);
            DTOmanager.obrisiProdavca(idZaposleni);
            MessageBox.Show("Prodavac uspesno obrisan");

           
        }

        private void btnAgentiProdavca_Click(object sender, EventArgs e)
        {

            if (zaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavca cije agente zelite da vidite");
                return;
            }

            int idZaposleni = Int32.Parse(zaposleni.SelectedItems[0].SubItems[0].Text);

            ProdavacBasic p = DTOmanager.vratiProdavca(idZaposleni);

            AgentiForm form = new AgentiForm(p);
        }
    }
}
