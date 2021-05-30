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
    public partial class LicaForm : Form
    {
        public LicaForm()
        {
            InitializeComponent();
        }

        private void LicaForm_Load(object sender, EventArgs e)
        {
            ucitajView();
        }

        private void ucitajView() {
            List<LiceBasic> lica = new List<LiceBasic>();

            listaLica.Items.Clear();
            List<LiceBasic> podaci = DTOmanager.vratiSvaLica();

            foreach (LiceBasic l in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { l.JMBG_PIB.ToString(), l.Ime, l.Prezime, l.Adresa});
                listaLica.Items.Add(item);

            }

            listaLica.Refresh();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajLiceForm forma = new DodajLiceForm();
            forma.ShowDialog();

            ucitajView();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DTOmanager.obrisiLice(Int32.Parse(listaLica.SelectedItems[0].SubItems[0].Text));

            ucitajView();
        }

        private void btnDodajFon_Click(object sender, EventArgs e)
        {
            if (listaLica.SelectedItems.Count != 0)
            {
                TelefonBasic t = new TelefonBasic();
                Lice l = new Lice();
                l.JMBG_PIB = Int32.Parse(listaLica.SelectedItems[0].SubItems[0].Text);
                t.brTel = textTelefon.Text;

                DTOmanager.dodajTelefonLicu(DTOmanager.vratiLice(l), t);
                textTelefon.Clear();
            }
            else {
                MessageBox.Show("Izaberite lice prvo.", "Greska...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            Lice l = new Lice();
            l.JMBG_PIB = Int32.Parse(listaLica.SelectedItems[0].SubItems[0].Text);

            IzmeniLiceForm forma = new IzmeniLiceForm(DTOmanager.vratiLice(l));
            forma.ShowDialog();

            ucitajView();
        }
    }
}
