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
    public partial class OpremaForm : Form
    {
        Nekretnina n;
        Oprema o;
        public OpremaForm(Nekretnina nkr)
        {
            n = nkr;
            o = new Oprema();
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            o.NazivOpreme = ".";
            o.PripadaNekretnini=n;

            DodajOpremuForm forma = new DodajOpremuForm(o);
            forma.ShowDialog();

            ucitajView();
        }

        private void OpremaForm_Load(object sender, EventArgs e)
        {
            ucitajView();
        }

        public void ucitajView() {
            listOprema.Items.Clear();
            List<Oprema> podaci = DTOmanager.vratiSvuOpremu(n);

            foreach (Oprema p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IDoprema.ToString(), p.NazivOpreme, p.PripadaNekretnini.ToString() });
                listOprema.Items.Add(item);

            }

            listOprema.Refresh();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(listOprema.SelectedItems[0].SubItems[0].Text);
            o = DTOmanager.vratiOpremu(id);

            DodajOpremuForm forma = new DodajOpremuForm(o);
            forma.ShowDialog();

            ucitajView();
        }
    }
}
