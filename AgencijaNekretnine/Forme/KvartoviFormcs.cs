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
    public partial class KvartoviFormcs : Form
    {
        public KvartoviFormcs()
        {
            InitializeComponent();
        }

        public void KvartoviFormacs_Load(object sender, EventArgs e)
        { 
            popuniPodacima();
        }
        void popuniPodacima()
        {
            this.listaKvartova.Clear();
            List<KvartBasic> kvartovi = DTOmanager.vratiKvartove();

            foreach(KvartBasic k in kvartovi)
            {
                ListViewItem li = new ListViewItem(new string[] { k.IDKvart.ToString(), k.Zona.ToString(), k.pripadaPoslovnici.IDPoslovnice.ToString() });
                this.listaKvartova.Items.Add(li);
            }

            this.listaKvartova.Refresh();
        }

        private void btnDodajKvart_Click(object sender, EventArgs e)
        {
            KvartBasic k = new KvartBasic();
            if (this.proveriValidPoslovnica() && this.proveriValidZona())
            {
                k.Zona = (int)this.nmudZona.Value;
                k.pripadaPoslovnici = DTOmanager.vratiPoslovnicu((int)this.nmudIDPoslovnice.Value);

                //zovni dodajkvart
                DTOmanager.dodajKvart(k);
                MessageBox.Show("Uspesno dodat kvart");

            }
            else
            {
                MessageBox.Show("Unesite podatke pre dodavanja kvarta");
            }
        }

        private void btnIzmeniKvart_Click(object sender, EventArgs e)
        {
            if (listaKvartova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kvart koji zelite da izmenite!");
                return;
            }

            if (!this.proveriValidPoslovnica() || !this.proveriValidZona() )
            {
                MessageBox.Show("Unesite validne podatke");
                return;
            }

            int idKvarta = Int32.Parse(listaKvartova.SelectedItems[0].SubItems[0].Text);

            
            KvartBasic k = DTOmanager.vratiKvart(idKvarta);
            k.Zona = (int)this.nmudZona.Value;
            k.pripadaPoslovnici = DTOmanager.vratiPoslovnicu((int)this.nmudIDPoslovnice.Value);

            DTOmanager.izmeniKvart(k);
            MessageBox.Show("Kvart uspesno izmenjen");
            

        }

        private void btnObrisiKvart_Click(object sender, EventArgs e)
        {
            if (listaKvartova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kvart koji zelite da izmenite!");
                return;
            }

            int idKvarta = Int32.Parse(listaKvartova.SelectedItems[0].SubItems[0].Text);

            DTOmanager.obrisiKvart(idKvarta);
            MessageBox.Show("Kvart uspesno obrisan");

        }

        private void btnNekretnineKvarta_Click(object sender, EventArgs e)
        {
            if (listaKvartova.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kvart koji zelite da izmenite!");
                return;
            }

            int idKvarta = Int32.Parse(listaKvartova.SelectedItems[0].SubItems[0].Text);
            KvartBasic k = DTOmanager.vratiKvart(idKvarta);

            SveNekretnineKvartaForm form = new SveNekretnineKvartaForm(k);
            form.ShowDialog();
        }

        private Boolean proveriValidZona()
        {
            return this.nmudZona.Value != 0;
        }

        private Boolean proveriValidPoslovnica()
        {
            return this.nmudIDPoslovnice.Value != 0;
        }
    }
}
