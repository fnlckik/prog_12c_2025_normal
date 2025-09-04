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
            double area = Area(3, 4, 5); // 6
            Console.WriteLine("3. feladat:");
            Console.WriteLine($"Terület: {area}");
        }

        private static double Area(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        private static void F2(Random r)
        {
            Console.WriteLine("2. feladat:");
            const int N = 10000000;
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                int a = r.Next(1, 21); // 5
                int b = r.Next(1, 21); // 3
                int c = r.Next(1, 21); // 4
                //Console.WriteLine($"Oldalak: {a} {b} {c}");
                if (a*a + b*b == c*c || b*b + c*c == a*a || a*a + c*c == b*b)
                {
                    count++;
                }
            }
            double percent = Math.Round((double)count / N * 100, 2);
            Console.WriteLine($"Derékszögű háromszögek száma: {percent}%");
        }
    }
}
