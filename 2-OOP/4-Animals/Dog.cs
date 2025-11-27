using System;

namespace Animals
{
    // A Dog osztály örököl az Animal osztálytól.
    // A Dog osztály implementálja (megvalósítja) az ITrickPerformer interfészt.
    internal class Dog : Animal, ITrickPerformer
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
            this.species = "Emlős";
        }

        // implementáció: megvalósítása egy függvények
        // polimorfizmus: többalakúság
        // -> a leszármazott osztályok különféle módon
        // tudják implementálni az ősosztály egy metódusát
        public override void MakeSound()
        {
            Console.WriteLine($"{name}: Vau!");
        }

        public override string ToString()
        {
            return base.ToString() + $" ({this.breed})";
        }

        public void GivePaw()
        {
            Console.WriteLine($"{name} pacsit adott.");
        }

        public void PerformTrick()
        {
            Console.WriteLine($"{name} visszahozza a botot.");
        }
    }
}
