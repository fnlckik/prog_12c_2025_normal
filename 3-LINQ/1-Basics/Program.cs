using System;
using System.Collections.Generic;

namespace Basics
{
    internal class Program
    {
        // Kiírja a kapott szöveget, majd mögé a lista elemeit (egy sorba).
        static void Write(string message, List<int> lista)
        {

        }

        // Pozitív elemeket adja vissza
        static List<int> F1(List<int> lista)
        {
            throw new NotImplementedException();
        }

        // Páros elemeket adja vissza
        static List<int> F2(List<int> lista)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int> { -2, -3, 1, 1, 6, -4, 9 };
            HashSet<int> set = new HashSet<int> { 6, -7, 3, 4, 1, 23 };
            int[] array = new int[] { 5, 2, 12, 1, 3, -1, -3, 5, 24, -3 };

            // Írassuk ki az elemeket
            //Write("Elemek (lista):", list);
            //Write("Elemek (halmaz):", set);
            //Write("Elemek (tömb):", array);

            // Pozitív elemek - kiválogatás
            Console.WriteLine();
            //Write("Pozitív elemek (lista):", F1(list));
            //Write("Pozitív elemek (halmaz):", F1(set));
            //Write("Pozitív elemek (tömb):", F1(array));

            // Páros elemek - kiválogatás
            Console.WriteLine();
            //Write("Páros elemek (lista):", F2(list));
            //Write("Páros elemek (halmaz):", F2(set));
            //Write("Páros elemek (tömb):", F2(array));
        }
    }
}
