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
            Console.WriteLine(bakery.GetScone("Sajtos"));
        }
    }
}
