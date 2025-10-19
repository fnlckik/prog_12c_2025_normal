using System;
using System.Collections.Generic;

namespace Bitzeria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A. Helyben vásárlás
            List<List<int>> vasarlasok = new List<List<int>>
            {
                new List<int> { 4500, 5200, 3899, 4700, 5000, 5699 },
                new List<int> { 6200, 5700, 4800, 5100, 5900 },
                new List<int> { 4999, 5100, 6500, 4200, 5300, 6100, 4700 },
                new List<int> { 5000, 5800, 4620, 5400, 6000, 7199 },
                new List<int> { 4830, 5100, 5600, 6300, 5900 },
                new List<int> { 5300, 4900, 5800, 6100, 7000, 5500, 6400 },
                new List<int> { 4700, 5200, 5900, 6500, 5600, 6100 },
                new List<int> { 5400, 5800, 5000, 6200, 6700 },
                new List<int> { 4910, 5399, 6000, 7200, 5600, 6100, 6600 },
                new List<int> { 5200, 4800, 5400, 5900, 6300, 7000 }
            };

            Console.WriteLine("1. feladat:");
            ShowItems(vasarlasok);

            Console.WriteLine("\n2. feladat:");
            Console.WriteLine("Átlagos fizetendő: " + AvgSpent(vasarlasok) + " Ft");

            Console.WriteLine("\n3. feladat:");
            Coupons(vasarlasok);


            // ------------------------------------------
            // BC. Rendelés, Forgalom osztályok
            Console.WriteLine("\n11. feladat:");
            //Rendeles r = new Rendeles("Kovacs Bela", true, 8650, "Csípős nélkül kérem a gyrost!");
            //Console.WriteLine(r.Fizetendo);
            //Console.WriteLine(r);
            Forgalom f = new Forgalom("adatok.txt");
            //Console.WriteLine($"Rendelések száma: {f.OrderCount}");
            Rendeles maxRendeles = f.Legdragabb();
            Console.WriteLine(maxRendeles);
            f.KupontalanokFajlba_DIC();
        }

        private static void Coupons(List<List<int>> vasarlasok)
        {
            Random r = new Random();
            int winners = 0;

            for (int i = 0; i < vasarlasok.Count; i++)
            {
                for (int j = 0; j < vasarlasok[i].Count; j++)
                {
                    //if (vasarlasok[i][j] > 5000)
                    //{
                    //    int chance = r.Next(1, 101); // 1-100
                    //    if (chance <= 12)
                    //    {
                    //        winners++;
                    //    }
                    //}
                    //if (vasarlasok[i][j] > 5000 && r.Next(1, 101) <= 12)
                    //{
                    //    winners++;
                    //}
                    if (vasarlasok[i][j] > 5000 && r.NextDouble() <= 0.12)
                    {
                        winners++;
                    }
                }
            }
            Console.WriteLine("Kiosztott kuponok száma: " + winners + " db");
        }

        private static double AvgSpent(List<List<int>> vasarlasok)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < vasarlasok.Count; i++)
            {
                for (int j = 0; j < vasarlasok[i].Count; j++)
                {
                    count++;
                    sum += vasarlasok[i][j];
                }
            }
            return Math.Round((double)sum / count);
        }

        private static void ShowItems(List<List<int>> vasarlasok)
        {
            int rcount = 0;
            foreach (List<int> row in vasarlasok)
            {
                Console.Write(rcount + 1 + ". nap: ");
                foreach (int item in row)
                {
                    Console.Write(item + " ");
                }
                rcount++;
                Console.WriteLine();
            }
        }
    }
}
