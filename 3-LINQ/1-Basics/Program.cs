using System;
using System.Collections.Generic;
using System.Linq;

namespace Basics
{
    internal class Program
    {
        // Kiírja a kapott szöveget, majd mögé a lista elemeit (egy sorba).
        static void Write(string message, IEnumerable<int> collection)
        {
            Console.Write(message + " ");
            foreach (int item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Pozitív elemeket adja vissza
        static bool IsPositive(int x)
        {
            return x > 0;
        }
        
        static IEnumerable<int> F1(IEnumerable<int> lista)
        {
            List<int> result = new List<int>();
            foreach (int item in lista)
            {
                if (IsPositive(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        // Páros elemeket adja vissza
        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static IEnumerable<int> F2(IEnumerable<int> lista)
        {
            List<int> result = new List<int>();
            foreach (int item in lista)
            {
                if (IsEven(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static IEnumerable<int> F(IEnumerable<int> collection, Func<int, bool> T)
        {
            List<int> result = new List<int>();
            foreach (int item in collection)
            {
                if (T(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        static int Szorzat(IEnumerable<int> collection)
        {
            int product = 1;
            foreach (int item in collection)
            {
                product = product * item;
            }
            return product;
        }

        static int Osszeg(IEnumerable<int> collection)
        {
            int sum = 0;
            foreach (int item in collection)
            {
                sum = sum + item;
            }
            return sum;
        }

        static double Reciprokosszeg(IEnumerable<int> collection)
        {
            double result = 0;
            foreach (int item in collection)
            {
                result = result + 1.0 / item;
            }
            return result;
        }

        // ["alma", "fa"] => "almafa"
        static string Osszefuz(IEnumerable<string> collection)
        {
            string result = "";
            foreach (string item in collection)
            {
                result = result + item;
            }
            return result;
        }

        static int Minimum(IEnumerable<int> collection)
        {
            int mine = int.MaxValue;
            foreach (int item in collection)
            {
                //if (item < mine)
                //{
                //    mine = item;
                //}
                mine = item < mine ? item : mine;
            }
            return mine;
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { -2, -3, 1, 1, 6, -4, 9 };
            HashSet<int> set = new HashSet<int> { 6, -7, 3, 4, 1, 23 };
            int[] array = new int[] { 5, 2, 12, 1, 3, -1, -3, 5, 24, -3 };
            
            // Írassuk ki az elemeket
            Write("Elemek (lista):", list);
            Write("Elemek (halmaz):", set);
            Write("Elemek (tömb):", array);
            
            // Pozitív elemek - kiválogatás
            Console.WriteLine();
            Write("Pozitív elemek (lista):", F(list, IsPositive));
            Write("Pozitív elemek (halmaz):", F(set, IsPositive));
            Write("Pozitív elemek (tömb):", F(array, IsPositive));
            Write("Pozitív elemek (tömb):", array.Where(IsPositive));
            Write("Pozitív elemek (tömb):", array.Where(x => x > 0)); // lambda expression
            
            // Páros elemek - kiválogatás
            Console.WriteLine();
            Write("Páros elemek (lista):", F(list, IsEven));
            Write("Páros elemek (halmaz):", F(set, IsEven));
            Write("Páros elemek (tömb):", F(array, IsEven));
            Write("Páros elemek (tömb):", array.Where(IsEven));
            Write("Páros elemek (tömb):", array.Where(x => x % 2 == 0));

            // LINQ = Language INtegrated Query
            // sablon problémák => progtételek
            // Imperatív programozás: Hogyan akarjuk megoldani? (if, for, ...) -> C

            // progtételek => segédfüggvények
            // Deklaratív programozás: Mit akarunk megoldani? (SELECT, WHERE, ...) -> SQL

            // Progtételek
            // 1. Kiválogatás: Where
            Console.WriteLine();
            Write("1. A 10 és 20 közötti elemek:", array.Where(x => x >= 10 && x <= 20));

            // 2. Másolás: Select
            Write("2. Elemek négyzetei:", array.Select(x => x * x));

            // 3. Megszámolás: Count
            Console.WriteLine("3. Pozitív elemek száma: " + array.Count(x => x > 0));

            // 4. Összegzés: Sum
            Console.WriteLine("4. Elemek összege: " + array.Sum());
            Console.WriteLine("4. Elemek átlaga: " + array.Average());

            // 5. Minmax: Min, Max
            Console.WriteLine("5. Legnagyobb elem: " + array.Max());

            // 6. Eldöntés: Any
            Console.WriteLine("6. Van-e 10-nél nagyobb szám? " + array.Any(x => x > 10));

            // 7. Eldöntés (optimista): All
            Console.WriteLine("7. Minden elem 10-nél nagyobb? " + array.All(x => x > 10));

            // 8. Keresés: First, Last
            //List<int> empty = new List<int>();
            Console.WriteLine("8. Az első páros elem: " + array.First(x => x % 2 == 0)); // 2
            Console.WriteLine("8. Az utolsó páros elem: " + array.Last(x => x % 2 == 0));
            int firstEven = array.First(x => x % 2 == 0); // 2
            Console.WriteLine("8. Az első páros elem indexe: " + array.ToList().IndexOf(array.First(x => x % 2 == 0)));
            Console.WriteLine("8. Az első páros elem indexe: " + array.ToList().FindIndex(x => x % 2 == 0));

            // 9. Rendezés: OrderBy
            // a keySelector függvény TKey értéke: olyan típus, amire van CompareTo
            Write("9. Rendezés (növekvő):", array.OrderBy(x => x));
            Write("9. Rendezés (csökkenő):", array.OrderByDescending(x => x));
            Write("9. Rendezés (csökkenő):", array.OrderBy(x => x).Reverse());

            // 10. Halmazkészítés: Distinct
            Write("10. Elemek (duplikáció nélkül):", array.Distinct());

            // 11. Unió, metszet, különbség: Union, Intersect, Except
            Write("11. Unió (tömb, lista):", array.Union(list));
            Write("11. Metszet (tömb, lista):", array.Intersect(list));
            Write("11. Különbség (tömb, lista):", array.Except(list));

            // 12. Sorozatszámítás: Aggregate
            Console.WriteLine("12. Elemek szorzata: " + array.Aggregate(1, (result, element) => result * element));
            Console.WriteLine("12. Elemek összege: " + array.Aggregate(0, (result, element) => result + element)); // Sum
            Console.WriteLine("12. Elemek száma: " + array.Aggregate(0, (result, element) => result + 1)); // Count
            Console.WriteLine("12. Minimum érték: " + array.Aggregate(int.MaxValue, (min, e) => e < min ? e : min)); // Min

            // ------------------------------------
            Console.Clear();

            // F1: Adjuk meg a páros számok összegét!
            int evenSum = array.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("1. Párosak összege: " + evenSum);

            // F2: Hány minimális értékű elem van?
            int minValue = array.Min();
            Console.WriteLine("2. Minimumok száma: " + array.Count(x => x == array.Min()));

            // F3: Mennyi a legnagyobb átlag alatti érték?
            double avg = array.Average();
            IEnumerable<int> belows = array.Where(item => item < avg);
            //Console.WriteLine("3. Legnagyobb átlag alatti érték: " + belows.Max());
            Console.WriteLine("3. Legnagyobb átlag alatti érték: " + array.Where(x => x < array.Average()).Max());

            // F4: Melyik elemek szerepelnek kétszer?
            //array.Where(x => )

            // Egyszerűbb: adjuk meg minden elemhez, hogy hányszor szerepel!
            Write("Elemek gyakorisága: ", array.Select(x => array.Count(y => y == x)));
        }
    }
}
