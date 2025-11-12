using System;
using System.Collections.Generic;
using System.IO;

namespace _2_Fractions
{
    internal class Algebra
    {
        private List<Fraction> fractions;

        public Algebra(string fileName)
        {
            fractions = new List<Fraction>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream) ReadLine(sr);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }

        public List<Fraction> Fractions => new List<Fraction>(fractions);

        private void ReadLine(StreamReader sr)
        {
            try
            {
                string[] temp = sr.ReadLine().Split('/');
                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);
                Fraction fraction = new Fraction(a, b);
                fractions.Add(fraction);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Indexer
        public Fraction this[int i]
        {
            get
            {
                if (i >= fractions.Count || i < 0)
                {
                    string msg = $"i értéke 0 és {fractions.Count-1} között kell legyen!";
                    throw new ArgumentOutOfRangeException(msg);
                    // IndexOutOfRangeException
                }
                return new Fraction(fractions[i]);
            }
        }

        public Fraction SumOfFractions()
        {
            Fraction sum = new Fraction(0, 1); // egységelem
            foreach (Fraction fraction in fractions)
            {
                //sum = sum + fraction;
                sum += fraction;
            }
            return sum;
        }
    }
}
