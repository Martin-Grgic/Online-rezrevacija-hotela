using NIOP_class;
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
    public partial class Rezervacija : Form
    {
        public Rezervacija()
        {
            InitializeComponent();
        }

        private void SobaButton_Click(object sender, EventArgs e)
        {
            Soba soba = new Soba();
            soba.Show();
        }

       
        private void IzlazButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SobeIGostUSobiButton_Click(object sender, EventArgs e)
        {
            SobeIGostUSobi s1 = new SobeIGostUSobi();
            s1.Show();
        }

        private void UrediButton_Click(object sender, EventArgs e)
        {
            SobeIGostUSobi s1 = new SobeIGostUSobi();
            s1.Show();
        }

        private void GostUSobiButton_Click(object sender, EventArgs e)
        {
            GostUSobi gost = new GostUSobi();
            gost.Show();
        }
    }
}
