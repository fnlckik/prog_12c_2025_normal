using System;
using System.Collections.Generic;
using System.IO;

namespace Cities
{
    internal class CityCollection
    {
        private List<City> cities;

        public CityCollection(string fileName)
        {
            cities = new List<City>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        ReadLine(sr);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void ReadLine(StreamReader sr)
        {
            try
            {
                string[] temp = sr.ReadLine().Split(';');
                string name = temp[0];
                string coutry = temp[1];
                int population = int.Parse(temp[2]);
                double gdp = double.Parse(temp[3]);
                City city = new City(name, coutry, population, gdp);
                cities.Add(city);
            }
            catch (FormatException)
            {
                Console.WriteLine("Hiba: a lakosság egész, a gpd lebegőpontos kell legyen!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public City PoorestCity()
        {
            City poorest = cities[0];
            foreach (City city in cities)
            {
                if (city.GDPPerCapita < poorest.GDPPerCapita)
                {
                    poorest = city;
                }
            }
            return poorest;
        }

        public string this[string cityName]
        {
            get
            {
                //int i = 0;
                //while (i < cities.Count && !(cities[i].Name == cityName))
                //{
                //    i++;
                //}
                //if (i < cities.Count)
                //{
                //    return cities[i].Country;
                //}
                //else
                //{
                //    throw new KeyNotFoundException("Nincs adat ilyen városról.");
                //}
                foreach (City city in cities)
                {
                    if (city.Name == cityName)
                    {
                        return city.Country;
                    }
                }
                throw new KeyNotFoundException("Nincs adat ilyen városról.");
            }
        }
    }
}
