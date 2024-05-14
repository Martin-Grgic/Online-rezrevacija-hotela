
using System.Collections.Generic;
using System.Windows.Forms;

namespace Online_Rezervacija_hotela_MAIN.Forme
{
    public partial class Dodaj_Gost_U_Sobi : Form
    {
        PodatkovniKontekst Kontekst;
        GostUSobi gost;
        Soba soba;
        public Dodaj_Gost_U_Sobi()
        {
            InitializeComponent();
            InitializeComponent();
            this.Kontekst = new PodatkovniKontekst();
        }

        private void DodajGost_Click(object sender, System.EventArgs e)
        {

            this.gost = new GostUSobi();
            gost.ImeGosta = ImeTB.Text;
            gost.PrezimeGosta = PrezimeTB.Text;
            gost.OIBGosta = OIBTB.Text;
            gost.Soba = listBox1.SelectedIndex.
            
        }

        private void Dodaj_Gost_U_Sobi_Load(object sender, System.EventArgs e)
        {
            List<Soba> soba = this.Kontekst.UcitajSobu();

            foreach (Soba s in soba)
                listBox1.Items.Add(s);
                
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }
    }
}
