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

            zaposleni.Columns.Add(new ColumnHeader() { Text = "Ime" });
            zaposleni.Columns.Add(new ColumnHeader() { Text = "Prezime" });
            zaposleni.Columns.Add(new ColumnHeader() { Text = "JMBG" });
            zaposleni.Columns.Add(new ColumnHeader() { Text = "Datum zaposlenja" });
            zaposleni.Columns.Add(new ColumnHeader() { Text = "Strucna sprema" });
        


            List<ProdavacBasic> listaProdavaca = DTOmanager.vratiZaposlenePoslovnice(this.poslovnica.IDPoslovnice);
            foreach(ProdavacBasic p in listaProdavaca)
            {
                string ss;

                if (p.strucneSpreme == null)
                    ss = null;
                else
                    ss = p.strucneSpreme[0].Naziv;

                ListViewItem prod = new ListViewItem(new string[] { p.Ime, p.Prezime, p.JMBG.ToString(), p.DatZaposlenja.ToString(), ss });
                this.zaposleni.Items.Add(prod);
            }

            this.zaposleni.Refresh();
        }

        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            DodajZaposlenogForm form = new DodajZaposlenogForm(this.poslovnica);
            form.ShowDialog();
            //form.Close();
            popuniPodacima();
        }

        private void btnIzmeniZaposlenog_Click(object sender, EventArgs e)
        {
            if (zaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da izmenite!");
                return;
            }

            string idZaposleni = zaposleni.SelectedItems[0].SubItems[2].Text;
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

            popuniPodacima();
        }

        private void btnAgentiProdavca_Click(object sender, EventArgs e)
        {

            if (zaposleni.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavca cije agente zelite da vidite");
                return;
            }

            string idZaposleni = zaposleni.SelectedItems[0].SubItems[2].Text;

            ProdavacBasic p = DTOmanager.vratiProdavca(idZaposleni);

            AgentiForm form = new AgentiForm(p);
            form.ShowDialog();

            popuniPodacima();
        }

        private void ZaposleniForm_Load_1(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }
    }
}
