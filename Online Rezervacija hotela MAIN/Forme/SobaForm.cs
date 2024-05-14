
using Online_Rezervacija_hotela_MAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Online_rezervacija_hotela_MAIN
{
    public partial class SobaForm : Form
    {
        bool up = true;
        bool searched=false;
        PodatkovniKontekst kontekst;
        List<Soba> sobaPrikaz = new List<Soba>();
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
            new UrediSobu().Show();
        }

        private void RefreshSobe()
        {
            ListBoxSoba.Items.Clear();


            List<Soba> soba = this.kontekst.UcitajSobu();

            if (sobaPrikaz.Count>0 || searched)
            {
                foreach (Soba s in sobaPrikaz)
                {

                    ListBoxSoba.Items.Add(s);
                }
            }
            else
            {
                foreach (Soba s in soba)
                {
                    ListBoxSoba.Items.Add(s);
                }
            }
        }
        private void Sortiranje()
        {
            sobaPrikaz.Clear();
            UpDown.Visible = true;
            List<Soba> sobaSort = this.kontekst.UcitajSobu();

            if (SortSoba.SelectedItem.ToString() == "Cijena noci")
            {

                sobaSort.Sort((s1, s2) => s2.CijenaNoci.CompareTo(s1.CijenaNoci));

                if (up == true)
                {
                    foreach (Soba s in sobaSort)
                    {

                        sobaPrikaz.Add(s);

                    }
                }

                else
                {
                    sobaSort.Reverse();

                    foreach (Soba s in sobaSort)
                    {

                        sobaPrikaz.Add(s);

                    }
                }
            }

            if (SortSoba.SelectedItem.ToString() == "Velicina sobe")
            {
                sobaSort.Sort((s1, s2) => s2.VelicinaSobe.CompareTo(s1.VelicinaSobe));

                if (up == true)
                {
                    foreach (Soba s in sobaSort)
                    {

                        sobaPrikaz.Add(s);

                    }
                }

                else
                {
                    sobaSort.Reverse();

                    foreach (Soba s in sobaSort)
                    {

                        sobaPrikaz.Add(s);

                    }
                }
            }
            RefreshSobe();
        }
        private void Soba_Load(object sender, EventArgs e)
        {

            RefreshSobe();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshSobe();

        }

        private void SearchSoba_TextChanged(object sender, EventArgs e)
        {
            searched=true;
            
            sobaPrikaz.Clear();
            List<Soba> sobaKomplet = this.kontekst.UcitajSobu();

            foreach (Soba s in sobaKomplet)
                if (s.TipSobe.Contains(SearchSoba.Text.ToLower())) sobaPrikaz.Add(s);
                

            RefreshSobe() ;
        }

       

        private void UpDown_Click(object sender, EventArgs e)
        {
            up = !up;
            Sortiranje();
            
        }

        private void SortSoba_SelectedIndexChanged(object sender, EventArgs e)
        {

            Sortiranje();


        }

        private void ListBoxSoba_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteSoba.Visible = true;
        }

        private void DeleteSoba_Click(object sender, EventArgs e)
        {
            if(ListBoxSoba.SelectedIndex == -1) return;
            else
            {
                Soba s = ListBoxSoba.SelectedItem as Soba;

                kontekst.IzbrisiSobu(s);
            }
            sobaPrikaz.Clear();
            searched = false;
            RefreshSobe();
            
            
        }
    }
}