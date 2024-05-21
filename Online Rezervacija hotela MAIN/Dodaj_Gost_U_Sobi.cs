
using System.Collections.Generic;
using System.Windows.Forms;

namespace Online_Rezervacija_hotela_MAIN.Forme
{
    public partial class Dodaj_Gost_U_Sobi : Form
    {
        PodatkovniKontekst Kontekst;
        GostUSobi gost;
       
        public Dodaj_Gost_U_Sobi()
        {
            InitializeComponent();
            this.Kontekst = new PodatkovniKontekst();
        }

        private void DodajGost_Click(object sender, System.EventArgs e)
        {

            this.gost = new GostUSobi();
            gost.ImeGosta = ImeTB.Text;
            gost.PrezimeGosta = PrezimeTB.Text;
            gost.OIBGosta = OIBTB.Text;
            gost.Soba = this.Kontekst.UcitajSobu()[SobaLB.SelectedIndex];

            this.Kontekst.SpremiGostUSobi(gost);
            Close();
            
        }

        private void Dodaj_Gost_U_Sobi_Load(object sender, System.EventArgs e)
        {
            refreshGost();
                
        }


        private void refreshGost()
        {
            List<Soba> soba = this.Kontekst.UcitajSobu();

            foreach (Soba s in soba)
            {
                SobaLB.Items.Add(s);
                

            }

        }

        private void refreshButton_Click(object sender, System.EventArgs e)
        {
            refreshGost();
        }

        
    }
}
