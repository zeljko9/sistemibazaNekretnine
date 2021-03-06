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

        /*private void PoslovniceForm_Load(object sender, EventArgs arg)
        {
            popuniPodacima();
        }*/

        public void popuniPodacima()
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

        private void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            DodajPoslovnicuForm form = new DodajPoslovnicuForm();
            form.ShowDialog();
            form.Close();
            popuniPodacima();
        }

        private void btnIzmeniPoslovnicu_Click(object sender, EventArgs e)
        {
            if (poslovnice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu koju zelite da obrisete!");
                return;
            }

            int idPoslovnice = Int32.Parse(poslovnice.SelectedItems[0].SubItems[0].Text);

            PoslovnicaBasic p = DTOmanager.vratiPoslovnicu(idPoslovnice);
            IzmeniPoslovnicuForm form = new IzmeniPoslovnicuForm(p);
            form.ShowDialog();

            popuniPodacima();
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
            popuniPodacima();
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

        private void btnSefoviPrikaz_Click(object sender, EventArgs e)
        {
            PrikazSefovaForm form = new PrikazSefovaForm();
            form.ShowDialog();
            
        }

        private void PoslovniceForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
