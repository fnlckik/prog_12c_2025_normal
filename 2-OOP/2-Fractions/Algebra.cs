using System;
using System.Collections.Generic;
using System.IO;

namespace _2_Fractions
{
    internal class Algebra
    {
        public List<Fraction> fractions;

        public Algebra(string fileName)
        {
            fractions = new List<Fraction>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
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
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
