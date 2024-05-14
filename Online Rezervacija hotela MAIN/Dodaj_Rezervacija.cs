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
 
namespace Online_rezervacija_hotela_MAIN {
    public partial class Dodaj_Rezervacija : Form
    {
        PodatkovniKontekst kontekst;
        Rezervacija rezervacija;
        public Dodaj_Rezervacija()
        {
            InitializeComponent();
            this.kontekst = new PodatkovniKontekst();
        }

        private void DodajRezervacija_Click(object sender, EventArgs e)
        {
            this.rezervacija = new Rezervacija();


        }
    }
}
