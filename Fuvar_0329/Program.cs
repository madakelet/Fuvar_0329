using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Fuvar_0329
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. feladat

            string[] sorok = File.ReadAllLines("fuvar.csv");
            List<Fuvar> fuvarok = new List<Fuvar>();
            foreach(string sor in sorok.Skip(1))
            {
                fuvarok.Add(new Fuvar(sor));
            }

            //3. feladat

            int hossz = fuvarok.Count;
            Console.WriteLine($"3. fealadt: {hossz} fuvar");

            //4. feladat

            int fuvarokSzama = 0;
            double bevetel = 0;
            for (int i = 0; i < hossz; i++)
            {
                if(fuvarok[i].getId() == 6185)
                {
                    fuvarokSzama++;
                    bevetel += fuvarok[i].getBorravalo();
                    bevetel += fuvarok[i].getDij();
                }
            }

            Console.WriteLine($"4. feladat: {fuvarokSzama} alatt: {bevetel}$");


            //5. feladat

            Dictionary<string, int> fizetesiModok = new Dictionary<string, int>();

            for (int i = 0; i < hossz; i++)
            {
                string kulcs = fuvarok[i].getFizetesModja();
                if(fizetesiModok.ContainsKey(kulcs))
                {
                    fizetesiModok[kulcs]++;
                }
                else
                {
                    fizetesiModok.Add(kulcs, 1);
                }
            }
            Console.WriteLine($"5. feladat:");
            foreach(KeyValuePair<string, int> item in fizetesiModok)
            {
                Console.WriteLine($"\t{item.Key}: {item.Value} fuvar");
            }

            //6. feladat

            double osszesTav = 0;
            for (int i = 0; i < hossz; i++)
            {
                double tav = fuvarok[i].getTav()* 1.6;
                osszesTav += tav;
            }
            Console.WriteLine($"6. feladat: {osszesTav:F2} km");

            //7.fealadt

            int maxIndex = 0;
            for (int i = 1; i < hossz; i++)
            {
                if(fuvarok[i].getIdotartam() > fuvarok[maxIndex].getIdotartam())
                { maxIndex = i; }
            }
            Console.WriteLine($"7. feladat: ");
            Console.WriteLine($"\tFuvar hossza: {fuvarok[maxIndex].getIdotartam()} másodperc");
            Console.WriteLine($"\tTaxi azonosítója: {fuvarok[maxIndex].getId()}");
            Console.WriteLine($"\tMegtett távolság: {fuvarok[maxIndex].getTav()*1.6} km");
            Console.WriteLine($"\tViteldíj: {fuvarok[maxIndex].getDij()} $");

            //8. feladat

            List<Fuvar> hibasFuvarok = new List<Fuvar>();
            for (int i = 0; i < hossz; i++)
            {
                if(fuvarok[i].getIdotartam() > 0 && fuvarok[i].getDij() > 0 && fuvarok[i].getTav() == 0)
                {
                    hibasFuvarok.Add(fuvarok[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
