using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgencijaNekretnine.Entiteti;

namespace AgencijaNekretnine.Forme
{
    public partial class NekretnineForm : Form
    {
        public NekretnineForm()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DTOmanager.obrisiNekretninu(Int32.Parse(listNekretnine.SelectedItems[0].SubItems[0].Text));

            popuniView();
        }

        private void btnDodajStambenu_Click(object sender, EventArgs e)
        {
            DodajStambenuNekretninuForm forma = new DodajStambenuNekretninuForm();
            forma.ShowDialog();
            this.popuniView();
        }


        public void popuniView() {

            listNekretnine.Items.Clear();
            List<NekretninaBasic> podaci = DTOmanager.vratiSveNekretnine();

            foreach (NekretninaBasic n in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { n.IDNekretnina.ToString(), n.Ulica,n.Broj.ToString(),n.Sprat.ToString(),n.Starost.ToString(), n.Cena.ToString(), n.TipNekretnine });
                listNekretnine.Items.Add(item);

            }

            listNekretnine.Refresh();
        }

        private void btnOprema_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listNekretnine.SelectedItems[0].SubItems[0].Text);
            NekretninaBasic n = DTOmanager.vratiNekretninu(id);

            OpremaForm forma = new OpremaForm(n);
            forma.ShowDialog();
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listNekretnine.SelectedItems[0].SubItems[0].Text);
            NekretninaBasic n = DTOmanager.vratiNekretninu(id);

            if (n.TipNekretnine.Equals("Stambena"))
            {
                IzmeniStambenuNekretninuForm forma = new IzmeniStambenuNekretninuForm(n);
                forma.ShowDialog();
            }
            else {
                IzmeniPoslovnuNekretninuForm forma = new IzmeniPoslovnuNekretninuForm(n);
                forma.ShowDialog();
            }

            
            popuniView();
        }

        private void NekretnineForm_Load(object sender, EventArgs e)
        {
            popuniView();
        }

       private void btnDodajPoslovnu_Click(object sender, EventArgs e)
        {
            DodajPoslovnuNekretninuForm1cs form = new DodajPoslovnuNekretninuForm1cs();
            form.ShowDialog();
            this.popuniView();
            
        }

        private void listNekretnine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
