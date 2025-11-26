using System;
using System.Collections.Generic;

namespace Cities
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. feladat:");
            City cegled = new City("Cegléd", "Magyarország", 36125, 1.5);
            //City x = new City("Cegléd", "Magyarország", 37125, 1.5);
            Console.WriteLine(cegled);
            //Console.WriteLine(cegled == x);

            Console.WriteLine("\n4. feladat:");
            Console.WriteLine($"Cegléd 1 főre jutó GPD-je: {cegled.GDPPerCapita:0.} USD");

            Console.WriteLine("\n9. feladat:");
            CityCollection collection = new CityCollection("cities.txt");
            City poorest = collection.PoorestCity();
            Console.WriteLine($"A legkisebb GPT/fő-vel rendelkező város: {poorest}");

            // ------------------ 11. feladat ------------------
            Console.WriteLine("\n11. feladat:");
            Console.Write("Add meg egy város nevét: ");
            string city = Console.ReadLine();
            try
            {
                Console.WriteLine($"Az általad megadott város {collection[city]} területén van.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // -------------------------------------------------
        }
    }
}
