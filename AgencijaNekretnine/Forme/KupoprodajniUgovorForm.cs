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



        private void btnDodaj_Click(object sender, EventArgs e)
        {

        }

        private void prikaziView() {
            this.listUgovori.Clear();

            List<KupoprodajniUgovorBasic> ugovori = DTOmanager.vratiKPugovore();

            foreach (KupoprodajniUgovorBasic a in ugovori)
            {
                ListViewItem li = new ListViewItem(new string[] { a.Kupac.KupacID.ToString(), a.KupoprodNekretnina.Ulica, a.KupoprodNekretnina.Broj.ToString(), a.Prodavac.JMBG.ToString(),a.DatTransakcije.ToString() });
                this.listUgovori.Items.Add(li);
            }

            this.listUgovori.Refresh();
        }

        private void KupoprodajniUgovorForm_Load(object sender, EventArgs e)
        {
            prikaziView();
        }
    }
}
