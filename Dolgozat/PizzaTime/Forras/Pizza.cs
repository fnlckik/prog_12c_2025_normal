using System;
using System.Security.Cryptography;

namespace PizzaTime
{
    public class Pizza
    {
        public string type;
        public bool isFamily;
        public int amount;

        public Pizza(string type, bool isFamily, int amount)
        {
            this.type = type;
            this.isFamily = isFamily;
            this.amount = amount;
        }

        public int Cost
        {
            get
            {
                double cost = 0;
                if (type == "Songoku") cost = 3500;
                else if (type == "Magyaros") cost = 3800;
                else cost = 4500;
                if (isFamily) cost *= 1.25;
                return (int)cost * amount;
            }
        }

        public override string ToString()
        {
            string size = isFamily ? "45 cm" : "35 cm";
            return $"{amount} X {type} ({size}) - {Cost} Ft";
        }
    }
}
