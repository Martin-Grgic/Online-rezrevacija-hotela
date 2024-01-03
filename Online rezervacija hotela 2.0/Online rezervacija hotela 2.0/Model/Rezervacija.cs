using Online_rezervacija_hotela_2._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIOP_class
{
    internal class Rezervacija : IComparable
    {
        //Atributi nase klase
        private GostUSobi gost;
        private DateTime checkIn;
        private DateTime checkOut;
        private int brojGostiju;
        private int brojRezervacije;
        private Soba soba;

        //Dodavanje constructora
        public Rezervacija(GostUSobi gost, DateTime checkIn, DateTime checkOut, int brojGostiju, int brojRezervacije, Soba soba)
        {
            this.gost = gost;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.brojGostiju = brojGostiju;
            this.brojRezervacije = brojRezervacije;
            this.soba = soba;
        }

        //kreiranje javnih varijabli pomoću get i set
        public GostUSobi Gost { get { return gost; } set { gost = value; } }
        public DateTime CheckIn { get { return checkIn; } set { checkIn = value; } }
        public DateTime CheckOut { get { return checkOut; } set { checkOut = value; } }
        public int BrojGostiju { get { return brojGostiju; } set { brojGostiju = value; } }
        public int BrojRezervacije { get { return brojRezervacije; } set { brojRezervacije = value; } }
        public Soba Soba { get { return soba; } set { soba = value; } }

        //definiranje CompareTo i vraćanje rezultata
        public int CompareTo(object obj)
        {
            int rez = this.BrojRezervacije.CompareTo(((Rezervacija)obj).BrojRezervacije);

            return rez;
        }

        //Overrideanje ToStringa() da nam ispisuje željene atribute
        public override string ToString() => this.Gost.ImeGosta + ' ' + this.checkIn.ToString() + ',' + this.Soba.BrojSobe;


    }

}
