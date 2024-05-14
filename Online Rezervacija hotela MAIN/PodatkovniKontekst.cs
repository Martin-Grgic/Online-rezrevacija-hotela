using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Rezervacija_hotela_MAIN
{
    internal class PodatkovniKontekst
    {
        private List<Soba> _soba;
        private List<GostUSobi> _gostUSobi;
        private List<Rezervacija> _rezervacija;

        public List<Soba> soba { get { return this._soba; } }
        public List<GostUSobi> gostUSobi { get { return this._gostUSobi; } }
        public List<Rezervacija> rezervacija { get { return this._rezervacija; } }

        public PodatkovniKontekst()
        {
            this._soba = UcitajSobu();
            this._gostUSobi = UcitajGostUSobi();
            this._rezervacija = UcitajRezervaciju();
        }

        private string datSoba = "soba.dat";
        private string datGostUSobi = "gost.dat";
        private string datRezervacija = "rezervacija.dat";

        public List<Soba> UcitajSobu()
        {
            List<Soba> soba = new List<Soba>();


            if (File.Exists(datSoba))
            {
                using (StreamReader sr = new StreamReader(datSoba))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] polja = line.Split('|');

                        Soba s = new Soba(int.Parse(polja[0]), polja[1], double.Parse(polja[2]), double.Parse(polja[3]));

                        soba.Add(s);
                    }
                }
            }
            return soba;
        }

        public void SpremiSobu(Soba s)
        {
            this.soba.Add(s);
            using (StreamWriter sw = new StreamWriter(datSoba))
            {

                foreach (var soba in this.soba)
                {
                    sw.WriteLine($"{soba.BrojSobe}|{soba.TipSobe}|{soba.CijenaNoci}|{soba.VelicinaSobe}");
                }

            }
        }

        public void IzbrisiSobu(Soba s)
        {
            this.soba.Remove(s);
            using (StreamWriter sw = new StreamWriter(datSoba))
            {

                foreach (var soba in this.soba)
                {   if (s.BrojSobe.Equals(soba.BrojSobe) && s.TipSobe.Equals(soba.TipSobe) && s.CijenaNoci.Equals(soba.CijenaNoci) && s.VelicinaSobe.Equals(soba.VelicinaSobe))continue;
                    else sw.WriteLine($"{soba.BrojSobe}|{soba.TipSobe}|{soba.CijenaNoci}|{soba.VelicinaSobe}");
                }
                

            }
        }

        

        public List<GostUSobi> UcitajGostUSobi()
    {
        List<GostUSobi> gost = new List<GostUSobi>();


        if (File.Exists(datGostUSobi))
        {
            using (StreamReader sr = new StreamReader(datGostUSobi))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string[] polja = line.Split('|');


                        GostUSobi g = new GostUSobi();

                            g.ImeGosta = polja[0];
                            g.PrezimeGosta = polja[1];
                            g.OIBGosta = polja[2];

                        g.Soba = new Soba(int.Parse(polja[3]), polja[4], double.Parse(polja[5]), double.Parse(polja[6]));
                       

                        

                    gost.Add(g);
                }
            }
        }
        return gost;


    }
    public void SpremiGostUSobi(GostUSobi g)
    {
        this.gostUSobi.Add(g);
        using (StreamWriter sw = new StreamWriter(datGostUSobi))
        {

            foreach (var gost in this.gostUSobi)
            {
                sw.WriteLine($"{gost.ImeGosta}|{gost.PrezimeGosta}|{gost.OIBGosta}|{gost.Soba}");
            }

        }
    }
        public List<Rezervacija> UcitajRezervaciju()
        {
            List<Rezervacija> gost = new List<Rezervacija>();


            if (File.Exists(datRezervacija))
            {
                using (StreamReader sr = new StreamReader(datRezervacija))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();

                        string[] polja = line.Split('|');


                        Rezervacija r = new Rezervacija();
                            r.Gost = new GostUSobi();
                                    r.Gost.ImeGosta = polja[0];
                                    r.Gost.PrezimeGosta = polja[1];
                                    r.Gost.OIBGosta = polja[2];
                                    r.Gost.Soba = new Soba(int.Parse(polja[3]), polja[4], double.Parse(polja[5]), double.Parse(polja[6]));
                            r.CheckIn = DateTime.Parse(polja[7]);
                            r.CheckOut = DateTime.Parse(polja[8]);
                            r.BrojGostiju = int.Parse(polja[9]);
                            r.BrojRezervacije = int.Parse(polja[10]);


                        rezervacija.Add(r);
                    }
                }
            }
            return rezervacija;


        }
        public void SpremiRezervaciju(Rezervacija r)
        {
            this.rezervacija.Add(r);
            using (StreamWriter sw = new StreamWriter(datGostUSobi))
            {

                foreach (var rezervacija in this.rezervacija)
                {
                    sw.WriteLine($"{rezervacija.Gost.ImeGosta}|{rezervacija.CheckIn}|{rezervacija.CheckOut}|{rezervacija.BrojGostiju}|{rezervacija.BrojRezervacije}|{rezervacija.Gost.Soba.BrojSobe}");
                }

            }
        }
    }
}
