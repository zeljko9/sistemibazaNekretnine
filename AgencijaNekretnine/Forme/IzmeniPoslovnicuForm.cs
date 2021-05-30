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
    public partial class IzmeniPoslovnicuForm : Form
    {
        PoslovnicaBasic poslovnica;
        public IzmeniPoslovnicuForm()
        {
            InitializeComponent();
        }

        public IzmeniPoslovnicuForm(PoslovnicaBasic p)
        {
            poslovnica = p;
            InitializeComponent();
        }

        private void IzmeniPoslovnicuForm_Load(object sedner, EventArgs arg)
        {
            this.popuniPodacima();
        }

        void popuniPodacima()
        {
            this.tbxAdresaPoslovnice.Text = this.poslovnica.Adresa;
            List<String> radno = this.poslovnica.RadnoVreme.Split(" ").ToList();
            this.tbxRadniDani.Text = radno[0];
            this.tbxSubota.Text = radno[1];
            this.tbxNedelja.Text = radno[2];

        }

        private void btnIzmeniPoslovnicu_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izvrsite izmene poslovnice?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if(result == DialogResult.OK)
            {
                this.poslovnica.Adresa = this.tbxAdresaPoslovnice.Text;
                this.poslovnica.RadnoVreme = this.tbxRadniDani.Text + " " + this.tbxSubota.Text + " " + this.tbxNedelja.Text;
                //ZOVES DTO MANAGER
                DTOmanager.izmeniPoslovnicu(this.poslovnica);
                MessageBox.Show("Uspesno azuriranje poslovnice");
                this.Close();
            }


        }
    }
}
