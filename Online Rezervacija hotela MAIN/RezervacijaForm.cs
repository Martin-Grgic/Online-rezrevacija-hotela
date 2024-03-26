

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
    public partial class RezervacijaForm : Form
    {

   
        public RezervacijaForm()
        {
            InitializeComponent();
        }
      

        private void SobaButton_Click(object sender, EventArgs e)
        {
            SobaForm soba = new SobaForm();
            soba.ShowDialog();
        }

        private void GostUSobiButton_Click(object sender, EventArgs e)
        {
            GostUSobiForm gost = new GostUSobiForm();
            gost.ShowDialog();
        }

        private void SobeIGostUSobiButton_Click(object sender, EventArgs e)
        {
            SobeIGostUSobi s1 = new SobeIGostUSobi();
            s1.ShowDialog();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            Dodaj_Rezervacija rez = new Dodaj_Rezervacija();
            rez.ShowDialog();
        }

        private void IzlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
