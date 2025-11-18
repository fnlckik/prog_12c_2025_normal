using System;

namespace Animals
{
    internal class Dog : Animal
    {
        // Inheritance: öröklődés
        // Dog: leszármazott (derived class)
        // Animal: ősosztály (base class)

        // Az öröklődés olyan OOP technika,
        // amely során a leszármazott osztály örökli 
        // az ősosztály adattagjait, metódusait.

        // 1. A leszármazott osztálynak kötelező meghívni
        // az ősosztály konstruktorát.
        public string breed; // fajta

        public Dog(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }

        // Itt a hiba! Nem írtuk felül!
        public override void MakeSound()
        {
            Console.WriteLine($"{name}: Vau!");
        }

        public override string ToString()
        {
            return base.ToString() + $" ({this.breed})";
        }
    }
}
