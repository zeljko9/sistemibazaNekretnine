using AgencijaNekretnine.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgencijaNekretnine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNekretnine_Click(object sender, EventArgs e)
        {
            NekretnineForm forma = new NekretnineForm();
            forma.ShowDialog();
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            ZaposleniForm form = new ZaposleniForm();
            form.ShowDialog();
        }

        private void btnKvartovi_Click(object sender, EventArgs e)
        {
            KvartoviFormcs form = new KvartoviFormcs();
            form.ShowDialog();
        }

        private void btnPoslovnice_Click(object sender, EventArgs e)
        {
            PoslovniceForm forma = new PoslovniceForm();
            forma.ShowDialog();

        }

        private void btnLica_Click(object sender, EventArgs e)
        {
            LicaForm forma = new LicaForm();
            forma.ShowDialog();
        }
    }
}
