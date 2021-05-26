using AgencijaNekretnine.Entiteti;
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
    public partial class DodajOpremuForm : Form
    {
        Oprema o;
        public DodajOpremuForm(Oprema opr)
        {
            InitializeComponent();
            o = opr;
        }

        private void DodajOpremuForm_Load(object sender, EventArgs e)
        {
            if (!o.NazivOpreme.Equals(".")) {
                textNazivOpreme.Text = o.NazivOpreme;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (o.NazivOpreme.Equals("."))
            {
                o.NazivOpreme = textNazivOpreme.Text;
                DTOmanager.dodajOpremu(o);
            }
            else {
                o.NazivOpreme = textNazivOpreme.Text;
                DTOmanager.izmeniOpremu(o);
            }

            DTOmanager.izmeniOpremu(o);
        }
    }
}
