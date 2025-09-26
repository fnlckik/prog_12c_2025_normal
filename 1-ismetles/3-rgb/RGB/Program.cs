using System;
using System.Collections.Generic;
using System.IO;

namespace RGB
{
    internal class Program
    {
        struct Color
        {
            public int red;
            public int green;
            public int blue;
        }

        static int Sum(Color color)
        {
            return color.red + color.green + color.blue;
        }

        static void Main(string[] args)
        {
            List<List<Color>> colors = new List<List<Color>>();
            ReadFromFile(colors, "kep.txt");
            //Console.WriteLine($"{colors.Count} {colors[0].Count}");
            //T2(colors);
            T3(colors);
            T4(colors);
        }

        static void T4(List<List<Color>> colors)
        {
            Console.WriteLine("4. feladat:");
            int minValue = Sum(colors[0][0]);
            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < colors[i].Count; j++)
                {
                    int currentSum = Sum(colors[i][j]);
                    if (minValue > currentSum)
                    {
                        minValue = currentSum;
                    }
                }
            }
            Console.WriteLine($"A legsötétebb pont RGB összege: {minValue}");
        }

        static void T3(List<List<Color>> colors)
        {
            Console.WriteLine("3. feladat:");
            int count = 0;
            //for (int i = 0; i < colors.Count; i++)
            //{
            //    for (int j = 0; j < colors[i].Count; j++)
            //    {
            //        Color c = colors[i][j];
            //        if (Sum(c) > 600)
            //        {
            //            count++;
            //        }
            //    }
            //}
            foreach (List<Color> row in colors)
            {
                foreach (Color color in row)
                {
                    if (Sum(color) > 600)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"A világos képpontok száma: {count}");
        }

        static void T2(List<List<Color>> colors)
        {
            Console.WriteLine("2. feladat:");
            Console.WriteLine("Kérem egy képpont adatait!");
            Console.Write("Sor:");
            int i = int.Parse(Console.ReadLine()); // 180
            Console.Write("Oszlop:");
            int j = int.Parse(Console.ReadLine()); // 320
            Color c = colors[i-1][j-1]; // colors[179][319]
            Console.WriteLine($"A képpont színe RGB({c.red},{c.green},{c.blue})");
        }

        static void ReadFromFile(List<List<Color>> colors, string file)
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split(' '); // "0", "85", "112", "0", ...
                List<Color> row = new List<Color>();
                for (int i = 0; i < temp.Length; i += 3)
                {
                    Color color;
                    color.red = int.Parse(temp[i]);
                    color.green = int.Parse(temp[i + 1]);
                    color.blue = int.Parse(temp[i + 2]);
                    row.Add(color);
                }
                colors.Add(row);
            }
            sr.Close();
        }
    }
}
