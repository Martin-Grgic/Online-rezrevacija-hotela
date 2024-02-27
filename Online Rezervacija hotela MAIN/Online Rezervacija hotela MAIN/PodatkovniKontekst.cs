using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Rezervacija_hotela_MAIN
{
    internal class PodatkovniKontekst
    {
        private List<Soba> _soba;

        public List<Soba> soba { get { return this._soba; } }

        public PodatkovniKontekst()
        {
            this._soba = UcitajSobu();
        }

        private string datSoba = "C:\\Users\\Martin\\source\\repos\\Online Rezervacija hotela MAIN\\Online Rezervacija hotela MAIN\\soba.dat";

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
    }
}
