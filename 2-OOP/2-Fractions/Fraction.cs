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
                throw new DivideByZeroException(message);
            }
            this.a = a;
            this.b = b;
        }

        public double Value => (double)this.a / this.b;

        public override string ToString()
        {
            return $"{this.a} / {this.b}";
        }

        public static bool operator ==(Fraction x, Fraction y)
        {
            return x.a == y.a && x.b == y.b;
        }

        public static bool operator !=(Fraction x, Fraction y)
        {
            return !(x == y);
        }

        // Kéne: legnagyobb közös osztó
        // Euklideszi algoritmus
        public void Simplify()
        {
            // a = 12, b = 15, r = 12
            // a = 15, b = 12, r = 3
            // a = 12, b = 3, r = 0
            // Amikor r == 0, a b-ben van a legnagyobb közös osztó.
        }
    }
}
