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
            FizickoLiceBasic fb;
            PravnoLiceBasic pb;
            if (textJP.Text.Length == 13)
            {
                fb = new FizickoLiceBasic();
                fb.JMBG_PIB = (textJP.Text);
                fb.TipLica =  "Fizicko";
                fb.Ime = textIme.Text;
                fb.Prezime = textPrezime.Text;
                fb.Adresa = textAdresa.Text;
                TelefonBasic t = new TelefonBasic();
                t.brTel = textTelefon.Text;
                t.pripadaLicu = fb;
                fb.listaTelefona.Add(t);
                DTOmanager.dodajFizickoLice(fb);
            }
            else
            {
                pb = new PravnoLiceBasic();
                pb.JMBG_PIB = (textJP.Text);
                pb.TipLica = "Pravno";
                pb.Ime = textIme.Text;
                pb.Prezime = textPrezime.Text;
                pb.Adresa = textAdresa.Text;
                TelefonBasic t = new TelefonBasic();
                t.brTel = textTelefon.Text;
                t.pripadaLicu = pb;
                pb.listaTelefona.Add(t);
                DTOmanager.dodajPravnoLice(pb);
            }

            
              

            this.Close();
            
        }

    }
}
