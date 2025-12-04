using System;

namespace Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Math.Sqrt(2);
            //double x = Math.PI;
            //Console.WriteLine(Coffee.BASEPRICE);
            Bakery bakery = new Bakery("arlista.txt");
            bakery.ListProducts();

            // 7. feladat
            Scone cheese = bakery.GetScone("Sajtos");
            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                int count = r.Next(3, 21);
                Console.Write($"Vásárlás: {count} db -> ");
                try
                {
                    cheese.Buy(count);
                    Console.WriteLine(cheese);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
