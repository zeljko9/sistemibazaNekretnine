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
    public partial class DodajAgentaForm : Form
    {
        ProdavacBasic prodavac;
        public DodajAgentaForm()
        {
            InitializeComponent();
        }

        public DodajAgentaForm(ProdavacBasic p)
        {
            this.prodavac = p;
            InitializeComponent();
        }

        private void btnDodajAgenta_Click(object sender, EventArgs e)
        {
            AgentBasic agent = new AgentBasic();
            agent.Ime = this.tbxIme.Text;
            agent.Prezime = this.tbxPrezime.Text;
            agent.Procenat = (int)this.nmudProcenat.Value;
            agent.DatRada = this.dtpDatRada.Value;
            agent.brTel = this.tbxTelefon.Text;
            agent.angazovanOd = this.prodavac;//DTOmanager.vratiProdavca((int)this.nmudJMBG.Value);

            DTOmanager.dodajAgenta(agent);
            MessageBox.Show("Agent uspesno dodat");
        }
    }
}
