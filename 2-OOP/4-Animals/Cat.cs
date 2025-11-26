using System;

namespace Animals
{
    // Fontos! Abstract osztálytól örökölve
    // kötelező override-olni az abstract metódusokat!
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
    }
}
