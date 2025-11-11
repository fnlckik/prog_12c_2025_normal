using System;
using System.Xml.Linq;

namespace _2_Fractions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Fraction a = new Fraction(3, 4);
                Console.WriteLine($"Az első tört: {a}, értéke: {a.Value}");
                Fraction hiba = new Fraction(2, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();

            // Logikai operátorok
            Fraction x = new Fraction(4, 5);
            Fraction y = new Fraction(4, 5);
            Console.WriteLine($"{x} == {y}: {x == y}");
            //Console.WriteLine(0.1 + 0.2 == 0.3);
            Fraction z = new Fraction(12, 15);
            Console.WriteLine($"{x} == {z}: {x == z}");
            Console.WriteLine($"{z} => {z.Simplify()}");
            Fraction w = new Fraction(1200, 1050);
            Console.WriteLine($"{x} => {x.Simplify()}");
            Console.WriteLine($"{w} => {w.Simplify()}");
            Console.Clear();

            // Aritmetikai operátorok
            Fraction d = new Fraction(5, 6);
            Console.WriteLine($"{x} * {d} = {x * d}");
            Console.WriteLine($"{x} * {z} = {x * z}");
            Console.WriteLine($"{x} + {d} = {x + d}");
            Console.Clear();

            // Indexer
            try
            {
                Console.WriteLine($"{x} számlálója: {x["a"]}, nevező: {x["b"]}");
                Console.WriteLine($"Hiba: {x["c"]}");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Program vége.");
            Console.Clear();

            // ---------------------------------
            Algebra algebra = new Algebra("tortek.txt");
            Console.WriteLine(algebra.fractions.Count);
            Console.WriteLine("Program vége.");
        }
    }
}
