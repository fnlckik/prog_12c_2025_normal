using System;

namespace Animals
{
    internal class PersianCat : Cat
    {
        public PersianCat(string name, int age) : base(name, age)
        {
        }

        // sealed: lezárt, nem módosítható alosztályokban
        //public override void Sleep()
        //{
        //    Console.WriteLine($"{this.name} alva speedrunolja a Prince of Persia-t.");
        //}
    }
}
