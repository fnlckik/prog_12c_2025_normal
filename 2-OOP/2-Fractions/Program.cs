using System;

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

            // Operátorok
            Fraction x = new Fraction(4, 5);
            Fraction y = new Fraction(4, 5);
            Console.WriteLine($"{x} == {y}: {x == y}");
            //Console.WriteLine(0.1 + 0.2 == 0.3);
            Fraction z = new Fraction(12, 15);
            Console.WriteLine($"{x} == {z}: {x == z}");
        }
    }
}
