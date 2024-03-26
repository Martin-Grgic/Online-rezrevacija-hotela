using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Rezervacija_hotela_MAIN
{
    internal partial class Soba : IComparable
    {
        //atributi naše klase
        private int brojSobe;
        private string tipSobe;
        private double cijenaNoci;
        private double velicinaSobe;

        //Dodavanje constructora klase
         public Soba(int brojSobe, string tipSobe, double cijenaNoci, double velicinaSobe)
         {
             this.brojSobe = brojSobe;
             this.tipSobe = tipSobe;
             this.cijenaNoci = cijenaNoci;
             this.velicinaSobe = velicinaSobe;
         }

        //kreiranje javnih varijabli korištenjem get i set
        public int BrojSobe { get { return brojSobe; } set { this.brojSobe = value; } }
        public string TipSobe { get { return tipSobe; } set { this.tipSobe = value; } }
        public double CijenaNoci { get { return cijenaNoci; } set { this.cijenaNoci = value; } }
        public double VelicinaSobe { get { return velicinaSobe; } set { this.velicinaSobe = value; } }

        //definiranje CompareTo i vraćanje rezultata
        public int CompareTo(object obj)
        {
            int rez = this.BrojSobe.CompareTo(((Soba)obj).BrojSobe);

            return rez;

        }
        //Overrideanje ToStringa() da nam ispisuje željene atribute
        public override string ToString() => this.brojSobe.ToString() + ','+ this.tipSobe + ',' + this.cijenaNoci.ToString() +',' + VelicinaSobe.ToString();


    }
}


