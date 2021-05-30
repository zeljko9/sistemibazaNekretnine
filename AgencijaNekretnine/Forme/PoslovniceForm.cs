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
    public partial class PoslovniceForm : Form
    {
        public PoslovniceForm()
        {
            InitializeComponent();
        }

        private void PoslovniceForm_Load(object sender, EventArgs arg)
        {
            this.popuniPodacima();
        }

        void popuniPodacima()
        {
            poslovnice.Items.Clear();
            List<PoslovnicaBasic> data = DTOmanager.vratiSvePoslovnice();
            foreach(PoslovnicaBasic p in data)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IDPoslovnice.ToString(), p.Adresa, p.RadnoVreme });
                poslovnice.Items.Add(item);
            }
            



            poslovnice.Refresh();
        }

        private void poslovnice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            DodajPoslovnicuForm form = new DodajPoslovnicuForm();
            form.ShowDialog();
        }

        private void btnIzmeniPoslovnicu_Click(object sender, EventArgs e)
        {
            IzmeniPoslovnicuForm form = new IzmeniPoslovnicuForm();
            form.ShowDialog();
        }

        private void btnObrisiPoslovnicu_Click(object sender, EventArgs e)
        {
            if (poslovnice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu koju zelite da obrisete!");
                return;
            }

            int idPoslovnice = Int32.Parse(poslovnice.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranu poslovnicu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOmanager.obrisiPoslovnicu(idPoslovnice);
                MessageBox.Show("Brisanje poslovnice je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void btnZaposleniPoslovnice_Click(object sender, EventArgs e)
        {
            if (poslovnice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu cije zaposlene zelite da vidite!");
                return;
            }

            int idPoslovnice = Int32.Parse(poslovnice.SelectedItems[0].SubItems[0].Text);
            PoslovnicaBasic p = DTOmanager.vratiPoslovnicu(idPoslovnice);
            ZaposleniForm form = new ZaposleniForm(p);
            form.ShowDialog();
        }
    }
}
