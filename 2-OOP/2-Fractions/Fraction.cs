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

        // x["a"], x["b"]
        public int this[string s]
        {
            get
            {
                if (s == "a") return this.a;
                if (s == "b") return this.b;
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{this.a} / {this.b}";
        }

        public static bool operator ==(Fraction x, Fraction y)
        {
            //x = x.Simplify(); y = y.Simplify();
            //return x.a == y.a && x.b == y.b;
            return x.a * y.b == y.a * x.b;
        }

        public static bool operator !=(Fraction x, Fraction y)
        {
            return !(x == y);
        }

        public static Fraction operator *(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.a * y.a, x.b * y.b);
            return result.Simplify();
        }

        public static Fraction operator +(Fraction x, Fraction y)
        {
            Fraction result = new Fraction(x.a * y.b + y.a * x.b, x.b * y.b);
            return result.Simplify();
        }

        // Kéne: legnagyobb közös osztó (gcd)
        // Euklideszi algoritmus
        // 12 / 15 => 4 / 5
        public Fraction Simplify()
        {
            int a = this.a;
            int b = this.b;
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return new Fraction(this.a / b, this.b / b);
            // a = 12, b = 15, r = 12
            // a = 15, b = 12, r = 3
            // a = 12, b = 3, r = 0
            // Amikor r == 0, a b-ben van a legnagyobb közös osztó.
        }
    }
}
