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
    public partial class IzmeniAgentaForm : Form
    {
        ProdavacBasic prodavac;
        AgentBasic agent;
        public IzmeniAgentaForm()
        {
            InitializeComponent();
        }

        public IzmeniAgentaForm(AgentBasic a, ProdavacBasic p)
        {
            this.prodavac = p;
            this.agent = a;
            InitializeComponent();
        }

        public void IzmeniAgentaForm_Load(object sender, EventArgs e)
        {
            this.popuniPrikaz();
        }

        void popuniPrikaz()
        {
            this.tbxIme.Text = this.agent.Ime;
            this.tbxPrezime.Text = this.agent.Prezime;
            this.tbxBrTel.Text = this.agent.brTel;
            this.nmudProcenat.Value = this.agent.Procenat;
            this.dtpDatPocetka.Value = this.agent.DatRada;
        }
        private void btnIzmeniAgenta_Click(object sender, EventArgs e)
        {
           // AgentBasic agent = new AgentBasic();
            agent.Ime = this.tbxIme.Text;
            agent.Prezime = this.tbxPrezime.Text;
            agent.Procenat = (int)this.nmudProcenat.Value;
            agent.brTel = this.tbxBrTel.Text;
            agent.DatRada = this.dtpDatPocetka.Value;
            agent.angazovanOd = this.prodavac;

            DTOmanager.izmeniAgenta(agent);
            MessageBox.Show("Uspesno azuriran agent");

        }
    }
}
