using System;
using System.Collections.Generic;

namespace Triangle
{
    internal class Program
    {
        static void F1(Random r)
        {
            Console.WriteLine("1. feladat:");
            int a = r.Next(1, 21);
            int b = r.Next(1, 21);
            int c = r.Next(1, 21);
            Console.WriteLine($"Oldalak: {a} {b} {c}");
            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("Szerkeszthető!");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető!");
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            F1(r);
            F2(r);
        }

        private static void F2(Random r)
        {
            Console.WriteLine("2. feladat:");
            int count = 0;
            for (int i = 0; i < 10000; i++)
            {
                int a = r.Next(1, 21);
                int b = r.Next(1, 21);
                int c = r.Next(1, 21);
                Console.WriteLine($"Oldalak: {a} {b} {c}");
                if (a*a + b*b == c*c)
                {
                    count++;
                }
            }
            Console.WriteLine($"Derékszögű háromszögek száma: {count}");
        }
    }
}
