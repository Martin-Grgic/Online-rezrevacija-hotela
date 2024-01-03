using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOP_class
{
    internal class GostUSobi : IComparable
    {
        //Atributi nase klase
        private string imeGosta;
        private string prezimeGosta;
        private string oibGosta;
        private Soba soba;

        //Dodavanje constructora u klasu
        public GostUSobi(string imeGosta, string prezimeGosta, string oibGosta, Soba soba)
        {
            this.Soba = soba;
            this.imeGosta = imeGosta;
            this.prezimeGosta = prezimeGosta;
            this.oibGosta = oibGosta;
        }

        //Kreiranje javnih varijabli iz privatnih pomoću get i set
        public string ImeGosta { get { return imeGosta; } set { imeGosta = value; } }
        public string PrezimeGosta { get { return prezimeGosta; } set { prezimeGosta = value; } }
        public string OIBGosta { get { return oibGosta; } set { oibGosta = value; } }
        public Soba Soba { get { return soba; } set { soba = value; } }

        //Definiranje CompareTo() i vraćanje njegova rezultata
        public int CompareTo(object obj)
        {
            int rez = this.OIBGosta.CompareTo(((GostUSobi)obj).OIBGosta);

            return rez;

        }

        //Overrideanje ToString() da nam ispisuje željene atribute
        public override string ToString() => this.ImeGosta + ' ' + this.PrezimeGosta + ',' + this.Soba.BrojSobe;

    }

}
