using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Bejegyzes("Szász Marcell Sámuel", "Tartalmat írd ide!", 0);
            b1.Like();
            b1.Kiir();
            //bejegyzes1.Szerzo;

            var bejegyzesek = new List<Bejegyzes>();
            bejegyzesek.Add(b1);
            var b2 = new Bejegyzes("Gipsz Jakab","Szabadkőgipszesek",0);
            bejegyzesek.Add(b2);
            var b3 = new Bejegyzes("Old Man","Crabonomicon",0);
            bejegyzesek.Add(b3);


            Console.WriteLine("Add meg a bekérendő számok mennyiségét!");
            int nSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bekérendő számok mennyisége: " + nSzam);

             string szerz;
             string tart;
             int likekk;

            for (int i = 0; i < nSzam; i++)
            {
                Console.WriteLine("Add meg a " + (i + 1) + ". bejegyzést a listába a következő sorrendben: szerző, tartalom, likeok!");
                szerz = Console.ReadLine();
                tart = Console.ReadLine();
                likekk = Convert.ToInt32(Console.ReadLine());

                var b = new Bejegyzes(szerz, tart, likekk);
                bejegyzesek.Add(b);
            }

            Random rand = new Random();
            for (int i = 0; i < bejegyzesek.Count * 20; i++)
            {
                bejegyzesek[rand.Next(0, bejegyzesek.Count)].Like();
            }

            Console.WriteLine("\n------------------------------\n");

            b1.Kiir();
            b2.Kiir();
            b3.Kiir();

            Console.WriteLine("\n------------------------------\n");

            bejegyzesek[1].Tartalom= "Új Tartalom.";
            bejegyzesek[1].Kiir();

            Console.WriteLine("\n------------------------------\n");

            for (int i = 0; i < bejegyzesek.Count; i++)
            {
                bejegyzesek[i].Kiir();

            }

            Console.ReadLine();

            int max = 0;
            int maxlike = 0;

            for (int i = 0; i < bejegyzesek.Count; i++)
                if (bejegyzesek[i].Likeok > maxlike)
                {
                    maxlike = bejegyzesek[i].Likeok;
                    max = i;
                }

            Console.WriteLine("A legtöbb like-al rendelkező bejegyzés sorszáma: " + max);
            Console.ReadLine();

            if (maxlike > 35)
            {
                Console.WriteLine("Van bejegyzés 35-nél több likeal, és ennek a sorszáma: " + max);

            }
            else
            {
                Console.WriteLine("Nincs olyan bejegyzés, melynek 35-nél több like-ja van.");
            }

            Console.ReadLine();

        }
    }
}
