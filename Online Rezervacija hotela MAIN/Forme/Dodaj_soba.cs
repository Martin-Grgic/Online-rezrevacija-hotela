using Online_Rezervacija_hotela_MAIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_rezervacija_hotela_MAIN
{
    public partial class Dodaj_soba : Form
    {
        PodatkovniKontekst Kontekst;
        Soba soba;
        public Dodaj_soba()
        {
            InitializeComponent();
            this.Kontekst = new PodatkovniKontekst();
        }

        private void DodajSoba_Click(object sender, EventArgs e)
        {
            
            this.soba = new Soba(int.Parse(this.BrojSobeTB.Text), this.TipSobeTB.Text, 
                double.Parse(this.CijenaNociTB.Text), double.Parse(this.VelicinaSobeTB.Text));

            this.Kontekst.SpremiSobu(this.soba);

            Close();

            
        }
    }
}
