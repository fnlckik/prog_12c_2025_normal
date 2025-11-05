using System;

namespace _2_Fractions
{
    internal class Fraction
    {
        // numerator, denominator: a / b
        private int a;
        private int b;

        public Fraction(int a, int b)
        {
            if (b == 0)
            {
                string message = $"Hiba: {a} / {b}. Nem lehet 0 a nevező.";
                throw new ArgumentException(message);
            }
            this.a = a;
            this.b = b;
        }
    }
}
