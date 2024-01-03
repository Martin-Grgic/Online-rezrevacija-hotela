using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NIOP_class
{
    internal class Soba : IComparable
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
        public int BrojSobe { get { return brojSobe; } set { brojSobe = value; } }
        public string TipSobe { get { return tipSobe; } set { tipSobe = value; } }
        public double CijenaNoci { get { return cijenaNoci; } set { cijenaNoci = value; } }
        public double VelicinaSobe { get { return velicinaSobe; } set { velicinaSobe = value; } }

        //definiranje CompareTo i vraćanje rezultata
        public int CompareTo(object obj)
        {
            int rez = this.BrojSobe.CompareTo(((Soba)obj).BrojSobe);

            return rez;

        }
        //Overrideanje ToStringa() da nam ispisuje željene atribute
        public override string ToString() => this.brojSobe + ',' + this.tipSobe;


    }
}
