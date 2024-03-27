using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvekOOP_feladat
{
    internal class Szerzo
    {
        public string Nev {  get; set; }
        public string Nemzetiseg { get; set;}

        public Szerzo(string nev, string nemzetiseg) 
        {
            Nev = nev;
            Nemzetiseg = nemzetiseg;
        }

        public string SzerzoToString()
        {
            return $"{Nev}; {Nemzetiseg}";
        }
    }
}
