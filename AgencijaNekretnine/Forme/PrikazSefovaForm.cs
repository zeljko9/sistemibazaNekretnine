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
    public partial class PrikazSefovaForm : Form
    {
        public PrikazSefovaForm()
        {
            InitializeComponent();
            popuniPrikaz();
        }

        void popuniPrikaz()
        {
            this.listaSefova.Clear();



            List<SefBasic> listaSefova = DTOmanager.vratiSveSefove();
            foreach(SefBasic s in listaSefova)
            {
                ListViewItem li = new ListViewItem(new string[] { s.JMBG.ToString(), s.Ime, s.Prezime, s.DatZaposlenja.ToString(), s.DatPostavljanja.ToString(),s.radiUPoslovnici.IDPoslovnice.ToString()});
                this.listaSefova.Items.Add(li);
            }

            this.listaSefova.Refresh();
        }

        private void PrikazSefovaForm_Load(object sender, EventArgs e)
        {
            popuniPrikaz();
        }
    }
}
