
using Online_Rezervacija_hotela_MAIN;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Online_rezervacija_hotela_MAIN
{
    public partial class SobaForm : Form
    {

        PodatkovniKontekst kontekst;
        public SobaForm() 
        {
            InitializeComponent();
            this.kontekst = new PodatkovniKontekst();

        }

        

        private void DodajButton_Click(object sender, EventArgs e)
        {
            new Dodaj_soba().Show();

        }

        private void UrediButton_Click(object sender, EventArgs e)
        {
            new Uredi().Show();
        }

        private void RefreshSobe()
        {
            ListBoxSoba.Items.Clear();
            List<Soba> soba = this.kontekst.UcitajSobu();
            foreach (Soba s in this.kontekst.soba)
            {
                ListBoxSoba.Items.Add(s);
            }
        }
        private void Soba_Load(object sender, EventArgs e)
        {

            RefreshSobe();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ListBoxSoba.Items.Clear();
            List<Soba> soba = this.kontekst.UcitajSobu();
            foreach (Soba s in this.kontekst.soba)
            {
                ListBoxSoba.Items.Add(s);
            }
        }
    }
}