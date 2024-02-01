using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_rezervacija_hotela_2._0
{
    public partial class Dodaj : Form
    {
        public Dodaj()
        {
            InitializeComponent();
        }

        private void dodajbutton_Click(object sender, EventArgs e)
        {
            int BrojSobe=Convert.ToInt32(BrojSobeTextBox.Text);
            string TipSobe = TipSobeTextBox.Text;
            double CijenaNoci = Convert.ToDouble(CijenaNociTextbox.Text);
            int VelicinaSobe
        }
    }
}
