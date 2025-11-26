using System;

namespace Cities
{
    internal class City
    {
        private string name;
        private string country;
        private int population;
        private double gdp;

        public City(string name, string country, int population, double gdp)
        {
            if (population < 1)
            {
                throw new ArgumentException("Hiba: Nem lehet 1-nél kevesebb lakos!");
            }
            this.name = name;
            this.country = country;
            this.population = population;
            this.gdp = gdp;
        }

        public string Name { get => name; }
        public string Country { get => country; }

        public double GDPPerCapita
        {
            get
            {
                return gdp * 1000000000 / population;
            }
        }

        public override string ToString()
        {
            return $"{name} lakossága: {population} fő, GDP-je: {gdp} milliárd USD.";
        }

        public static bool operator ==(City x, City y)
        {
            return x.name == y.name && x.country == y.country;
        }

        // de Morgan azonosságok
        // not(A && B) => not(A) || not(B)
        // not(A || B) => not(A) && not(B)
        public static bool operator !=(City x, City y)
        {
            //return x.name != y.name || x.country != y.country;
            //return !(x.name == y.name && x.country == y.country);
            return !(x == y);
        }
    }
}
