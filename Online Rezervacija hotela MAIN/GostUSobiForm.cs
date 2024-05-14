using Online_Rezervacija_hotela_MAIN.Forme;
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
    public partial class GostUSobiForm : Form
    {
        public GostUSobiForm()
        {
            InitializeComponent();

        }

        
        private void UrediButton_Click(object sender, EventArgs e)
        {
            UrediSobu uredi = new UrediSobu();
            uredi.Show();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
          new Dodaj_Gost_U_Sobi().Show();
        }
    }
}
