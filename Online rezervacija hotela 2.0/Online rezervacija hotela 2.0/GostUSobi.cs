﻿using System;
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
    public partial class GostUSobi : Form
    {
        public GostUSobi()
        {
            InitializeComponent();
        }

        private void DodajButton_Click(object sender, EventArgs e)
        {
            Uredi uredi = new Uredi();  
            uredi.Show();
        }

        private void UrediButton_Click(object sender, EventArgs e)
        {
            Uredi uredi = new Uredi();
            uredi.Show();
        }
    }
}
