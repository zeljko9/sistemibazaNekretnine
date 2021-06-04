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
    public partial class IznajmUgovorForm : Form
    {
        public IznajmUgovorForm()
        {
            InitializeComponent();
        }

        private void IznajmUgovorForm_Load(object sender, EventArgs e)
        {
            prikaziView();
        }

        private void prikaziView()
        {
            this.listUgovori.Clear();

            List<IznajmUgovorBasic> ugovori = DTOmanager.vratiIZNugovore();

            foreach (IznajmUgovorBasic a in ugovori)
            {
                ListViewItem li = new ListViewItem(new string[] { a.Kupac.JMBG_PIB.ToString(), a.IznajmNekretnina.Ulica, a.IznajmNekretnina.Broj.ToString(), a.Prodavac.JMBG.ToString(), a.DatSklapanja.ToString(), a.DatIsteka.ToString() });
                this.listUgovori.Items.Add(li);
            }

            this.listUgovori.Refresh();
        }
    }
}
