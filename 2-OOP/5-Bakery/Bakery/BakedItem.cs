namespace Bakery
{
    internal abstract class BakedItem : IProduct
    {
        protected int quantity;
        private int price;

        protected BakedItem(int quantity, int price)
        {
            this.quantity = quantity;
            this.price = price;
        }

        public abstract void Buy(int n);

        public int GetPrice()
        {
            return price * quantity;
        }

        public virtual string GetCategory()
        {
            return "Péksütemény";
        }

        public override string ToString()
        {
            return $"{quantity} db - {GetPrice()} Ft";
        }
    }
}
