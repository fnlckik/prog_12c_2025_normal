using System;

namespace Animals
{
    // Fontos! Abstract osztálytól örökölve
    // kötelező override-olni az abstract metódusokat!

    // sealed class: nem lehet származtatni belőle
    internal class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
            this.species = "Emlős";
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{this.name}: Miau!");
        }

        public sealed override void Sleep()
        {
            Console.WriteLine($"{this.name} alszik a billentyűzeten.");
        }
    }
}
