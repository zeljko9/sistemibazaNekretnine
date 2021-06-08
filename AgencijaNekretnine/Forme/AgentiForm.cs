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
    public partial class AgentiForm : Form
    {
        ProdavacBasic prodavac;
        public AgentiForm()
        {
            InitializeComponent();
        }

        public AgentiForm(ProdavacBasic p)
        {
            this.prodavac = p;
            InitializeComponent();
        }


        public void AgentiForm_Load(object sender, EventArgs e)
        {
            this.popuniPodacima();
        }

        void popuniPodacima()
        {
            this.listaAgenata.Clear();

            listaAgenata.Columns.Add(new ColumnHeader() { Text = "Ime" });
            listaAgenata.Columns.Add(new ColumnHeader() { Text = "Prezime" });
            listaAgenata.Columns.Add(new ColumnHeader() { Text = "Telefon" });
            listaAgenata.Columns.Add(new ColumnHeader() { Text = "Procenat" });
            listaAgenata.Columns.Add(new ColumnHeader() { Text = "Datum rada" });
            //listUgovori.Columns.Add(new ColumnHeader() { Text = "Datum isteka" });

            List<AgentBasic> agenti = DTOmanager.vratiAgenteProdavca(this.prodavac.JMBG.ToString());

            foreach(AgentBasic a in agenti)
            {
                ListViewItem li = new ListViewItem(new string[] {  a.Ime, a.Prezime, a.brTel, a.Procenat.ToString(), a.DatRada.ToString() });
                this.listaAgenata.Items.Add(li);
            }

            this.listaAgenata.Refresh();
        }


        private void btnDodajAgenta_Click(object sender, EventArgs e)
        {


            DodajAgentaForm form = new DodajAgentaForm(this.prodavac);
            form.ShowDialog();
            form.Close();
        }

        private void btnIzmeniAgenta_Click(object sender, EventArgs e)
        {
            //forma za izmenjivanje sa prodavcem
            if (listaAgenata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu koju zelite da obrisete!");
                return;
            }

            string angazovanOd = listaAgenata.SelectedItems[0].SubItems[0].Text;
            AgentBasic agent = DTOmanager.vratiAgenta(angazovanOd);
            ProdavacBasic prodavac = DTOmanager.vratiProdavca(angazovanOd);
            IzmeniAgentaForm forma = new IzmeniAgentaForm(agent, prodavac);
            forma.ShowDialog();
            forma.Close();
        }

        private void btnObrisiAgenta_Click(object sender, EventArgs e)
        {
            if (listaAgenata.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite agenta kojeg zelite da obrisete!");
                return;
            }

            int angazovanOd = Int32.Parse(listaAgenata.SelectedItems[0].SubItems[0].Text);
            DTOmanager.obrisiAgenta(angazovanOd);
            MessageBox.Show("Agent uspesno obrisan");



        }

        private void AgentiForm_Load_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
