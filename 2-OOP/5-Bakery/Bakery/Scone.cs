namespace Bakery
{
    internal class Scone : BakedItem
    {
        public string type;

        public Scone(int quantity, int price, string type)
               : base(quantity, price)
        {
            this.type = type;
        }

        public override void Buy(int n)
        {
            
        }
    }
}
