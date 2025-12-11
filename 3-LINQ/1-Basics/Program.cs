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

            // Páros elemek - kiválogatás
            Console.WriteLine();
            Write("Páros elemek (lista):", F(list, IsEven));
            Write("Páros elemek (halmaz):", F(set, IsEven));
            Write("Páros elemek (tömb):", F(array, IsEven));
            Write("Páros elemek (tömb):", array.Where(IsEven));
        }
    }
}
