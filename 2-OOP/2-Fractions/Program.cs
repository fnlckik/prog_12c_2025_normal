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
                Fraction hiba = new Fraction(2, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
