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
    public partial class KupoprodajniUgovorForm : Form
    {
        public KupoprodajniUgovorForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void prikaziView() {
            this.listUgovori.Clear();

            List<KupoprodajniUgovorBasic> ugovori = DTOmanager.vratiKPugovore();

            

            foreach (KupoprodajniUgovorBasic a in ugovori)
            {
                LiceBasic lb1 = DTOmanager.vratiVlasnikaKupca(a.Vlasnik.VlasnikID);
                LiceBasic lb2 = DTOmanager.vratiVlasnikaKupca(a.Kupac.KupacID);
                NekretninaBasic nb = DTOmanager.vratiNekretninu(a.KupoprodNekretnina.IDNekretnina);
                ListViewItem li = new ListViewItem(new string[] { lb1.JMBG_PIB, lb1.Ime, lb1.Prezime, nb.Ulica, Convert.ToString(nb.Broj), lb2.JMBG_PIB, lb2.Ime, lb2.Prezime });
                this.listUgovori.Items.Add(li);
            }

            this.listUgovori.Refresh();
        }
    }
}
