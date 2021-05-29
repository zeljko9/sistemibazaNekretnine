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
    public partial class DodajPoslovnicuForm : Form
    {
        private PoslovnicaBasic poslovnica;
        public DodajPoslovnicuForm()
        {
            InitializeComponent();
            poslovnica = new PoslovnicaBasic();
        }

        private void btnDodajPoslovnicu_Click(object sender, EventArgs e)
        {
            string msg = "Da li ste sigurni da zelite dodati ovu poslovnicu?";
            string title = "Potvrda";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(msg, title, buttons);

            if(result == DialogResult.OK)
            {
                string adresa = this.tbxAdresaPoslovnice.Text;
                string radniDan = this.tbxRadniDani.Text;
                string sub = this.tbxSubota.Text;
                string ned = this.tbxNedelja.Text;

                this.poslovnica.Adresa = adresa;
                this.poslovnica.RadnoVreme = radniDan + " " +  sub + " " + ned;
                DTOmanager.dodajPoslovnicu(poslovnica);
                MessageBox.Show("Uspesno ste dodali poslovnicu");
            }
        }
    }
}
