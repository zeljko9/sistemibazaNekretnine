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
    public partial class SveNekretnineKvartaForm : Form
    {
        KvartBasic kvart;
        public SveNekretnineKvartaForm()
        {
            InitializeComponent();
        }

        public SveNekretnineKvartaForm(KvartBasic k)
        {
            this.kvart = k;
            InitializeComponent();
        }

        public void SveNekretnineKvartaForm_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        void popuniPodacima()
        {
            this.listaNekretninaKvart.Clear();
            List<NekretninaBasic> nekretnine = DTOmanager.vratiSveNekretnineKvarta(this.kvart.IDKvart);

            foreach(NekretninaBasic n in nekretnine)
            {
                ListViewItem li = new ListViewItem(new string[] { n.IDNekretnina.ToString(), n.Ulica, n.Broj.ToString(), n.Sprat.ToString(), n.Cena.ToString(), n.Starost.ToString(), n.DatumIzgradnje.ToString(), n.TipNekretnine, n.BrKupatila.ToString() });
                this.listaNekretninaKvart.Items.Add(li);
            }

            this.listaNekretninaKvart.Refresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (this.listaNekretninaKvart.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nekretninu koji zelite da obrisete!");
                return;
            }

            int idNekretnine = Int32.Parse(this.listaNekretninaKvart.SelectedItems[0].SubItems[0].Text);

            DTOmanager.obrisiNekretninu(idNekretnine);
            MessageBox.Show("Nekretnina uspesno obrisana");
            this.popuniPodacima();
        }
    }
}
