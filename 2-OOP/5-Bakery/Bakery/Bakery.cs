using System.Collections.Generic;
using System.IO;
using System;

namespace Bakery
{
    internal class Bakery
    {
        private List<IProduct> products;

        public Bakery(string fileName)
        {
            products = new List<IProduct>();
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] temp = sr.ReadLine().Split(' ');
                        IProduct product;
                        if (temp.Length == 2) // Kávé
                        {
                            bool isMilky = temp[1] == "tejes";
                            product = new Coffee(isMilky);
                        }
                        else // Pogácsa
                        {
                            int quantity = int.Parse(temp[1]);
                            int price = int.Parse(temp[2]);
                            string type = temp[0].Split('_')[0];
                            product = new Scone(quantity, price, type);
                        }
                        products.Add(product);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void ListProducts()
        {
            foreach (IProduct product in products)
            {
                Console.WriteLine(product);
            }
        }

        public Scone GetScone(string type)
        {
            foreach (IProduct product in products)
            {
                if (product is Scone)
                {
                    Scone scone = product as Scone;
                    if (scone.type == type)
                    {
                        return scone;
                    }
                }
                // Hiba! Nem kasztolható!
                //Scone scone = (Scone)product;
                //if (scone.type == type) return scone;
            }
            throw new ArgumentException("Nincs ilyen pogácsa.");
        }
    }
}
