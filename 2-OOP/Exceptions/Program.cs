using System;
using System.IO;

namespace Exceptions
{
    internal class Program
    {
        // veszélyes műveletet try{} blokkba tesszük
        // hiba kezelése catch{} blokkba
        static void E1()
        {
            Console.WriteLine("1. példa: hányados");
            int a = 23;
            int b = 0;
            try
            {
                Console.WriteLine($"Hányados: {a / b}"); // Egész osztás
            }
            catch (DivideByZeroException) // ha 0-val osztanánk
            {
                Console.WriteLine("Nem lehet 0-val osztani!");
            }
            Console.WriteLine();
        }

        static void E2()
        {
            Console.WriteLine("2. példa: konverzió");
            Console.Write("Adj meg egy egész számot: ");
            try
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"A szám ötszöröse: {5*n}");
            }
            catch (FormatException e)
            {
                //Console.WriteLine("Egész számot adj meg!");
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine();
        }

        static void E3()
        {
            Console.WriteLine("3. példa: tömb indexelés");
            string[] gyumolcsok = { "alma", "banán", "citrom", "dinnye" };
            Console.Write("Elem sorszáma: ");
            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine($"A {i}. elem: {gyumolcsok[i-1]}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Adj meg egy egész számot!");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"Adj meg egy 1 és {gyumolcsok.Length} közötti számot!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }

        static void E4()
        {
            Console.WriteLine("4. példa: fájlok");
            Console.Write("Fájl neve: ");
            string fileName = Console.ReadLine();
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string[] temp = sr.ReadLine().Split(' ');
                int a = int.Parse(temp[0]);
                int b = int.Parse(temp[1]);
                Console.WriteLine($"Beolvasott számok: {a} és {b}.");
                sr.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("A fájl első sorában szóközzel elválasztva legyen legalább két egész szám!");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("A fájlban csak egész számok legyenek!");
            }
            //catch (Exception e) // üres fájl (NullReferenceException)
            //{
            //    Console.WriteLine(e.Message);
            //}
            // Van itt egy nagy gond még...
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //E1();
            //E2();
            //E3();
            E4();
            Console.WriteLine("Program vége.");
        }
    }
}
