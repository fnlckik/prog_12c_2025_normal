using System;

namespace Animals
{
    internal class Duck : Bird
    {
        public Duck(string name, int age) : base(name, age, true)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Háp-háp!");
        }
    }
}
