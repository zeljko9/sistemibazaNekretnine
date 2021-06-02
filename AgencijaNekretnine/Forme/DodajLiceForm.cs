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
    public partial class DodajLiceForm : Form
    {
        public DodajLiceForm()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            LiceBasic lb = new LiceBasic();

            lb.JMBG_PIB = (textJP.Text);
            lb.Ime = textIme.Text;
            lb.Prezime = textPrezime.Text;
            lb.Adresa = textAdresa.Text;
            TelefonBasic t = new TelefonBasic();
            t.brTel = textTelefon.Text;
            t.pripadaLicu=lb;
            lb.listaTelefona.Add(t);

            DTOmanager.dodajLice(lb);

            this.Close();
            
        }

    }
}
