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
    public partial class UgovorForm : Form
    {
        public UgovorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IznajmUgovorForm form = new IznajmUgovorForm();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KupoprodajniUgovorForm form = new KupoprodajniUgovorForm();
            form.ShowDialog();
        }
    }
}
