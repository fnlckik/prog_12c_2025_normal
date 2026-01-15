using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace BookShop
{
    // partial: több fájlban található az osztály egy-egy része
    partial class Program
    {
        static void Print(string message, IEnumerable collection)
        {
            Console.WriteLine();
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintOne<T>(string message, T data)
        {
            Console.WriteLine($"\n{message}: {data}");
        }

        static void Main(string[] args)
        {
            #region Data seeding
            var authors = SeedAuthors();
            var books = SeedBooks();
            var orders = SeedOrders();

            Print("Szerzők:", authors);
            Print("\nKönyvek:", books);
            Print("\nRendelések:", orders);
            Console.Clear();
            #endregion

            #region Query VS Method syntax [1-5]
            // 1. A szerzők nevei
            // m = method syntax, q = query syntax
            var m1 = authors.Select(a => a.Name);
            Print("1. A szerzők nevei: ", m1);

            // Emlék: SQL
            // SELECT Name
            // FROM authors;

            var q1 = from a in authors
                     select a.Name;
            Print("1. A szerzők nevei: ", q1);

            // 2. A 400 oldalnál hosszabb könyvek: cím, oldalszám
            var m2 = books.Where(b => b.Pages > 400).Select(b => new { b.Title, b.Pages });
            Print("2. A 400 oldalnál hosszabb könyvek: ", m2);

            var q2 = from b in books
                     where b.Pages > 400
                     select new { b.Title, b.Pages };
            Print("2. A 400 oldalnál hosszabb könyvek: ", q2);

            // 3. Fantasy könyvek, év szerint növekvően
            var m3 = books.Where(b => b.Genre == "Fantasy").OrderBy(b => b.Year).ThenBy(b => b.Pages);
            Print("3. Fantasy könyvek, év szerint növekvően: ", m3);

            // Query szintaxis "mindig" select-re végződik! => vagy group by-ra
            var q3 = from b in books
                     where b.Genre == "Fantasy"
                     orderby b.Year, b.Pages
                     select b;
            Print("3. Fantasy könyvek, év szerint növekvően: ", q3);

            // 4. A 6 legdrágább könyv
            var q4 = (from b in books
                     orderby b.Price descending
                     select b).Take(6);
            Print("4. A 6 legdrágább könyv: ", q4);

            // 5. Különböző műfajok
            var q5 = (from b in books
                     select b.Genre).Distinct();
            Print("5. Különböző műfajok: ", q5);
            #endregion

            #region GroupBy [6-9]
            // 6. Műfajonként csoportosítva
            //IEnumerable<IGrouping<string, Book>> groups = books.GroupBy(b => b.Genre);
            var groups = books.GroupBy(b => b.Genre);

            var q6 = from b in books
                     group b by b.Genre;

            Console.WriteLine("\n6. Műfajonként csoportosítva:");
            foreach (IGrouping<string, Book> group in q6)
            {
                Console.WriteLine(group.Key);
                foreach (Book item in group)
                {
                    Console.WriteLine($"\t{item}");
                }
            }

            // 7. Műfajonként mennyiség (Hány ilyen könyv van?), átlag oldalszám

            // GROUP BY esetén SELECT-ben csakis
            // 1. Olyan mező, ami szerint csoportosítunk
            // 2. Aggregáló függvény: COUNT, SUM, AVG, MIN, MAX
            // SELECT Genre AS Műfaj, COUNT(*) AS Mennyiség, AVG(Pages) AS Átlagoldal
            // FROM books
            // GROUP BY Genre;
            /*
            var q7 = from b in books
                     group b by b.Genre into g
                     select new 
                     { 
                         Műfaj = g.Key,
                         Mennyiség = g.Count(),
                         Átlagoldal = Math.Round(g.Average(b => b.Pages), 2)
                     };
            */
            var m7 = books.GroupBy(b => b.Genre)
                          .Select(g => new
                          {
                              Műfaj = g.Key,
                              Mennyiség = g.Count(),
                              Átlag = g.Average(b => b.Pages)
                          });
                
            var q7 = from b in books
                     group b.Pages by b.Genre into g
                     select new
                     {
                         Műfaj = g.Key,
                         Mennyiség = g.Count(), // Hány eleme van a csoportnak?
                         Átlagoldal = Math.Round(g.Average(), 2)
                     };
            Print("7. Műfajonként mennyiség, átlag oldalszám: ", q7);

            // 8. Legalább 3 könyves műfajok
            var m8 = books.GroupBy(b => b.Genre).Where(g => g.Count() >= 3).Select(g => g.Key);
            Print("8. Legalább 3 könyves műfajok:", m8);

            // SELECT Genre
            // FROM books
            // GROUP BY Genre
            // HAVING COUNT(*) >= 3
            var q8 = from b in books
                     group b by b.Genre into g
                     where g.Count() >= 3 
                     select g.Key;
            Print("8. Legalább 3 könyves műfajok:", q8);

            // 9. Csoportosítás hossz (Hány száz oldal?) szerint
            var q9 = from b in books
                     orderby b.Pages
                     group b by new { Size = b.Pages / 100, b.Genre };
            //select new { b.Title, b.Pages, Category = b.Pages / 100 };
            //Print("9.", q9);
            Console.WriteLine("\n9. Csoportosítás hossz szerint:");
            foreach (var group in q9)
            {
                //Console.WriteLine($"A {group.Key * 100} - {group.Key * 100 + 99} oldalas könyvek:");
                Console.WriteLine($"A {group.Key.Size}00 - {group.Key.Size}99 oldalas {group.Key.Genre} könyvek:");
                foreach (var item in group)
                {
                    Console.WriteLine("\t" + item);
                }
            }
            #endregion

            // 10. Szerzők, könyvek címei:
            // { Author = "J. K. Rowling", Title = "Harry Potter és Bölcsek köve" } ...
            var q10 = from a in authors
                      join b in books on a.Id equals b.AuthorId
                      select new { Author = a.Name, b.Title } ;
            Print("10. ", q10);
        }
    }
}
