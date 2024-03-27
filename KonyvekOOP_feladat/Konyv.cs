using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvekOOP_feladat
{
    internal class Konyv
    {
        public string Cim { get; set; }
        public string Mufaj { get; set; }
        public Szerzo Szerzo { get; set; }

        public Konyv(string cim, string mufaj, Szerzo szerzo )
        {
            Cim = cim;
            Mufaj = mufaj;
            Szerzo = szerzo;
        }

        public override string ToString() 
        {
            return $"Könyv címe: {Cim}  -  Műfaja: {Mufaj}  -  Szerzője: {Szerzo.Nev}   -   Szerző nemzetisége: {Szerzo.Nemzetiseg}";
        }

    }
}
