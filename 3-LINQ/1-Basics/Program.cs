using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Console.WriteLine("8. Az első páros elem: " + array.First(x => x % 2 == 0));
            Console.WriteLine("8. Az utolsó páros elem: " + array.Last(x => x % 2 == 0));
        }
    }
}
