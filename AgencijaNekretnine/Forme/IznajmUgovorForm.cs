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
            listUgovori.Clear();

            List<IznajmUgovorBasic> ugovori = DTOmanager.vratiIZNugovore();

            listUgovori.Columns.Add(new ColumnHeader() { Text = "Kupac" });
            listUgovori.Columns.Add(new ColumnHeader() { Text = "Ulica" });
            listUgovori.Columns.Add(new ColumnHeader() { Text = "Broj" });
            listUgovori.Columns.Add(new ColumnHeader() { Text = "Prodavac" });
            listUgovori.Columns.Add(new ColumnHeader() { Text = "Datum sklapanja" });
            listUgovori.Columns.Add(new ColumnHeader() { Text = "Datum isteka" });
            listUgovori.Columns.Add(new ColumnHeader() { Text = "Mesecna zakupina" });

            foreach (IznajmUgovorBasic a in ugovori)
            {
                ListViewItem li = new ListViewItem(new string[] { a.Kupac.JMBG_PIB, a.IznajmNekretnina.Ulica, a.IznajmNekretnina.Broj.ToString(), a.Prodavac.JMBG.ToString(), a.DatSklapanja.ToString(), a.DatIsteka.ToString(), a.MesecnaZakupina.ToString() });
                listUgovori.Items.Add(li);
            }

            listUgovori.Refresh();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajIZNugovorForm forma = new DodajIZNugovorForm();
            forma.ShowDialog();

            prikaziView();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            DTOmanager.obrisiIZN(listUgovori.SelectedItems[0].SubItems[1].Text, listUgovori.SelectedItems[0].SubItems[2].Text);
            prikaziView();
        }
    }
}
