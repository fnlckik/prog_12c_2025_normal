using System;

namespace Bakery
{
    // static: osztályszintű
    // -> osztályhoz tartozik, nem az objektumhoz
    // -> nem kell példányosítani az eléréséhez
    internal class Coffee : IProduct
    {
        private bool isMilky;
        public static int BASEPRICE = 480;

        public Coffee(bool isMilky)
        {
            this.isMilky = isMilky;
        }

        public int GetPrice()
        {
            if (this.isMilky)
            {
                //return (int)Math.Round(1.5 * BASEPRICE);
                return Convert.ToInt32(Math.Round(1.5 * BASEPRICE));
            }
            else
            {
                return BASEPRICE;
            }
        }

        public override string ToString()
        {
            string type = isMilky ? "Tejeskávé" : "Kávé";
            return $"{type} - {GetPrice()} Ft";
        }
    }
}
