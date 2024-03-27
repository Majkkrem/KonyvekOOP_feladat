using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KonyvekOOP_feladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Konyv> konyvek = Fajlkezelo.KonyvekBeolvasasaFajlbol("konyvek.txt");

            if (konyvek.Count > 0 )
            {
            foreach (Konyv konyv in konyvek)
            {
                Console.WriteLine(konyv.ToString());
            }
            }
            else
            {
                Console.WriteLine("Nincsenek adatok a listában!");
            }



            Console.ReadLine();
        }
    }
}
