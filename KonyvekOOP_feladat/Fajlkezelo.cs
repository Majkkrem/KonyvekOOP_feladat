using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvekOOP_feladat
{
    internal class Fajlkezelo
    {
        public static List<Konyv> KonyvekBeolvasasaFajlbol(string fajlUtvonal)
        {
            List<Konyv> konyvek= new List<Konyv>();

            try
            {
                using (StreamReader sr = new StreamReader(fajlUtvonal))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] adatok = line.Split(';');
                        string cim = adatok[0];
                        string mufaj = adatok[1];
                        string szerzo_nev = adatok[2];
                        string szerzo_nemz= adatok[3];

                        Szerzo szerzo = new Szerzo(szerzo_nev, szerzo_nemz);
                        Konyv konyv = new Konyv(cim, mufaj, szerzo);

                        konyvek.Add(konyv);
                    }
                }
            }catch (Exception ex) {
                Console.WriteLine($"Hiba történt a fájl olvasása közben: {ex.Message}");
            }
            return konyvek;
        } 



    }
}
