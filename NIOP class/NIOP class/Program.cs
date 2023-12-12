using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIOP_class
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             
            Soba soba1 = new Soba(1, "dvosobna", 14.99);

            GostUSobi gost1 = new GostUSobi("Martin", "Grgic", "12541251", soba1);

            Rezervacija rez1 = new Rezervacija("Martin", new DateTime(), new DateTime(), 2, 4, soba1);



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
