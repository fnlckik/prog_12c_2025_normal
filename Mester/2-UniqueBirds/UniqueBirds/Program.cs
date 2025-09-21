using System;
using System.Collections.Generic;
using System.IO;

namespace UniqueBirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> amounts = new List<List<int>>();
            ReadFromFile(amounts, "be2.txt");
            //ShowMatrix(amounts);
            //Console.WriteLine(IsUnique(amounts, 0)); // false
            //Console.WriteLine(IsUnique(amounts, 1)); // true
            //Console.WriteLine(IsUnique(amounts, 2)); // true

            // ~TDD: Test Driven Development
            //Console.WriteLine(HasUniqueBird(amounts, 0)); // false
            //Console.WriteLine(HasUniqueBird(amounts, 1)); // true
            //Console.WriteLine(HasUniqueBird(amounts, 2)); // true
            //Console.WriteLine(HasUniqueBird(amounts, 3)); // false

            List<int> places = GetPlaces(amounts); // 2 3
            ShowPlaces(places);
        }

        static void ShowPlaces(List<int> places)
        {
            Console.WriteLine(places.Count);
            foreach (int place in places)
            {
                Console.Write($"{place + 1} ");
            }
        }

        // Melyik helyeken van egyedi madár? (kiválogatás)
        static List<int> GetPlaces(List<List<int>> amounts)
        {
            List<int> places = new List<int>();
            for (int i = 0; i < amounts.Count; i++)
            {
                if (HasUniqueBird(amounts, i))
                {
                    places.Add(i);
                }
            }
            return places;
        }

        // Van-e egyedi madár a kapott helységben? (eldöntés)
        static bool HasUniqueBird(List<List<int>> amounts, int placeIndex)
        {
            int j = 0; // i. madarat vizsgáljuk
            while (j < amounts[placeIndex].Count && !(IsUnique(amounts, j) && amounts[placeIndex][j] > 0))
            {
                j++;
            }
            return j < amounts[placeIndex].Count;
        }

        // Egyedi-e a kapott madár? (megszámolás)
        static bool IsUnique(List<List<int>> amounts, int birdIndex)
        {
            // Hány nullától különböző érték van az oszlopban?
            int count = 0;
            for (int i = 0; i < amounts.Count; i++) // i. sor
            {
                if (amounts[i][birdIndex] != 0)
                {
                    count++;
                }
            }
            return count == 1;
        }

        static void ShowMatrix(List<List<int>> amounts)
        {
            for (int i = 0; i < amounts.Count; i++) // sorok bejárása
            {
                for (int j = 0; j < amounts[i].Count; j++) // oszlopok bejárása
                {
                    Console.Write(amounts[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ReadFromFile(List<List<int>> amounts, string file)
        {
            StreamReader sr = new StreamReader(file);
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(' '); // ["1", "0", "0"]
                List<int> row = new List<int>();
                foreach (string item in temp)
                {
                    row.Add(int.Parse(item));
                }
                amounts.Add(row);
            }
            sr.Close();
        }
    }
}
