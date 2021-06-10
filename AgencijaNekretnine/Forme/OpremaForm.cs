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
        NekretninaBasic n;
        OpremaBasic o;
        public OpremaForm(NekretninaBasic nkr)
        {
            n = nkr;
            o = new OpremaBasic();
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
          
            DTOmanager.obrisiOpremu(Convert.ToInt32(listOprema.SelectedItems[0].SubItems[0].Text));

            ucitajView();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            o.NazivOpreme = ".";
            o.pripadaNekretnini=n;

            DodajOpremuForm forma = new DodajOpremuForm(o, n);
            forma.ShowDialog();

            ucitajView();
        }

        private void OpremaForm_Load(object sender, EventArgs e)
        {
            ucitajView();
        }

        public void ucitajView() {
            listOprema.Items.Clear();
            List<OpremaBasic> podaci = DTOmanager.vratiSvuOpremu(n.IDNekretnina);

            foreach (OpremaBasic p in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.IDOprema.ToString() , p.NazivOpreme });
                listOprema.Items.Add(item);

            }

            listOprema.Refresh();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(listOprema.SelectedItems[0].SubItems[0].Text);
            o = DTOmanager.vratiOpremu(id);

            DodajOpremuForm forma = new DodajOpremuForm(o, n);
            forma.ShowDialog();

            ucitajView();
        }
    }
}
