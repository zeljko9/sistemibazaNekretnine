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
    public partial class IzmeniLiceForm : Form
    {
        LiceBasic lb;
        public IzmeniLiceForm(LiceBasic l)
        {
            InitializeComponent();
            lb = l;
        }

        private void IzmeniLiceForm_Load(object sender, EventArgs e)
        {
            textIme.Text = lb.Ime;
            textPrezime.Text = lb.Prezime;
            textAdresa.Text = lb.Adresa;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            DTOmanager.izmeniLice(lb);
            this.Close();
        }
    }
}
