using System;

namespace Animals
{
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Miau!");
        }
    }
}
