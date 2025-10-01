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

            public override string ToString()
            {
                return $"RGB({red},{green},{blue})";
            }
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
            T6(colors);
            T7(colors);
            //Console.WriteLine(Format(41241)); // "41 241"
            //Console.WriteLine(Format(4141)); // "4 141"
            //Console.WriteLine(Format(412041)); // "412 041"
            //Console.WriteLine(Format(141)); // "141"
            //Console.WriteLine(Format(5465465141)); // "5 465 465 141"
        }

        // 41241 => "14214"
        static string Format(long n)
        {
            // Matek: a + b == b + a
            // Stringekre: "alma" + "fa" != "fa" + "alma"
            string result = "";
            string s = n.ToString(); // 41241 => "41241"
            int count = 0;
            for (int i = s.Length-1; i >= 0; i--)
            {
                // "241" = '2' + "41"
                result = s[i] + result;
                count++;
                if (count == 3 && i > 0) // i = 0 esetén már nem rakunk
                {
                    result = " " + result;
                    count = 0;
                }
            }
            return result;
        }

        static string Dominant(Color c)
        {
            if (c.red > c.green && c.red > c.blue) return "red";
            if (c.green > c.red && c.green > c.blue) return "green";
            if (c.blue > c.red && c.blue > c.green) return "blue";
            return "";
        }

        static void T7(List<List<Color>> colors)
        {
            Console.WriteLine("7. feladat:");
            // Dictionary, szótár, Map, asszociatív tömb
            Dictionary<string, int> freq = new Dictionary<string, int>
            {
                { "red", 0 },
                { "green", 0 },
                { "blue", 0 }
            };
            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < colors[i].Count; j++)
                {
                    string color = Dominant(colors[i][j]);
                    if (color != "") freq[color]++;
                }
            }
            // Domináns komponens: nagyobb, mint a másik kettő.
            // red: 9 582 (Hány pixel esetében volt domináns?)
            // green: 4 687
            // blue: 213 280

            foreach (KeyValuePair<string, int> item in freq)
            {
                string formattedValue = Format(item.Value); // :0,00
                //string formattedValue = string.Format("{0:N0}", item.Value);
                Console.WriteLine($"{item.Key}: {formattedValue}");
            }
        }

        static void T6(List<List<Color>> colors)
        {
            Console.WriteLine("6. feladat:");
            int i = 0;
            while (i < colors.Count && !(Hatar(colors, i, 10)))
            {
                i++;
            }
            if (i < colors.Count)
            {
                Console.WriteLine($"A felhő legfelső sora: {i+1}");
            }
            i = colors.Count - 1;
            while (i >= 0 && !(Hatar(colors, i, 10)))
            {
                i--;
            }
            if (i >= 0)
            {
                Console.WriteLine($"A felhő legalsó sora: {i+1}");
            }
        }

        static int Diff(List<List<Color>> colors, int i, int j)
        {
            return Math.Abs(colors[i][j].blue - colors[i][j + 1].blue);
        }

        static bool Hatar(List<List<Color>> colors, int i, int difference)
        {
            int j = 0;
            while (j < colors[i].Count - 1 && !(Diff(colors, i, j) > difference))
            {
                j++;
            }
            return j < colors[i].Count - 1;
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
            Console.WriteLine("A legsötétebb pixelek színe:");
            for (int i = 0; i < colors.Count; i++)
            {
                for (int j = 0; j < colors[i].Count; j++)
                {
                    int currentSum = Sum(colors[i][j]);
                    if (minValue == currentSum)
                    {
                        Console.WriteLine(colors[i][j]);
                    }
                }
            }
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
