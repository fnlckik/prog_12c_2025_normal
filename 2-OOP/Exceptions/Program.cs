using System;

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

        static void Main(string[] args)
        {
            E1();
            E2();
            Console.WriteLine("Program vége.");
        }
    }
}
